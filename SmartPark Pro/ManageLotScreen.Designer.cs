namespace SmartPark_Pro
{
    partial class ManageLotScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLotScreen));
            this.lbParkingAI = new System.Windows.Forms.Label();
            this.lbPaid = new System.Windows.Forms.Label();
            this.btExitGate = new System.Windows.Forms.Button();
            this.btEntryGate = new System.Windows.Forms.Button();
            this.tlDetails = new System.Windows.Forms.TableLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbExitTime = new System.Windows.Forms.Label();
            this.lbEntryTime = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbmake = new System.Windows.Forms.Label();
            this.lbLicensePlate = new System.Windows.Forms.Label();
            this.lbTicket = new System.Windows.Forms.Label();
            this.lbOperation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imgCarImage = new System.Windows.Forms.PictureBox();
            this.tbCurrentTime = new System.Windows.Forms.Label();
            this.tbOverStayed = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbReservedSpaced = new System.Windows.Forms.Label();
            this.tbSpaceOccupied = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAvailableSpace = new System.Windows.Forms.Label();
            this.tbparkingSpace = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btReservation = new System.Windows.Forms.Button();
            this.lbOverstayed = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tlReservation = new System.Windows.Forms.TableLayoutPanel();
            this.tbColorRES = new System.Windows.Forms.TextBox();
            this.tbModelRES = new System.Windows.Forms.TextBox();
            this.tbMakeRES = new System.Windows.Forms.TextBox();
            this.tbLicensePlateRES = new System.Windows.Forms.TextBox();
            this.gvReservations = new System.Windows.Forms.DataGridView();
            this.tlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarImage)).BeginInit();
            this.tlReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // lbParkingAI
            // 
            this.lbParkingAI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbParkingAI.AutoSize = true;
            this.lbParkingAI.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbParkingAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParkingAI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbParkingAI.Location = new System.Drawing.Point(532, 206);
            this.lbParkingAI.MinimumSize = new System.Drawing.Size(380, 0);
            this.lbParkingAI.Name = "lbParkingAI";
            this.lbParkingAI.Padding = new System.Windows.Forms.Padding(5);
            this.lbParkingAI.Size = new System.Drawing.Size(380, 34);
            this.lbParkingAI.TabIndex = 42;
            this.lbParkingAI.Text = "PARKING AI WAITING";
            this.lbParkingAI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPaid
            // 
            this.lbPaid.AutoSize = true;
            this.lbPaid.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaid.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbPaid.Location = new System.Drawing.Point(585, 562);
            this.lbPaid.Name = "lbPaid";
            this.lbPaid.Size = new System.Drawing.Size(0, 55);
            this.lbPaid.TabIndex = 41;
            // 
            // btExitGate
            // 
            this.btExitGate.BackColor = System.Drawing.Color.Crimson;
            this.btExitGate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExitGate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExitGate.Location = new System.Drawing.Point(203, 570);
            this.btExitGate.Name = "btExitGate";
            this.btExitGate.Size = new System.Drawing.Size(167, 47);
            this.btExitGate.TabIndex = 39;
            this.btExitGate.Text = "Open Exit Gate";
            this.btExitGate.UseVisualStyleBackColor = false;
            this.btExitGate.Click += new System.EventHandler(this.btExitGate_Click);
            // 
            // btEntryGate
            // 
            this.btEntryGate.BackColor = System.Drawing.Color.LimeGreen;
            this.btEntryGate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntryGate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEntryGate.Location = new System.Drawing.Point(30, 570);
            this.btEntryGate.Name = "btEntryGate";
            this.btEntryGate.Size = new System.Drawing.Size(167, 47);
            this.btEntryGate.TabIndex = 38;
            this.btEntryGate.Text = "Open Entry Gate";
            this.btEntryGate.UseVisualStyleBackColor = false;
            this.btEntryGate.Click += new System.EventHandler(this.btEntryGate_Click);
            // 
            // tlDetails
            // 
            this.tlDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlDetails.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlDetails.ColumnCount = 2;
            this.tlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlDetails.Controls.Add(this.label25, 0, 8);
            this.tlDetails.Controls.Add(this.label23, 0, 7);
            this.tlDetails.Controls.Add(this.label21, 0, 6);
            this.tlDetails.Controls.Add(this.label19, 0, 5);
            this.tlDetails.Controls.Add(this.label17, 0, 4);
            this.tlDetails.Controls.Add(this.label15, 0, 3);
            this.tlDetails.Controls.Add(this.label10, 0, 2);
            this.tlDetails.Controls.Add(this.label6, 0, 1);
            this.tlDetails.Controls.Add(this.lbDuration, 1, 8);
            this.tlDetails.Controls.Add(this.lbExitTime, 1, 7);
            this.tlDetails.Controls.Add(this.lbEntryTime, 1, 6);
            this.tlDetails.Controls.Add(this.lbColor, 1, 5);
            this.tlDetails.Controls.Add(this.lbModel, 1, 4);
            this.tlDetails.Controls.Add(this.lbmake, 1, 3);
            this.tlDetails.Controls.Add(this.lbLicensePlate, 1, 2);
            this.tlDetails.Controls.Add(this.lbTicket, 1, 1);
            this.tlDetails.Controls.Add(this.lbOperation, 1, 0);
            this.tlDetails.Controls.Add(this.label4, 0, 0);
            this.tlDetails.Location = new System.Drawing.Point(533, 239);
            this.tlDetails.Name = "tlDetails";
            this.tlDetails.RowCount = 9;
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlDetails.Size = new System.Drawing.Size(380, 293);
            this.tlDetails.TabIndex = 37;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(4, 257);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(105, 19);
            this.label25.TabIndex = 25;
            this.label25.Text = "DURATION :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(4, 225);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 19);
            this.label23.TabIndex = 24;
            this.label23.Text = "EXIT TIME :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(4, 193);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 19);
            this.label21.TabIndex = 23;
            this.label21.Text = "ENTRY TIME :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(4, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 19);
            this.label19.TabIndex = 22;
            this.label19.Text = "VEHICLE  COLOR :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 19);
            this.label17.TabIndex = 21;
            this.label17.Text = "VEHICLE MODEL :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 19);
            this.label15.TabIndex = 20;
            this.label15.Text = "VEHICLE MAKE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "LICENSE PLATE # :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "TICKET # :";
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuration.ForeColor = System.Drawing.Color.Blue;
            this.lbDuration.Location = new System.Drawing.Point(193, 257);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(0, 26);
            this.lbDuration.TabIndex = 17;
            // 
            // lbExitTime
            // 
            this.lbExitTime.AutoSize = true;
            this.lbExitTime.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExitTime.ForeColor = System.Drawing.Color.Blue;
            this.lbExitTime.Location = new System.Drawing.Point(193, 225);
            this.lbExitTime.Name = "lbExitTime";
            this.lbExitTime.Size = new System.Drawing.Size(0, 26);
            this.lbExitTime.TabIndex = 15;
            // 
            // lbEntryTime
            // 
            this.lbEntryTime.AutoSize = true;
            this.lbEntryTime.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntryTime.ForeColor = System.Drawing.Color.Blue;
            this.lbEntryTime.Location = new System.Drawing.Point(193, 193);
            this.lbEntryTime.Name = "lbEntryTime";
            this.lbEntryTime.Size = new System.Drawing.Size(0, 26);
            this.lbEntryTime.TabIndex = 13;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.ForeColor = System.Drawing.Color.Blue;
            this.lbColor.Location = new System.Drawing.Point(193, 161);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(0, 26);
            this.lbColor.TabIndex = 11;
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.ForeColor = System.Drawing.Color.Blue;
            this.lbModel.Location = new System.Drawing.Point(193, 129);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(0, 26);
            this.lbModel.TabIndex = 9;
            // 
            // lbmake
            // 
            this.lbmake.AutoSize = true;
            this.lbmake.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmake.ForeColor = System.Drawing.Color.Blue;
            this.lbmake.Location = new System.Drawing.Point(193, 97);
            this.lbmake.Name = "lbmake";
            this.lbmake.Size = new System.Drawing.Size(0, 26);
            this.lbmake.TabIndex = 7;
            // 
            // lbLicensePlate
            // 
            this.lbLicensePlate.AutoSize = true;
            this.lbLicensePlate.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicensePlate.ForeColor = System.Drawing.Color.Blue;
            this.lbLicensePlate.Location = new System.Drawing.Point(193, 65);
            this.lbLicensePlate.Name = "lbLicensePlate";
            this.lbLicensePlate.Size = new System.Drawing.Size(0, 26);
            this.lbLicensePlate.TabIndex = 5;
            // 
            // lbTicket
            // 
            this.lbTicket.AutoSize = true;
            this.lbTicket.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicket.ForeColor = System.Drawing.Color.Blue;
            this.lbTicket.Location = new System.Drawing.Point(193, 33);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(0, 26);
            this.lbTicket.TabIndex = 3;
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperation.ForeColor = System.Drawing.Color.Blue;
            this.lbOperation.Location = new System.Drawing.Point(193, 1);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(0, 26);
            this.lbOperation.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "OPERATION :";
            // 
            // imgCarImage
            // 
            this.imgCarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCarImage.Image = ((System.Drawing.Image)(resources.GetObject("imgCarImage.Image")));
            this.imgCarImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgCarImage.InitialImage")));
            this.imgCarImage.Location = new System.Drawing.Point(85, 192);
            this.imgCarImage.Name = "imgCarImage";
            this.imgCarImage.Size = new System.Drawing.Size(362, 359);
            this.imgCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCarImage.TabIndex = 36;
            this.imgCarImage.TabStop = false;
            // 
            // tbCurrentTime
            // 
            this.tbCurrentTime.AutoSize = true;
            this.tbCurrentTime.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentTime.ForeColor = System.Drawing.Color.Gold;
            this.tbCurrentTime.Location = new System.Drawing.Point(1230, 82);
            this.tbCurrentTime.MinimumSize = new System.Drawing.Size(100, 25);
            this.tbCurrentTime.Name = "tbCurrentTime";
            this.tbCurrentTime.Padding = new System.Windows.Forms.Padding(5);
            this.tbCurrentTime.Size = new System.Drawing.Size(100, 25);
            this.tbCurrentTime.TabIndex = 35;
            this.tbCurrentTime.Text = "00:00:00";
            // 
            // tbOverStayed
            // 
            this.tbOverStayed.AutoSize = true;
            this.tbOverStayed.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbOverStayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOverStayed.ForeColor = System.Drawing.Color.Gold;
            this.tbOverStayed.Location = new System.Drawing.Point(1230, 13);
            this.tbOverStayed.MinimumSize = new System.Drawing.Size(100, 25);
            this.tbOverStayed.Name = "tbOverStayed";
            this.tbOverStayed.Padding = new System.Windows.Forms.Padding(5);
            this.tbOverStayed.Size = new System.Drawing.Size(100, 25);
            this.tbOverStayed.TabIndex = 33;
            this.tbOverStayed.Text = "4 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(945, 82);
            this.label12.MinimumSize = new System.Drawing.Size(280, 25);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5);
            this.label12.Size = new System.Drawing.Size(280, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "Current Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(945, 13);
            this.label13.MinimumSize = new System.Drawing.Size(280, 25);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(5);
            this.label13.Size = new System.Drawing.Size(280, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Over Stayed";
            // 
            // tbReservedSpaced
            // 
            this.tbReservedSpaced.AutoSize = true;
            this.tbReservedSpaced.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbReservedSpaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReservedSpaced.ForeColor = System.Drawing.Color.Gold;
            this.tbReservedSpaced.Location = new System.Drawing.Point(764, 82);
            this.tbReservedSpaced.MinimumSize = new System.Drawing.Size(80, 25);
            this.tbReservedSpaced.Name = "tbReservedSpaced";
            this.tbReservedSpaced.Padding = new System.Windows.Forms.Padding(5);
            this.tbReservedSpaced.Size = new System.Drawing.Size(80, 25);
            this.tbReservedSpaced.TabIndex = 31;
            this.tbReservedSpaced.Text = "10";
            // 
            // tbSpaceOccupied
            // 
            this.tbSpaceOccupied.AutoSize = true;
            this.tbSpaceOccupied.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbSpaceOccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpaceOccupied.ForeColor = System.Drawing.Color.Gold;
            this.tbSpaceOccupied.Location = new System.Drawing.Point(764, 13);
            this.tbSpaceOccupied.MinimumSize = new System.Drawing.Size(80, 25);
            this.tbSpaceOccupied.Name = "tbSpaceOccupied";
            this.tbSpaceOccupied.Padding = new System.Windows.Forms.Padding(5);
            this.tbSpaceOccupied.Size = new System.Drawing.Size(80, 25);
            this.tbSpaceOccupied.TabIndex = 29;
            this.tbSpaceOccupied.Text = "40  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(478, 82);
            this.label8.MinimumSize = new System.Drawing.Size(280, 25);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(280, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Reserved Space";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(478, 13);
            this.label9.MinimumSize = new System.Drawing.Size(280, 25);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(280, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Space Occupied";
            // 
            // tbAvailableSpace
            // 
            this.tbAvailableSpace.AutoSize = true;
            this.tbAvailableSpace.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbAvailableSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAvailableSpace.ForeColor = System.Drawing.Color.Gold;
            this.tbAvailableSpace.Location = new System.Drawing.Point(313, 82);
            this.tbAvailableSpace.MinimumSize = new System.Drawing.Size(80, 25);
            this.tbAvailableSpace.Name = "tbAvailableSpace";
            this.tbAvailableSpace.Padding = new System.Windows.Forms.Padding(5);
            this.tbAvailableSpace.Size = new System.Drawing.Size(80, 25);
            this.tbAvailableSpace.TabIndex = 27;
            this.tbAvailableSpace.Text = "250";
            // 
            // tbparkingSpace
            // 
            this.tbparkingSpace.AutoSize = true;
            this.tbparkingSpace.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbparkingSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbparkingSpace.ForeColor = System.Drawing.Color.Gold;
            this.tbparkingSpace.Location = new System.Drawing.Point(313, 13);
            this.tbparkingSpace.MinimumSize = new System.Drawing.Size(80, 25);
            this.tbparkingSpace.Name = "tbparkingSpace";
            this.tbparkingSpace.Padding = new System.Windows.Forms.Padding(5);
            this.tbparkingSpace.Size = new System.Drawing.Size(80, 25);
            this.tbparkingSpace.TabIndex = 25;
            this.tbparkingSpace.Text = "300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-276, -256);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Parking Space";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.MinimumSize = new System.Drawing.Size(280, 25);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(280, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Available Space";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.MinimumSize = new System.Drawing.Size(280, 25);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Parking Space  ";
            // 
            // btReservation
            // 
            this.btReservation.BackColor = System.Drawing.Color.SteelBlue;
            this.btReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btReservation.Location = new System.Drawing.Point(376, 570);
            this.btReservation.Name = "btReservation";
            this.btReservation.Size = new System.Drawing.Size(167, 47);
            this.btReservation.TabIndex = 43;
            this.btReservation.Text = "Reservations";
            this.btReservation.UseVisualStyleBackColor = false;
            this.btReservation.Click += new System.EventHandler(this.btReservation_Click);
            // 
            // lbOverstayed
            // 
            this.lbOverstayed.AutoSize = true;
            this.lbOverstayed.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverstayed.ForeColor = System.Drawing.Color.Crimson;
            this.lbOverstayed.Location = new System.Drawing.Point(615, 543);
            this.lbOverstayed.Name = "lbOverstayed";
            this.lbOverstayed.Size = new System.Drawing.Size(0, 19);
            this.lbOverstayed.TabIndex = 44;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelete.Location = new System.Drawing.Point(475, 552);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(167, 47);
            this.btDelete.TabIndex = 50;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEdit.Location = new System.Drawing.Point(250, 552);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(167, 47);
            this.btEdit.TabIndex = 49;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Visible = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdd.Location = new System.Drawing.Point(30, 552);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(167, 47);
            this.btAdd.TabIndex = 48;
            this.btAdd.Text = "Save";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Visible = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancel.Location = new System.Drawing.Point(683, 552);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(167, 47);
            this.btCancel.TabIndex = 52;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Visible = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(4, 1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 19);
            this.label20.TabIndex = 19;
            this.label20.Text = "LICENSE PLATE # :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 19);
            this.label18.TabIndex = 20;
            this.label18.Text = "VEHICLE MAKE:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 19);
            this.label16.TabIndex = 21;
            this.label16.Text = "VEHICLE MODEL :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "VEHICLE  COLOR :";
            // 
            // tlReservation
            // 
            this.tlReservation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlReservation.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlReservation.ColumnCount = 2;
            this.tlReservation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlReservation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tlReservation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlReservation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlReservation.Controls.Add(this.tbColorRES, 1, 3);
            this.tlReservation.Controls.Add(this.tbModelRES, 1, 2);
            this.tlReservation.Controls.Add(this.tbMakeRES, 1, 1);
            this.tlReservation.Controls.Add(this.tbLicensePlateRES, 1, 0);
            this.tlReservation.Controls.Add(this.label14, 0, 3);
            this.tlReservation.Controls.Add(this.label16, 0, 2);
            this.tlReservation.Controls.Add(this.label18, 0, 1);
            this.tlReservation.Controls.Add(this.label20, 0, 0);
            this.tlReservation.Location = new System.Drawing.Point(533, 240);
            this.tlReservation.Name = "tlReservation";
            this.tlReservation.RowCount = 4;
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlReservation.Size = new System.Drawing.Size(380, 136);
            this.tlReservation.TabIndex = 54;
            this.tlReservation.Visible = false;
            // 
            // tbColorRES
            // 
            this.tbColorRES.Location = new System.Drawing.Point(181, 103);
            this.tbColorRES.Name = "tbColorRES";
            this.tbColorRES.Size = new System.Drawing.Size(165, 26);
            this.tbColorRES.TabIndex = 58;
            // 
            // tbModelRES
            // 
            this.tbModelRES.Location = new System.Drawing.Point(181, 70);
            this.tbModelRES.Name = "tbModelRES";
            this.tbModelRES.Size = new System.Drawing.Size(165, 26);
            this.tbModelRES.TabIndex = 57;
            // 
            // tbMakeRES
            // 
            this.tbMakeRES.Location = new System.Drawing.Point(181, 37);
            this.tbMakeRES.Name = "tbMakeRES";
            this.tbMakeRES.Size = new System.Drawing.Size(165, 26);
            this.tbMakeRES.TabIndex = 56;
            // 
            // tbLicensePlateRES
            // 
            this.tbLicensePlateRES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLicensePlateRES.Location = new System.Drawing.Point(181, 4);
            this.tbLicensePlateRES.Name = "tbLicensePlateRES";
            this.tbLicensePlateRES.Size = new System.Drawing.Size(165, 26);
            this.tbLicensePlateRES.TabIndex = 55;
            // 
            // gvReservations
            // 
            this.gvReservations.AllowUserToAddRows = false;
            this.gvReservations.AllowUserToDeleteRows = false;
            this.gvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReservations.Location = new System.Drawing.Point(30, 192);
            this.gvReservations.Name = "gvReservations";
            this.gvReservations.ReadOnly = true;
            this.gvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvReservations.Size = new System.Drawing.Size(481, 340);
            this.gvReservations.TabIndex = 55;
            this.gvReservations.Visible = false;
            // 
            // ManageLotScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1343, 730);
            this.ControlBox = false;
            this.Controls.Add(this.gvReservations);
            this.Controls.Add(this.tlReservation);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbOverstayed);
            this.Controls.Add(this.btReservation);
            this.Controls.Add(this.lbParkingAI);
            this.Controls.Add(this.lbPaid);
            this.Controls.Add(this.btExitGate);
            this.Controls.Add(this.btEntryGate);
            this.Controls.Add(this.tlDetails);
            this.Controls.Add(this.imgCarImage);
            this.Controls.Add(this.tbCurrentTime);
            this.Controls.Add(this.tbOverStayed);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbReservedSpaced);
            this.Controls.Add(this.tbSpaceOccupied);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAvailableSpace);
            this.Controls.Add(this.tbparkingSpace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageLotScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageLotsScreen";
            this.tlDetails.ResumeLayout(false);
            this.tlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarImage)).EndInit();
            this.tlReservation.ResumeLayout(false);
            this.tlReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbParkingAI;
        private System.Windows.Forms.Label lbPaid;
        private System.Windows.Forms.Button btExitGate;
        private System.Windows.Forms.Button btEntryGate;
        private System.Windows.Forms.TableLayoutPanel tlDetails;
        private System.Windows.Forms.PictureBox imgCarImage;
        private System.Windows.Forms.Label tbCurrentTime;
        private System.Windows.Forms.Label tbOverStayed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label tbReservedSpaced;
        private System.Windows.Forms.Label tbSpaceOccupied;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tbAvailableSpace;
        private System.Windows.Forms.Label tbparkingSpace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label lbExitTime;
        private System.Windows.Forms.Label lbEntryTime;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbmake;
        private System.Windows.Forms.Label lbLicensePlate;
        private System.Windows.Forms.Label lbTicket;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btReservation;
        private System.Windows.Forms.Label lbOverstayed;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tlReservation;
        private System.Windows.Forms.TextBox tbColorRES;
        private System.Windows.Forms.TextBox tbModelRES;
        private System.Windows.Forms.TextBox tbMakeRES;
        private System.Windows.Forms.TextBox tbLicensePlateRES;
        private System.Windows.Forms.DataGridView gvReservations;
    }
}