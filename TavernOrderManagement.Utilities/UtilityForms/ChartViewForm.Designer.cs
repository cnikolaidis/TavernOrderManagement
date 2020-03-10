namespace TavernOrderManagement.Utilities.UtilityForms
{
    partial class ChartViewForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chartCtrl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCtrl
            // 
            this.chartCtrl.BackColor = System.Drawing.SystemColors.Control;
            this.chartCtrl.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartCtrl.ChartAreas.Add(chartArea1);
            this.chartCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCtrl.Location = new System.Drawing.Point(0, 0);
            this.chartCtrl.Name = "chartCtrl";
            this.chartCtrl.Size = new System.Drawing.Size(1078, 514);
            this.chartCtrl.TabIndex = 0;
            // 
            // ChartViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 514);
            this.Controls.Add(this.chartCtrl);
            this.Name = "ChartViewForm";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.chartCtrl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCtrl;
    }
}