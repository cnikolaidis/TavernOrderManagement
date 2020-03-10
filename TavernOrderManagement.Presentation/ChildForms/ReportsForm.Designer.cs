namespace TavernOrderManagement.Presentation.ChildForms
{
    partial class ReportsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.printReportBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateReportOption = new System.Windows.Forms.RadioButton();
            this.showReportCheck = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.statisticsReportOption = new System.Windows.Forms.CheckBox();
            this.dayReportOption = new System.Windows.Forms.RadioButton();
            this.salesReportOption = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.printReportBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cancelBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 350);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Εκτύπωση Αναφοράς";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printReportBtn
            // 
            this.printReportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printReportBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.printReportBtn.Location = new System.Drawing.Point(3, 283);
            this.printReportBtn.Name = "printReportBtn";
            this.printReportBtn.Size = new System.Drawing.Size(356, 29);
            this.printReportBtn.TabIndex = 3;
            this.printReportBtn.Text = "Εκτύπωση";
            this.printReportBtn.UseVisualStyleBackColor = true;
            this.printReportBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.fromDatePicker, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.toDatePicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateReportOption, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.showReportCheck, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 169);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDatePicker.Enabled = false;
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDatePicker.Location = new System.Drawing.Point(3, 56);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(172, 20);
            this.fromDatePicker.TabIndex = 0;
            // 
            // toDatePicker
            // 
            this.toDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toDatePicker.Enabled = false;
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDatePicker.Location = new System.Drawing.Point(181, 56);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(172, 20);
            this.toDatePicker.TabIndex = 1;
            // 
            // dateReportOption
            // 
            this.dateReportOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateReportOption.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.dateReportOption, 2);
            this.dateReportOption.Location = new System.Drawing.Point(133, 3);
            this.dateReportOption.Name = "dateReportOption";
            this.dateReportOption.Size = new System.Drawing.Size(90, 27);
            this.dateReportOption.TabIndex = 2;
            this.dateReportOption.TabStop = true;
            this.dateReportOption.Text = "Ημερομηνίας";
            this.dateReportOption.UseVisualStyleBackColor = true;
            // 
            // showReportCheck
            // 
            this.showReportCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.showReportCheck.AutoSize = true;
            this.showReportCheck.Checked = true;
            this.showReportCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel2.SetColumnSpan(this.showReportCheck, 2);
            this.showReportCheck.Location = new System.Drawing.Point(116, 103);
            this.showReportCheck.Name = "showReportCheck";
            this.showReportCheck.Size = new System.Drawing.Size(124, 63);
            this.showReportCheck.TabIndex = 3;
            this.showReportCheck.Text = "Προβολή Αναφοράς";
            this.showReportCheck.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cancelBtn.Location = new System.Drawing.Point(3, 318);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(356, 29);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Ακύρωση";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.statisticsReportOption, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dayReportOption, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.salesReportOption, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(356, 64);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // statisticsReportOption
            // 
            this.statisticsReportOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.statisticsReportOption.AutoSize = true;
            this.statisticsReportOption.Location = new System.Drawing.Point(222, 3);
            this.statisticsReportOption.Name = "statisticsReportOption";
            this.statisticsReportOption.Size = new System.Drawing.Size(90, 26);
            this.statisticsReportOption.TabIndex = 4;
            this.statisticsReportOption.Text = "Στατιστικών";
            this.statisticsReportOption.UseVisualStyleBackColor = true;
            // 
            // dayReportOption
            // 
            this.dayReportOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dayReportOption.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.dayReportOption, 2);
            this.dayReportOption.Location = new System.Drawing.Point(146, 35);
            this.dayReportOption.Name = "dayReportOption";
            this.dayReportOption.Size = new System.Drawing.Size(63, 26);
            this.dayReportOption.TabIndex = 2;
            this.dayReportOption.TabStop = true;
            this.dayReportOption.Text = "Ημέρας";
            this.dayReportOption.UseVisualStyleBackColor = true;
            // 
            // salesReportOption
            // 
            this.salesReportOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.salesReportOption.AutoSize = true;
            this.salesReportOption.Location = new System.Drawing.Point(49, 3);
            this.salesReportOption.Name = "salesReportOption";
            this.salesReportOption.Size = new System.Drawing.Size(79, 26);
            this.salesReportOption.TabIndex = 3;
            this.salesReportOption.Text = "Πωλήσεων";
            this.salesReportOption.UseVisualStyleBackColor = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 350);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printReportBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.RadioButton dateReportOption;
        private System.Windows.Forms.CheckBox showReportCheck;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox statisticsReportOption;
        private System.Windows.Forms.RadioButton dayReportOption;
        private System.Windows.Forms.CheckBox salesReportOption;
    }
}