namespace SmartPark_Pro
{
    partial class FinacialReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gvPaymentsGridview = new System.Windows.Forms.DataGridView();
            this.ctPaymentchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btDateSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaymentsGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPaymentchart)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPaymentsGridview
            // 
            this.gvPaymentsGridview.AllowUserToAddRows = false;
            this.gvPaymentsGridview.AllowUserToDeleteRows = false;
            this.gvPaymentsGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPaymentsGridview.Location = new System.Drawing.Point(12, 41);
            this.gvPaymentsGridview.Name = "gvPaymentsGridview";
            this.gvPaymentsGridview.ReadOnly = true;
            this.gvPaymentsGridview.Size = new System.Drawing.Size(442, 347);
            this.gvPaymentsGridview.TabIndex = 0;
            // 
            // ctPaymentchart
            // 
            chartArea2.Name = "ChartArea1";
            this.ctPaymentchart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ctPaymentchart.Legends.Add(legend2);
            this.ctPaymentchart.Location = new System.Drawing.Point(472, 41);
            this.ctPaymentchart.Name = "ctPaymentchart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Payments";
            series2.YValuesPerPoint = 3;
            this.ctPaymentchart.Series.Add(series2);
            this.ctPaymentchart.Size = new System.Drawing.Size(300, 300);
            this.ctPaymentchart.TabIndex = 1;
            this.ctPaymentchart.Text = "chart1";
            // 
            // dpStartDate
            // 
            this.dpStartDate.Location = new System.Drawing.Point(12, 10);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dpStartDate.TabIndex = 2;
            // 
            // dpEndDate
            // 
            this.dpEndDate.Location = new System.Drawing.Point(236, 10);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dpEndDate.TabIndex = 3;
            // 
            // btDateSearch
            // 
            this.btDateSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btDateSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDateSearch.Location = new System.Drawing.Point(442, 7);
            this.btDateSearch.Name = "btDateSearch";
            this.btDateSearch.Size = new System.Drawing.Size(75, 26);
            this.btDateSearch.TabIndex = 4;
            this.btDateSearch.Text = "Load";
            this.btDateSearch.UseVisualStyleBackColor = false;
            this.btDateSearch.Click += new System.EventHandler(this.btDateSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(472, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total: $";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotal.Location = new System.Drawing.Point(588, 348);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(75, 34);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "0.00";
            // 
            // FinacialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(892, 459);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDateSearch);
            this.Controls.Add(this.dpEndDate);
            this.Controls.Add(this.dpStartDate);
            this.Controls.Add(this.ctPaymentchart);
            this.Controls.Add(this.gvPaymentsGridview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinacialReport";
            this.ShowIcon = false;
            this.Text = "Finacial Report";
            this.Load += new System.EventHandler(this.FinacialReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPaymentsGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPaymentchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPaymentsGridview;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctPaymentchart;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.Button btDateSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
    }
}