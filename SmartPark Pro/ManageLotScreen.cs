using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartPark_Pro
{

    public partial class ManageLotScreen : Form
    {
        private static ManageLotScreen _instance;
        private readonly SmartParkProDbEntities _db;
        private string vehicleMake;
        private string vehicleModel;
        private string licensePlate;
        private int ticketNumber;
        private string operation;
        private DateTime entryDate;
        private TimeSpan entryTime;
        private DateTime exitDate;
        private TimeSpan exitTime;
        private string color;
        private String duration;
        private int mediaId;
        private string baseImgURL;
        private double targetX; // Target X position (center of the screen)
        private double speed = 5;
        private Timer timer;
        private int xLocation;
        private int yLocation;
        LoadingForm loadingForm;
        private bool isEditMode;





        static Random random = new Random();

        List<string> carMake = new List<string>
        {
            "Honda",
            "Toyota",
            "Ford",
            "BMW",
            "Nissan",
            "Mazda"
        };


        //list of car models simulating possible car models that can be detected by the camera
        List<CarMake> carColor = new List<CarMake>
        {
            new CarMake
            {
                Make = "Honda",
                Models = new List<string> { "Red", "Grey", "Blue", "White", "Silver", "Silver", "White" }
            },
            new CarMake
            {
                Make = "Toyota",
                Models = new List<string> { "Beige", "Silver", "White", "Red", "Orange", "Black", "Black" }
            },
            new CarMake
            {
                Make = "Ford",
                Models = new List<string> { "White", "Orange", "Grey", "Red", "Orange", "Green", "Green" }
            },
            new CarMake
            {
                Make = "BMW",
                Models = new List<string> { "Grey", "White", "Black", "White", "Grey", "White", "Orange" }
            },
            new CarMake
            {
            Make = "Nissan",
            Models = new List<string> { "Blue", "Red", "Orange", "Red", "Brown", "Grey", "Beige" }
            },
            new CarMake
            {
            Make = "Mazda",
            Models = new List<string> { "White", "Red", "Blue", "Black", "Red", "White", "White" }
            },
        };

        List<CarMake> carModle = new List<CarMake>
        {
            new CarMake
            {
                Make = "Honda",
                Models = new List<string> { "Civic", "Accord", "CR-V", "HR-V", "Odyssey", "Insight", "Fit" }
            },
            new CarMake
            {
                Make = "Toyota",
                Models = new List<string> { "Camry", "Corolla", "RAV4", "Prius", "Tacoma", "Sienna", "Tundra" }
            },
            new CarMake
            {
                Make = "Ford",
                Models = new List<string> { "F-150", "Mustang", "Explorer", "Escape", "Ranger", "Bronco", "Maverick" }
            },
            new CarMake
            {
                Make = "BMW",
                Models = new List<string> { "3Series", "5Series", "7Series", "X3", "X5", "X7", "i8" }
            },
            new CarMake
            {
            Make = "Nissan",
            Models = new List<string> { "Altima", "Maxima", "Sentra", "Rogue", "Murano", "Pathfinder", "Versa" }
            },
            new CarMake
            {
            Make = "Mazda",
            Models = new List<string> { "Mazda3", "Mazda6", "CX-5", "CX-9", "MX-5 Miata", "CX-30", "MX-30" }
            },
        };

        public ManageLotScreen()
        {
            InitializeComponent();
            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            _db = new SmartParkProDbEntities();
            baseImgURL = "https://jarentals.net/wp-content/cars/";
            isEditMode = false;

            UpdateSpaceNumbers();

            xLocation = this.Location.X;
            yLocation = this.Location.Y;


        }

        private void createClientAccount(String licensePlateNumber)
        {
            //Convert the license plate number for default password to a byte array and hash it
            SHA256 sha = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(licensePlate);
            byte[] hash = sha.ComputeHash(bytes);
            string _password = Convert.ToBase64String(hash);

            //add a user to the database
            UserAccount userACC = new UserAccount();
            userACC.UserName = licensePlateNumber;
            userACC.Password = _password;
            userACC.Role = "user";
            _db.UserAccounts.AddOrUpdate(userACC);
            _db.SaveChanges();
        }



        // Generates a random license plate number simulating scanner reading.
        static string GenerateLicensePlate()
        {
            char[] letters = new char[2];
            char[] digits = new char[4];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)('A' + random.Next(0, 26));
            }

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = (char)('0' + random.Next(0, 10));
            }

            return new string(digits) + new string(letters);
        }

        // Generates a random car make and model. simulating a car detected by a Ai camera
        private void GenerateMake()
        {
            Random random = new Random();
            int randomIndex = random.Next(carMake.Count);
            operation = "Entry";
            entryDate = DateTime.Now;
            entryTime = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
            ticketNumber = random.Next(1000, 9999);
            
            duration = "N/A";

            int i = random.Next(carModle[randomIndex].Models.Count);
            vehicleMake = carMake[randomIndex];
            vehicleModel = carModle[randomIndex].Models[i];
            color = carColor[randomIndex].Models[i];
            licensePlate = GenerateLicensePlate();

            // Display the details.
            lbOperation.Text = operation;
            lbEntryTime.Text = entryTime.ToString();
            lbColor.Text = color;
            lbDuration.Text = duration;
            lbmake.Text = vehicleMake;
            lbModel.Text = vehicleModel;
            lbExitTime.Text = "N/A";
            lbLicensePlate.Text = licensePlate;

            // create a client account with the license plate number as the username and password
            createClientAccount(licensePlate);

        }

   

        private void Timer_Tick(object sender, EventArgs e)
        {

            tbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //Singleton form
        public static ManageLotScreen Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new ManageLotScreen();
                }
                return _instance;
            }
        }


        private async void btEntryGate_Click(object sender, EventArgs e)
        {

            loadingSate(true);
            //clear the vehicle details on the form
            if (!string.IsNullOrEmpty(lbModel.Text))
            {
                clearVehicleDetails();
                await Task.Delay(2000);
            }

            // Generate a random car make and model.

            GenerateMake();

            try
            {
                //demo detected car image simulating a car detected by the camera      
                string imagePath = baseImgURL + vehicleModel + ".png";
                imgCarImage.Image = await LoadImageFromUrlAsync(imagePath);
                lbParkingAI.Text = "VEHICLE DETECTED!";
                lbParkingAI.BackColor = Color.Crimson;
                await Task.Delay(1000);
                loadingSate(false);

                //saving vehicle so-called url to the database
                var vehiclePhoto = new Medium();
                vehiclePhoto.url = imagePath;
                _db.Media.Add(vehiclePhoto);
                _db.SaveChanges();

                //get vehicle photo id after saving to the database
                int vehiclePhotoID = vehiclePhoto.id;

                //save the vehicle details to the database
                var vehicleDetected = new VehiclesDetected();
                vehicleDetected.Operation = operation;
                vehicleDetected.EntryDate = entryDate;
                vehicleDetected.EntryTime = entryTime;
                vehicleDetected.ExitDate = exitDate;
                vehicleDetected.ExitTime = exitTime;
                vehicleDetected.LicensePlateNumber = licensePlate;
                vehicleDetected.Make = vehicleMake;
                vehicleDetected.Model = vehicleModel;
                vehicleDetected.Color = color;
                // vehicleDetected.Duration = "N/A";
                vehicleDetected.MediaId = vehiclePhotoID;

                _db.VehiclesDetecteds.Add(vehicleDetected);
                _db.SaveChanges();

                ticketNumber = vehicleDetected.TicketNumber;
                lbTicket.Text = ticketNumber.ToString();

                UpdateSpaceNumbers();

            }
            catch (Exception ex)
            {
                loadingSate(false);
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        //this function is called to update the space numbers on the form
        private void UpdateSpaceNumbers()
        {
            try
            {
                //get the number of vehicles in the lot and the number of reserved spaces
                var vehicleCount = _db.Database.SqlQuery<int>("EXEC CountVehiclesInLot").FirstOrDefault();
                // var vehicleCountReserved = _db.Database.SqlQuery<int>("EXEC CountReservedVehicles").FirstOrDefault();
                var reservationCount = LoadReservationGridView();
                int availableSpace = (300 - vehicleCount) - reservationCount;

                //update the space numbers on the form with the values from the database
                tbSpaceOccupied.Text = vehicleCount.ToString();
                tbAvailableSpace.Text = availableSpace.ToString();
                tbReservedSpaced.Text = reservationCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btExitGate_Click(object sender, EventArgs e)
        {
            //clear the vehicle details on the form
            if (!string.IsNullOrEmpty(lbModel.Text))
            {
                clearVehicleDetails();
                await Task.Delay(2000);
            }

            // Show loading popup while processing
            loadingSate(true);

            var carExiting = _db.VehiclesDetecteds.OrderBy(v => v.TicketNumber).Where(v => v.Operation == "Entry").FirstOrDefault();

            if (carExiting != null)
            {
                //update the vehicle details when the vehicle exits the lot
                operation = "Exit";
                vehicleMake = carExiting.Make;
                vehicleModel = carExiting.Model;
                entryTime = carExiting.EntryTime;
                ticketNumber = carExiting.TicketNumber;
                exitDate = DateTime.Now;
                exitTime = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                color = carExiting.Color;

                //calculate the duration the vehicle was in the lot
                DateTime startDateTime = carExiting.EntryDate.Date.Add(carExiting.EntryTime);
                DateTime endDateTime = DateTime.Now;
                TimeSpan durationTemp = endDateTime - startDateTime;
                double totalDuration = durationTemp.TotalHours;
                int hours = (int)Math.Floor(totalDuration);
                double remainderHours = totalDuration - hours;
                int minutes = (int)(remainderHours * 60);
                duration = hours + " hrs " + minutes + " mins";
                calculatePrice(carExiting, totalDuration);


                //updating the exiting vehicle details in the database
                carExiting.Operation = operation;
                carExiting.ExitDate = exitDate;
                carExiting.ExitTime = exitTime;
               // carExiting.Duration = duration;
                _db.VehiclesDetecteds.AddOrUpdate(carExiting);
                _db.SaveChanges();

                //demo detected car image simulating a car detected by the camera      
                string imagePath = carExiting.Medium.url;
                Image image = await LoadImageFromUrlAsync(imagePath);
                imgCarImage.Image = image;
                lbParkingAI.Text = "VEHICLE DETECTED!";
                lbParkingAI.BackColor = Color.Crimson;
                lbOperation.Text = operation;
                lbTicket.Text = ticketNumber.ToString();
                lbEntryTime.Text = entryTime.ToString();
                lbExitTime.Text = exitTime.ToString();
                lbColor.Text = color;
                lbmake.Text = vehicleMake;
                lbModel.Text = vehicleModel;
                lbLicensePlate.Text = carExiting.LicensePlateNumber;
                lbDuration.Text = duration;

                await Task.Delay(1000);
                loadingSate(false);

                //update the space numbers on the form
                UpdateSpaceNumbers();
            }

            else
            {
                loadingSate(false);
                MessageBox.Show("No vehicles in the lot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void calculatePrice(VehiclesDetected vehiclesExiting, double minutes)
        {

            try
            {
                //calculate the total hours and round up to the nearest hour

                int roundedHours = (int)Math.Ceiling(minutes);
                double cost = roundedHours * 250;
                //calculate overtime charges
                if (roundedHours > 10)
                {
                    cost += (roundedHours - 10) * 100;
                    lbOverstayed.Text = $"Overstayed: ${((roundedHours - 10) * 100).ToString()}";
                }
                lbPaid.Text = $"Paid: ${cost.ToString()}";

                //save the payment details to the database
                Payment payment = new Payment();
                payment.Paid = (decimal)cost;
                payment.TimeStamp = DateTime.Now;

                _db.Payments.Add(payment);
                _db.SaveChanges();

                //update the vehicle details with the payment id
                vehiclesExiting.PaymentId = payment.id;
                _db.VehiclesDetecteds.AddOrUpdate(vehiclesExiting);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private async void clearVehicleDetails()
        {

            lbOperation.Text = "";
            lbEntryTime.Text = "";
            lbExitTime.Text = "";
            lbColor.Text = "";
            lbDuration.Text = "";
            lbmake.Text = "";
            lbModel.Text = "";
            lbLicensePlate.Text = "";
            lbTicket.Text = "";
            lbPaid.Text = "";
            lbOverstayed.Text = "";
            lbParkingAI.Text = "PARKING AI WAITING";
            lbParkingAI.BackColor = Color.DeepSkyBlue;
            string imagePath = baseImgURL+"blankcar.png";
            Image images = await LoadImageFromUrlAsync(imagePath);
            imgCarImage.Image = images;

            //Rservation details
            tbColorRES.Text = String.Empty;
            tbMakeRES.Text = String.Empty;
            tbModelRES.Text = String.Empty;
            tbLicensePlateRES.Text = String.Empty;



        }
        private int LoadReservationGridView()
        {
            var reservations = _db.VehiclesDetecteds.Where(q => q.Operation == "Reservation").Select(q => new
            {
                q.TicketNumber,
                q.Operation,
                q.LicensePlateNumber,
                q.Make,
                q.Model,
                q.Color,
                q.EntryDate,
                q.EntryTime,

            }).ToList();//.Where(v => v.Operation == "Entry").FirstOrDefault();
            gvReservations.DataSource = reservations;
            gvReservations.Columns[6].HeaderText = "Reservation Date";
            gvReservations.Columns[7].HeaderText = "Reservation Time";
            gvReservations.Update();
            gvReservations.Refresh();

            return reservations.Count;
        }

        private void btReservation_Click(object sender, EventArgs e)
        {

            //show the reservation details on the form
            LoadReservationGridView();
            clearVehicleDetails();
            imgCarImage.Visible = false;
            btEntryGate.Visible = false;
            btExitGate.Visible = false;
            btReservation.Visible = false;
            btAdd.Visible = true;
            btEdit.Visible = true;
            btDelete.Visible = true;
            gvReservations.Visible = true;
            lbParkingAI.Text = "RESERVATIONS";
            lbParkingAI.BackColor = Color.Blue;
            tlDetails.Visible = false;
            tlReservation.Visible = true;
            btCancel.Visible = true;


        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            clearVehicleDetails();
            imgCarImage.Visible = true;
            btEntryGate.Visible = true;
            btExitGate.Visible = true;
            btReservation.Visible = true;
            btAdd.Visible = false;
            btEdit.Visible = false;
            btDelete.Visible = false;
            gvReservations.Visible = false;
            lbParkingAI.Text = "PARKING AI WAITING";
            lbParkingAI.BackColor = Color.DeepSkyBlue;
            tlDetails.Visible = true;
            tlReservation.Visible = false;
            btCancel.Visible = false;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbLicensePlateRES.Text) || string.IsNullOrEmpty(tbMakeRES.Text) || string.IsNullOrEmpty(tbModelRES.Text) || string.IsNullOrEmpty(tbColorRES.Text))
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                loadingSate(true);
                var ReservedLot = new VehiclesDetected();
                ReservedLot.Operation = "Reservation";
                ReservedLot.EntryDate = DateTime.Now;
                ReservedLot.EntryTime = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                ReservedLot.LicensePlateNumber = tbLicensePlateRES.Text;
                ReservedLot.Make = tbMakeRES.Text;
                ReservedLot.Model = tbModelRES.Text;
                ReservedLot.Color = tbColorRES.Text;

                if (isEditMode)
                {
                    var ticketNumber = gvReservations.SelectedRows[0].Cells[0].Value;
                    ReservedLot.TicketNumber = (int)ticketNumber;
                    isEditMode = false;
                }

                _db.VehiclesDetecteds.AddOrUpdate(ReservedLot);
                _db.SaveChanges();
                loadingSate(false);

                MessageBox.Show(
               "The Reservation was saved successfully.",
               "Reservation Saved",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
       );

                gvReservations.Refresh();
                UpdateSpaceNumbers();
                clearVehicleDetails();
                lbParkingAI.Text = "RESERVATIONS";
                lbParkingAI.BackColor = Color.Blue;

                //show the reservation details on the form
                LoadReservationGridView();
               
            }
            catch (Exception)
            {
                loadingSate(false);
                MessageBox.Show("Error adding reservation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void loadingSate(bool state)
        {

            if (state)
            {
                // Show loading popup while processing
                loadingForm = new LoadingForm();

                loadingForm.StartPosition = FormStartPosition.Manual;
                loadingForm.Location = new Point(
                    this.Location.X + (this.Width - loadingForm.Width) / 2,
                    this.Location.Y + (this.Height - loadingForm.Height) / 2
                );
                loadingForm.Show();
                loadingForm.Refresh();

            }
            else
            {
                loadingForm.Close();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            var ticketNumber = gvReservations.SelectedRows[0].Cells[0].Value;
            var reservation = _db.VehiclesDetecteds.Where(v => v.TicketNumber == (int)ticketNumber).FirstOrDefault();
            if (reservation != null)
            {
                isEditMode = true;
                tbLicensePlateRES.Text = reservation.LicensePlateNumber;
                tbMakeRES.Text = reservation.Make;
                tbModelRES.Text = reservation.Model;
                tbColorRES.Text = reservation.Color;

            }
        }



        private async void btDelete_Click(object sender, EventArgs e)
        {

            if (gvReservations.SelectedRows.Count > 0)
            {
               
                var ticketNumber = gvReservations.SelectedRows[0].Cells[0].Value;
                var reservation = _db.VehiclesDetecteds.Where(v => v.TicketNumber == (int)ticketNumber).FirstOrDefault();
                if (reservation != null)
                {
                    // Show a confirmation dialog
                    var result = MessageBox.Show(
                        $"Are you sure you want to delete the record with Ticket Number: {ticketNumber}?",
                        "Delete Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );


                    if (result == DialogResult.Yes)
                    {
                        loadingSate(true);
                        _db.VehiclesDetecteds.Remove(reservation);
                        _db.SaveChanges();
                        await Task.Delay(1000);
                        LoadReservationGridView();
                        UpdateSpaceNumbers();
                        loadingSate(false);
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Please select a reservation to delete.");
            }
        }

        public async Task<Image> LoadImageFromUrlAsync(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                byte[] data = await response.Content.ReadAsByteArrayAsync();
                using (MemoryStream mem = new MemoryStream(data))
                {
                    return Image.FromStream(mem);
                }
            }
        }

     
    }
}
// Class to hold a car make and its models.
public class CarMake
{
    public string Make { get; set; }
    public List<string> Models { get; set; }
}

