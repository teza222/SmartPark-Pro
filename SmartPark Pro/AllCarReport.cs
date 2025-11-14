using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartPark_Pro;

namespace SmartPark_Pro
{
    public partial class AllCarReport : Form
    {
        private readonly SmartParkProDbEntities _db;
        private static AllCarReport _instance;
        public AllCarReport()
        {
            InitializeComponent();
            _db = new SmartParkProDbEntities();
        }


        //Singleton form
        public static AllCarReport Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new AllCarReport();
                }
                return _instance;
            }
        }

        private void ReservationScreen_Load(object sender, EventArgs e)
        {
            //Get all vehicles that are currently parked in the parking lot
            var reservations = _db.VehiclesDetecteds.Where(v => v.Operation == "Entry").Select(q => new
            {
                q.TicketNumber,
                q.Operation,
                q.LicensePlateNumber,
                q.Make,
                q.Model,
                q.Color,
                q.EntryDate,
                q.EntryTime,

            }).ToList();
            gvAllCarLot.DataSource = reservations;




        }

        private void nowParkedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get all vehicles that are currently parked in the parking lot
            var reservations = _db.VehiclesDetecteds.Where(v => v.Operation == "Entry").Select(q => new
            {
                q.TicketNumber,
                q.Operation,
                q.LicensePlateNumber,
                q.Make,
                q.Model,
                q.Color,
                q.EntryDate,
                q.EntryTime,

            }).ToList();
            gvAllCarLot.DataSource = reservations;

        }

        private void exitHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get all vehicles that have exited the parking lot
            var reservations = _db.VehiclesDetecteds.Where(v => v.Operation == "Exit").Select(q => new
            {
                q.TicketNumber,
                q.Operation,
                q.LicensePlateNumber,
                q.Make,
                q.Model,
                q.Color,
                q.EntryDate,
                q.EntryTime,
                q.ExitDate,
                q.ExitTime,
                q.Payment.Paid

            }).ToList();
            gvAllCarLot.DataSource = reservations;

        }

        private void viewOverStayedVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get all vehicles that have stayed for more than 10 hours in the parking lot
            var overstayed = _db.VehiclesDetecteds
                .Where(v => v.Operation == "Entry") 
                .AsEnumerable() 
                .Where(v =>
                {
                    DateTime entryDateTime = v.EntryDate.Date.Add(v.EntryTime);

                    TimeSpan timeDifference = DateTime.Now - entryDateTime;

                    return timeDifference.TotalHours > 10;
                })
                .Select(v => new
                {
                    v.TicketNumber,
                    Operation = "Overstayed-" + v.Operation,
                  
                    Duration = (DateTime.Now - v.EntryDate.Date.Add(v.EntryTime)).ToString("hh")+" hrs " + (DateTime.Now - v.EntryDate.Date.Add(v.EntryTime)).ToString("mm") + " mins",
                    v.LicensePlateNumber,
                    v.Make,
                    v.Model,
                    v.Color,
                    EntryDateTime = v.EntryDate.Date.Add(v.EntryTime) 
                })
                .ToList();

            gvAllCarLot.DataSource = overstayed;
        }
    }
}
