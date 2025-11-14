namespace SmartPark_Pro
{
    partial class AllCarReport
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
            this.gvAllCarLot = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nowParkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOverStayedVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllCarLot)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvAllCarLot
            // 
            this.gvAllCarLot.AllowUserToAddRows = false;
            this.gvAllCarLot.AllowUserToDeleteRows = false;
            this.gvAllCarLot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAllCarLot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAllCarLot.Location = new System.Drawing.Point(0, 24);
            this.gvAllCarLot.Name = "gvAllCarLot";
            this.gvAllCarLot.ReadOnly = true;
            this.gvAllCarLot.Size = new System.Drawing.Size(800, 426);
            this.gvAllCarLot.TabIndex = 47;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowParkedToolStripMenuItem,
            this.viewOverStayedVehiclesToolStripMenuItem,
            this.exitHistoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nowParkedToolStripMenuItem
            // 
            this.nowParkedToolStripMenuItem.Name = "nowParkedToolStripMenuItem";
            this.nowParkedToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.nowParkedToolStripMenuItem.Text = "View Current Parked Vehicles";
            this.nowParkedToolStripMenuItem.Click += new System.EventHandler(this.nowParkedToolStripMenuItem_Click);
            // 
            // viewOverStayedVehiclesToolStripMenuItem
            // 
            this.viewOverStayedVehiclesToolStripMenuItem.Name = "viewOverStayedVehiclesToolStripMenuItem";
            this.viewOverStayedVehiclesToolStripMenuItem.Size = new System.Drawing.Size(185, 20);
            this.viewOverStayedVehiclesToolStripMenuItem.Text = "|    View Over Stayed Vehicles    |";
            this.viewOverStayedVehiclesToolStripMenuItem.Click += new System.EventHandler(this.viewOverStayedVehiclesToolStripMenuItem_Click);
            // 
            // exitHistoryToolStripMenuItem
            // 
            this.exitHistoryToolStripMenuItem.Name = "exitHistoryToolStripMenuItem";
            this.exitHistoryToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.exitHistoryToolStripMenuItem.Text = "View Exit History";
            this.exitHistoryToolStripMenuItem.Click += new System.EventHandler(this.exitHistoryToolStripMenuItem_Click);
            // 
            // AllCarReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvAllCarLot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AllCarReport";
            this.ShowIcon = false;
            this.Text = "Report - ( All Car In Lot )";
            this.Load += new System.EventHandler(this.ReservationScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAllCarLot)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvAllCarLot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowParkedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOverStayedVehiclesToolStripMenuItem;
    }
}