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
            this.lbPaid = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbOverstayed = new System.Windows.Forms.Label();
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
            this.roundedLabel1 = new RoundedLabel();
            this.tbparkingSpace = new RoundedLabel();
            this.tbAvailableSpace = new RoundedLabel();
            this.roundedLabel3 = new RoundedLabel();
            this.tbReservedSpaced = new RoundedLabel();
            this.roundedLabel4 = new RoundedLabel();
            this.tbSpaceOccupied = new RoundedLabel();
            this.roundedLabel6 = new RoundedLabel();
            this.tbCurrentTime = new RoundedLabel();
            this.roundedLabel5 = new RoundedLabel();
            this.tbOverStayed = new RoundedLabel();
            this.roundedLabel8 = new RoundedLabel();
            this.lbParkingAI = new RoundedLabel();
            this.btAdd = new RoundedButton();
            this.btEdit = new RoundedButton();
            this.btDelete = new RoundedButton();
            this.btCancel = new RoundedButton();
            this.btEntryGate = new RoundedButton();
            this.btExitGate = new RoundedButton();
            this.btReservation = new RoundedButton();
            this.tlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarImage)).BeginInit();
            this.tlReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPaid
            // 
            this.lbPaid.AutoSize = true;
            this.lbPaid.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaid.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbPaid.Location = new System.Drawing.Point(898, 808);
            this.lbPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPaid.Name = "lbPaid";
            this.lbPaid.Size = new System.Drawing.Size(0, 82);
            this.lbPaid.TabIndex = 41;
            // 
            // tlDetails
            // 
            this.tlDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlDetails.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlDetails.ColumnCount = 2;
            this.tlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
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
            this.tlDetails.Location = new System.Drawing.Point(825, 236);
            this.tlDetails.Margin = new System.Windows.Forms.Padding(4);
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
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlDetails.Size = new System.Drawing.Size(556, 498);
            this.tlDetails.TabIndex = 37;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(7, 443);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(157, 29);
            this.label25.TabIndex = 25;
            this.label25.Text = "DURATION :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(7, 388);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(146, 29);
            this.label23.TabIndex = 24;
            this.label23.Text = "EXIT TIME :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 333);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(169, 29);
            this.label21.TabIndex = 23;
            this.label21.Text = "ENTRY TIME :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 278);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(227, 29);
            this.label19.TabIndex = 22;
            this.label19.Text = "VEHICLE  COLOR :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 223);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(224, 29);
            this.label17.TabIndex = 21;
            this.label17.Text = "VEHICLE MODEL :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 168);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(199, 29);
            this.label15.TabIndex = 20;
            this.label15.Text = "VEHICLE MAKE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "LICENSE PLATE # :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "TICKET # :";
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuration.ForeColor = System.Drawing.Color.Blue;
            this.lbDuration.Location = new System.Drawing.Point(283, 443);
            this.lbDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(0, 39);
            this.lbDuration.TabIndex = 17;
            // 
            // lbExitTime
            // 
            this.lbExitTime.AutoSize = true;
            this.lbExitTime.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExitTime.ForeColor = System.Drawing.Color.Blue;
            this.lbExitTime.Location = new System.Drawing.Point(283, 388);
            this.lbExitTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExitTime.Name = "lbExitTime";
            this.lbExitTime.Size = new System.Drawing.Size(0, 39);
            this.lbExitTime.TabIndex = 15;
            // 
            // lbEntryTime
            // 
            this.lbEntryTime.AutoSize = true;
            this.lbEntryTime.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntryTime.ForeColor = System.Drawing.Color.Blue;
            this.lbEntryTime.Location = new System.Drawing.Point(283, 333);
            this.lbEntryTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEntryTime.Name = "lbEntryTime";
            this.lbEntryTime.Size = new System.Drawing.Size(0, 39);
            this.lbEntryTime.TabIndex = 13;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.ForeColor = System.Drawing.Color.Blue;
            this.lbColor.Location = new System.Drawing.Point(283, 278);
            this.lbColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(0, 39);
            this.lbColor.TabIndex = 11;
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.ForeColor = System.Drawing.Color.Blue;
            this.lbModel.Location = new System.Drawing.Point(283, 223);
            this.lbModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(0, 39);
            this.lbModel.TabIndex = 9;
            // 
            // lbmake
            // 
            this.lbmake.AutoSize = true;
            this.lbmake.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmake.ForeColor = System.Drawing.Color.Blue;
            this.lbmake.Location = new System.Drawing.Point(283, 168);
            this.lbmake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmake.Name = "lbmake";
            this.lbmake.Size = new System.Drawing.Size(0, 39);
            this.lbmake.TabIndex = 7;
            // 
            // lbLicensePlate
            // 
            this.lbLicensePlate.AutoSize = true;
            this.lbLicensePlate.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicensePlate.ForeColor = System.Drawing.Color.Blue;
            this.lbLicensePlate.Location = new System.Drawing.Point(283, 113);
            this.lbLicensePlate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLicensePlate.Name = "lbLicensePlate";
            this.lbLicensePlate.Size = new System.Drawing.Size(0, 39);
            this.lbLicensePlate.TabIndex = 5;
            // 
            // lbTicket
            // 
            this.lbTicket.AutoSize = true;
            this.lbTicket.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicket.ForeColor = System.Drawing.Color.Blue;
            this.lbTicket.Location = new System.Drawing.Point(283, 58);
            this.lbTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(0, 39);
            this.lbTicket.TabIndex = 3;
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperation.ForeColor = System.Drawing.Color.Blue;
            this.lbOperation.Location = new System.Drawing.Point(283, 3);
            this.lbOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(0, 39);
            this.lbOperation.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "OPERATION :";
            // 
            // imgCarImage
            // 
            this.imgCarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCarImage.Image = ((System.Drawing.Image)(resources.GetObject("imgCarImage.Image")));
            this.imgCarImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgCarImage.InitialImage")));
            this.imgCarImage.Location = new System.Drawing.Point(51, 178);
            this.imgCarImage.Margin = new System.Windows.Forms.Padding(4);
            this.imgCarImage.Name = "imgCarImage";
            this.imgCarImage.Size = new System.Drawing.Size(600, 554);
            this.imgCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCarImage.TabIndex = 36;
            this.imgCarImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-414, -384);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(8);
            this.label3.Size = new System.Drawing.Size(141, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "Parking Space";
            // 
            // lbOverstayed
            // 
            this.lbOverstayed.AutoSize = true;
            this.lbOverstayed.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverstayed.ForeColor = System.Drawing.Color.Crimson;
            this.lbOverstayed.Location = new System.Drawing.Point(922, 792);
            this.lbOverstayed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOverstayed.Name = "lbOverstayed";
            this.lbOverstayed.Size = new System.Drawing.Size(0, 27);
            this.lbOverstayed.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 3);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(223, 29);
            this.label20.TabIndex = 19;
            this.label20.Text = "LICENSE PLATE # :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 56);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(199, 29);
            this.label18.TabIndex = 20;
            this.label18.Text = "VEHICLE MAKE:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 109);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(224, 29);
            this.label16.TabIndex = 21;
            this.label16.Text = "VEHICLE MODEL :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 162);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(227, 29);
            this.label14.TabIndex = 22;
            this.label14.Text = "VEHICLE  COLOR :";
            // 
            // tlReservation
            // 
            this.tlReservation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlReservation.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlReservation.ColumnCount = 2;
            this.tlReservation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlReservation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tlReservation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlReservation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlReservation.Controls.Add(this.tbColorRES, 1, 3);
            this.tlReservation.Controls.Add(this.tbModelRES, 1, 2);
            this.tlReservation.Controls.Add(this.tbMakeRES, 1, 1);
            this.tlReservation.Controls.Add(this.tbLicensePlateRES, 1, 0);
            this.tlReservation.Controls.Add(this.label16, 0, 2);
            this.tlReservation.Controls.Add(this.label18, 0, 1);
            this.tlReservation.Controls.Add(this.label20, 0, 0);
            this.tlReservation.Controls.Add(this.label14, 0, 3);
            this.tlReservation.Location = new System.Drawing.Point(825, 236);
            this.tlReservation.Margin = new System.Windows.Forms.Padding(4);
            this.tlReservation.Name = "tlReservation";
            this.tlReservation.RowCount = 4;
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlReservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlReservation.Size = new System.Drawing.Size(556, 216);
            this.tlReservation.TabIndex = 54;
            this.tlReservation.Visible = false;
            // 
            // tbColorRES
            // 
            this.tbColorRES.Location = new System.Drawing.Point(281, 166);
            this.tbColorRES.Margin = new System.Windows.Forms.Padding(4);
            this.tbColorRES.Name = "tbColorRES";
            this.tbColorRES.Size = new System.Drawing.Size(246, 26);
            this.tbColorRES.TabIndex = 58;
            // 
            // tbModelRES
            // 
            this.tbModelRES.Location = new System.Drawing.Point(281, 113);
            this.tbModelRES.Margin = new System.Windows.Forms.Padding(4);
            this.tbModelRES.Name = "tbModelRES";
            this.tbModelRES.Size = new System.Drawing.Size(246, 26);
            this.tbModelRES.TabIndex = 57;
            // 
            // tbMakeRES
            // 
            this.tbMakeRES.Location = new System.Drawing.Point(281, 60);
            this.tbMakeRES.Margin = new System.Windows.Forms.Padding(4);
            this.tbMakeRES.Name = "tbMakeRES";
            this.tbMakeRES.Size = new System.Drawing.Size(246, 26);
            this.tbMakeRES.TabIndex = 56;
            // 
            // tbLicensePlateRES
            // 
            this.tbLicensePlateRES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLicensePlateRES.Location = new System.Drawing.Point(281, 7);
            this.tbLicensePlateRES.Margin = new System.Windows.Forms.Padding(4);
            this.tbLicensePlateRES.Name = "tbLicensePlateRES";
            this.tbLicensePlateRES.Size = new System.Drawing.Size(246, 26);
            this.tbLicensePlateRES.TabIndex = 55;
            // 
            // gvReservations
            // 
            this.gvReservations.AllowUserToAddRows = false;
            this.gvReservations.AllowUserToDeleteRows = false;
            this.gvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReservations.Location = new System.Drawing.Point(51, 178);
            this.gvReservations.Margin = new System.Windows.Forms.Padding(4);
            this.gvReservations.Name = "gvReservations";
            this.gvReservations.ReadOnly = true;
            this.gvReservations.RowHeadersWidth = 62;
            this.gvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvReservations.Size = new System.Drawing.Size(723, 440);
            this.gvReservations.TabIndex = 55;
            this.gvReservations.Visible = false;
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.AutoSize = true;
            this.roundedLabel1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.roundedLabel1.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedLabel1.BorderRadius = 20;
            this.roundedLabel1.BorderSize = 2;
            this.roundedLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel1.ForeColor = System.Drawing.Color.White;
            this.roundedLabel1.Location = new System.Drawing.Point(46, 36);
            this.roundedLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundedLabel1.MinimumSize = new System.Drawing.Size(270, 45);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.Size = new System.Drawing.Size(270, 45);
            this.roundedLabel1.TabIndex = 56;
            this.roundedLabel1.Text = "Parking Space  ";
            // 
            // tbparkingSpace
            // 
            this.tbparkingSpace.AutoSize = true;
            this.tbparkingSpace.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.tbparkingSpace.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.tbparkingSpace.BorderRadius = 20;
            this.tbparkingSpace.BorderSize = 2;
            this.tbparkingSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbparkingSpace.ForeColor = System.Drawing.Color.Gold;
            this.tbparkingSpace.Location = new System.Drawing.Point(324, 38);
            this.tbparkingSpace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbparkingSpace.MinimumSize = new System.Drawing.Size(90, 45);
            this.tbparkingSpace.Name = "tbparkingSpace";
            this.tbparkingSpace.Size = new System.Drawing.Size(90, 45);
            this.tbparkingSpace.TabIndex = 57;
            this.tbparkingSpace.Text = "300";
            // 
            // tbAvailableSpace
            // 
            this.tbAvailableSpace.AutoSize = true;
            this.tbAvailableSpace.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.tbAvailableSpace.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.tbAvailableSpace.BorderRadius = 20;
            this.tbAvailableSpace.BorderSize = 2;
            this.tbAvailableSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAvailableSpace.ForeColor = System.Drawing.Color.Gold;
            this.tbAvailableSpace.Location = new System.Drawing.Point(324, 96);
            this.tbAvailableSpace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbAvailableSpace.MinimumSize = new System.Drawing.Size(90, 45);
            this.tbAvailableSpace.Name = "tbAvailableSpace";
            this.tbAvailableSpace.Size = new System.Drawing.Size(90, 45);
            this.tbAvailableSpace.TabIndex = 59;
            this.tbAvailableSpace.Text = "25";
            // 
            // roundedLabel3
            // 
            this.roundedLabel3.AutoSize = true;
            this.roundedLabel3.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.roundedLabel3.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedLabel3.BorderRadius = 20;
            this.roundedLabel3.BorderSize = 2;
            this.roundedLabel3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel3.ForeColor = System.Drawing.Color.White;
            this.roundedLabel3.Location = new System.Drawing.Point(46, 94);
            this.roundedLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundedLabel3.MinimumSize = new System.Drawing.Size(270, 45);
            this.roundedLabel3.Name = "roundedLabel3";
            this.roundedLabel3.Size = new System.Drawing.Size(270, 45);
            this.roundedLabel3.TabIndex = 58;
            this.roundedLabel3.Text = "Available Space";
            // 
            // tbReservedSpaced
            // 
            this.tbReservedSpaced.AutoSize = true;
            this.tbReservedSpaced.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.tbReservedSpaced.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.tbReservedSpaced.BorderRadius = 20;
            this.tbReservedSpaced.BorderSize = 2;
            this.tbReservedSpaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReservedSpaced.ForeColor = System.Drawing.Color.Gold;
            this.tbReservedSpaced.Location = new System.Drawing.Point(796, 98);
            this.tbReservedSpaced.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbReservedSpaced.MinimumSize = new System.Drawing.Size(90, 45);
            this.tbReservedSpaced.Name = "tbReservedSpaced";
            this.tbReservedSpaced.Size = new System.Drawing.Size(90, 45);
            this.tbReservedSpaced.TabIndex = 63;
            this.tbReservedSpaced.Text = "10";
            // 
            // roundedLabel4
            // 
            this.roundedLabel4.AutoSize = true;
            this.roundedLabel4.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.roundedLabel4.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedLabel4.BorderRadius = 20;
            this.roundedLabel4.BorderSize = 2;
            this.roundedLabel4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel4.ForeColor = System.Drawing.Color.White;
            this.roundedLabel4.Location = new System.Drawing.Point(519, 96);
            this.roundedLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundedLabel4.MinimumSize = new System.Drawing.Size(270, 45);
            this.roundedLabel4.Name = "roundedLabel4";
            this.roundedLabel4.Size = new System.Drawing.Size(270, 45);
            this.roundedLabel4.TabIndex = 62;
            this.roundedLabel4.Text = "Reserved Space";
            // 
            // tbSpaceOccupied
            // 
            this.tbSpaceOccupied.AutoSize = true;
            this.tbSpaceOccupied.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.tbSpaceOccupied.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.tbSpaceOccupied.BorderRadius = 20;
            this.tbSpaceOccupied.BorderSize = 2;
            this.tbSpaceOccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpaceOccupied.ForeColor = System.Drawing.Color.Gold;
            this.tbSpaceOccupied.Location = new System.Drawing.Point(796, 39);
            this.tbSpaceOccupied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbSpaceOccupied.MinimumSize = new System.Drawing.Size(90, 45);
            this.tbSpaceOccupied.Name = "tbSpaceOccupied";
            this.tbSpaceOccupied.Size = new System.Drawing.Size(90, 45);
            this.tbSpaceOccupied.TabIndex = 61;
            this.tbSpaceOccupied.Text = "100";
            // 
            // roundedLabel6
            // 
            this.roundedLabel6.AutoSize = true;
            this.roundedLabel6.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.roundedLabel6.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedLabel6.BorderRadius = 20;
            this.roundedLabel6.BorderSize = 2;
            this.roundedLabel6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel6.ForeColor = System.Drawing.Color.White;
            this.roundedLabel6.Location = new System.Drawing.Point(519, 38);
            this.roundedLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundedLabel6.MinimumSize = new System.Drawing.Size(270, 45);
            this.roundedLabel6.Name = "roundedLabel6";
            this.roundedLabel6.Size = new System.Drawing.Size(270, 45);
            this.roundedLabel6.TabIndex = 60;
            this.roundedLabel6.Text = "Space Occupied";
            // 
            // tbCurrentTime
            // 
            this.tbCurrentTime.AutoSize = true;
            this.tbCurrentTime.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.tbCurrentTime.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.tbCurrentTime.BorderRadius = 20;
            this.tbCurrentTime.BorderSize = 2;
            this.tbCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentTime.ForeColor = System.Drawing.Color.Gold;
            this.tbCurrentTime.Location = new System.Drawing.Point(1287, 99);
            this.tbCurrentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbCurrentTime.MinimumSize = new System.Drawing.Size(120, 45);
            this.tbCurrentTime.Name = "tbCurrentTime";
            this.tbCurrentTime.Size = new System.Drawing.Size(120, 45);
            this.tbCurrentTime.TabIndex = 67;
            this.tbCurrentTime.Text = "00:00:00";
            // 
            // roundedLabel5
            // 
            this.roundedLabel5.AutoSize = true;
            this.roundedLabel5.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.roundedLabel5.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedLabel5.BorderRadius = 20;
            this.roundedLabel5.BorderSize = 2;
            this.roundedLabel5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel5.ForeColor = System.Drawing.Color.White;
            this.roundedLabel5.Location = new System.Drawing.Point(1008, 98);
            this.roundedLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundedLabel5.MinimumSize = new System.Drawing.Size(270, 45);
            this.roundedLabel5.Name = "roundedLabel5";
            this.roundedLabel5.Size = new System.Drawing.Size(270, 45);
            this.roundedLabel5.TabIndex = 66;
            this.roundedLabel5.Text = "Current Time";
            // 
            // tbOverStayed
            // 
            this.tbOverStayed.AutoSize = true;
            this.tbOverStayed.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.tbOverStayed.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.tbOverStayed.BorderRadius = 20;
            this.tbOverStayed.BorderSize = 2;
            this.tbOverStayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOverStayed.ForeColor = System.Drawing.Color.Gold;
            this.tbOverStayed.Location = new System.Drawing.Point(1287, 40);
            this.tbOverStayed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbOverStayed.MinimumSize = new System.Drawing.Size(120, 45);
            this.tbOverStayed.Name = "tbOverStayed";
            this.tbOverStayed.Size = new System.Drawing.Size(120, 45);
            this.tbOverStayed.TabIndex = 65;
            this.tbOverStayed.Text = "5";
            // 
            // roundedLabel8
            // 
            this.roundedLabel8.AutoSize = true;
            this.roundedLabel8.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.roundedLabel8.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundedLabel8.BorderRadius = 20;
            this.roundedLabel8.BorderSize = 2;
            this.roundedLabel8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel8.ForeColor = System.Drawing.Color.White;
            this.roundedLabel8.Location = new System.Drawing.Point(1008, 39);
            this.roundedLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundedLabel8.MinimumSize = new System.Drawing.Size(270, 45);
            this.roundedLabel8.Name = "roundedLabel8";
            this.roundedLabel8.Size = new System.Drawing.Size(270, 45);
            this.roundedLabel8.TabIndex = 64;
            this.roundedLabel8.Text = "Over Stayed";
            // 
            // lbParkingAI
            // 
            this.lbParkingAI.AutoSize = true;
            this.lbParkingAI.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.lbParkingAI.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.lbParkingAI.BorderRadius = 20;
            this.lbParkingAI.BorderSize = 2;
            this.lbParkingAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParkingAI.ForeColor = System.Drawing.Color.White;
            this.lbParkingAI.Location = new System.Drawing.Point(820, 178);
            this.lbParkingAI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbParkingAI.MinimumSize = new System.Drawing.Size(562, 60);
            this.lbParkingAI.Name = "lbParkingAI";
            this.lbParkingAI.Size = new System.Drawing.Size(562, 60);
            this.lbParkingAI.TabIndex = 68;
            this.lbParkingAI.Text = "PARKING AI WAITING";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Gold;
            this.btAdd.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.btAdd.BorderColor = System.Drawing.Color.White;
            this.btAdd.BorderRadius = 20;
            this.btAdd.BorderSize = 2;
            this.btAdd.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdd.Location = new System.Drawing.Point(72, 792);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(234, 62);
            this.btAdd.TabIndex = 69;
            this.btAdd.Text = "Save";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Visible = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Gold;
            this.btEdit.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.btEdit.BorderColor = System.Drawing.Color.White;
            this.btEdit.BorderRadius = 20;
            this.btEdit.BorderSize = 2;
            this.btEdit.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEdit.Location = new System.Drawing.Point(399, 795);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(234, 62);
            this.btEdit.TabIndex = 70;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Visible = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click_1);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Gold;
            this.btDelete.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.btDelete.BorderColor = System.Drawing.Color.White;
            this.btDelete.BorderRadius = 20;
            this.btDelete.BorderSize = 2;
            this.btDelete.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelete.Location = new System.Drawing.Point(730, 795);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(234, 62);
            this.btDelete.TabIndex = 71;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Gold;
            this.btCancel.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.btCancel.BorderColor = System.Drawing.Color.White;
            this.btCancel.BorderRadius = 20;
            this.btCancel.BorderSize = 2;
            this.btCancel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancel.Location = new System.Drawing.Point(1042, 795);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(234, 62);
            this.btCancel.TabIndex = 72;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Visible = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click_1);
            // 
            // btEntryGate
            // 
            this.btEntryGate.BackColor = System.Drawing.Color.Gold;
            this.btEntryGate.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btEntryGate.BorderColor = System.Drawing.Color.White;
            this.btEntryGate.BorderRadius = 20;
            this.btEntryGate.BorderSize = 2;
            this.btEntryGate.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntryGate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEntryGate.Location = new System.Drawing.Point(51, 777);
            this.btEntryGate.Margin = new System.Windows.Forms.Padding(4);
            this.btEntryGate.MinimumSize = new System.Drawing.Size(255, 90);
            this.btEntryGate.Name = "btEntryGate";
            this.btEntryGate.Size = new System.Drawing.Size(255, 90);
            this.btEntryGate.TabIndex = 73;
            this.btEntryGate.Text = "Open Entry Gate";
            this.btEntryGate.UseVisualStyleBackColor = false;
            this.btEntryGate.Click += new System.EventHandler(this.btEntryGate_Click_1);
            // 
            // btExitGate
            // 
            this.btExitGate.BackColor = System.Drawing.Color.Gold;
            this.btExitGate.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btExitGate.BorderColor = System.Drawing.Color.White;
            this.btExitGate.BorderRadius = 20;
            this.btExitGate.BorderSize = 2;
            this.btExitGate.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExitGate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExitGate.Location = new System.Drawing.Point(326, 780);
            this.btExitGate.Margin = new System.Windows.Forms.Padding(4);
            this.btExitGate.MinimumSize = new System.Drawing.Size(255, 90);
            this.btExitGate.Name = "btExitGate";
            this.btExitGate.Size = new System.Drawing.Size(255, 90);
            this.btExitGate.TabIndex = 74;
            this.btExitGate.Text = "Open Exit Gate";
            this.btExitGate.UseVisualStyleBackColor = false;
            this.btExitGate.Click += new System.EventHandler(this.btExitGate_Click);
            // 
            // btReservation
            // 
            this.btReservation.BackColor = System.Drawing.Color.Gold;
            this.btReservation.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.btReservation.BorderColor = System.Drawing.Color.White;
            this.btReservation.BorderRadius = 20;
            this.btReservation.BorderSize = 2;
            this.btReservation.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btReservation.Location = new System.Drawing.Point(608, 780);
            this.btReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btReservation.MinimumSize = new System.Drawing.Size(255, 90);
            this.btReservation.Name = "btReservation";
            this.btReservation.Size = new System.Drawing.Size(255, 90);
            this.btReservation.TabIndex = 75;
            this.btReservation.Text = "Reservations";
            this.btReservation.UseVisualStyleBackColor = false;
            this.btReservation.Click += new System.EventHandler(this.btReservation_Click_1);
            // 
            // ManageLotScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1641, 1016);
            this.ControlBox = false;
            this.Controls.Add(this.btReservation);
            this.Controls.Add(this.btExitGate);
            this.Controls.Add(this.btEntryGate);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbParkingAI);
            this.Controls.Add(this.tbCurrentTime);
            this.Controls.Add(this.roundedLabel5);
            this.Controls.Add(this.tbOverStayed);
            this.Controls.Add(this.roundedLabel8);
            this.Controls.Add(this.tbReservedSpaced);
            this.Controls.Add(this.roundedLabel4);
            this.Controls.Add(this.tbSpaceOccupied);
            this.Controls.Add(this.roundedLabel6);
            this.Controls.Add(this.tbAvailableSpace);
            this.Controls.Add(this.roundedLabel3);
            this.Controls.Add(this.tbparkingSpace);
            this.Controls.Add(this.roundedLabel1);
            this.Controls.Add(this.gvReservations);
            this.Controls.Add(this.tlReservation);
            this.Controls.Add(this.lbOverstayed);
            this.Controls.Add(this.lbPaid);
            this.Controls.Add(this.tlDetails);
            this.Controls.Add(this.imgCarImage);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageLotScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageLotsScreen";
            this.Load += new System.EventHandler(this.ManageLotScreen_Load);
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
        private System.Windows.Forms.Label lbPaid;
        private System.Windows.Forms.TableLayoutPanel tlDetails;
        private System.Windows.Forms.PictureBox imgCarImage;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label lbOverstayed;
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
        private RoundedLabel roundedLabel1;
        private RoundedLabel tbparkingSpace;
        private RoundedLabel tbAvailableSpace;
        private RoundedLabel roundedLabel3;
        private RoundedLabel tbReservedSpaced;
        private RoundedLabel roundedLabel4;
        private RoundedLabel tbSpaceOccupied;
        private RoundedLabel roundedLabel6;
        private RoundedLabel tbCurrentTime;
        private RoundedLabel roundedLabel5;
        private RoundedLabel tbOverStayed;
        private RoundedLabel roundedLabel8;
        private RoundedLabel lbParkingAI;
        private RoundedButton btAdd;
        private RoundedButton btEdit;
        private RoundedButton btDelete;
        private RoundedButton btCancel;
        private RoundedButton btEntryGate;
        private RoundedButton btExitGate;
        private RoundedButton btReservation;
    }
}