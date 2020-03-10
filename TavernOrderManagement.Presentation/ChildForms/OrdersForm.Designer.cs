namespace TavernOrderManagement.Presentation.ChildForms
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ordersPerDayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.orderItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.itemNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersDataGrid = new System.Windows.Forms.DataGridView();
            this.orderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.sumLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.goFiltersBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateToEnabled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateFromEnabled = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPerDayChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1038, 547);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1032, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Παραγγελίες";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ordersPerDayChart, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.orderItemsDataGrid, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ordersDataGrid, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1032, 510);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ordersPerDayChart
            // 
            this.ordersPerDayChart.BackColor = System.Drawing.SystemColors.Control;
            this.ordersPerDayChart.BorderlineColor = System.Drawing.SystemColors.Control;
            this.ordersPerDayChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersPerDayChart.Location = new System.Drawing.Point(453, 273);
            this.ordersPerDayChart.Name = "ordersPerDayChart";
            this.ordersPerDayChart.Size = new System.Drawing.Size(576, 187);
            this.ordersPerDayChart.TabIndex = 7;
            this.ordersPerDayChart.Click += new System.EventHandler(this.ChartClicked);
            // 
            // orderItemsDataGrid
            // 
            this.orderItemsDataGrid.AllowUserToAddRows = false;
            this.orderItemsDataGrid.AllowUserToDeleteRows = false;
            this.orderItemsDataGrid.AllowUserToResizeRows = false;
            this.orderItemsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderItemsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.orderItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNum,
            this.itemId,
            this.itemName,
            this.itemPrice,
            this.itemQuantity,
            this.itemAmount});
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderItemsDataGrid.DefaultCellStyle = dataGridViewCellStyle34;
            this.orderItemsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemsDataGrid.Location = new System.Drawing.Point(453, 80);
            this.orderItemsDataGrid.Name = "orderItemsDataGrid";
            this.orderItemsDataGrid.ReadOnly = true;
            this.orderItemsDataGrid.RowHeadersVisible = false;
            this.orderItemsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.orderItemsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderItemsDataGrid.Size = new System.Drawing.Size(576, 187);
            this.orderItemsDataGrid.TabIndex = 5;
            // 
            // itemNum
            // 
            this.itemNum.FillWeight = 28.39471F;
            this.itemNum.HeaderText = "";
            this.itemNum.Name = "itemNum";
            this.itemNum.ReadOnly = true;
            // 
            // itemId
            // 
            this.itemId.FillWeight = 27.11274F;
            this.itemId.HeaderText = "Id";
            this.itemId.Name = "itemId";
            this.itemId.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.FillWeight = 155.4242F;
            this.itemName.HeaderText = "Όνομα";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemPrice
            // 
            this.itemPrice.FillWeight = 100.2643F;
            this.itemPrice.HeaderText = "Τιμή";
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            // 
            // itemQuantity
            // 
            this.itemQuantity.FillWeight = 100.5155F;
            this.itemQuantity.HeaderText = "Ποσότητα";
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.ReadOnly = true;
            // 
            // itemAmount
            // 
            this.itemAmount.FillWeight = 122.4094F;
            this.itemAmount.HeaderText = "Σύνολο";
            this.itemAmount.Name = "itemAmount";
            this.itemAmount.ReadOnly = true;
            // 
            // ordersDataGrid
            // 
            this.ordersDataGrid.AllowUserToAddRows = false;
            this.ordersDataGrid.AllowUserToDeleteRows = false;
            this.ordersDataGrid.AllowUserToResizeRows = false;
            this.ordersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.ordersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNum,
            this.orderId,
            this.orderTable,
            this.orderDate,
            this.orderTime,
            this.orderAmount});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDataGrid.DefaultCellStyle = dataGridViewCellStyle36;
            this.ordersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersDataGrid.Location = new System.Drawing.Point(3, 80);
            this.ordersDataGrid.Name = "ordersDataGrid";
            this.ordersDataGrid.ReadOnly = true;
            this.ordersDataGrid.RowHeadersVisible = false;
            this.ordersDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableLayoutPanel2.SetRowSpan(this.ordersDataGrid, 2);
            this.ordersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGrid.Size = new System.Drawing.Size(444, 380);
            this.ordersDataGrid.TabIndex = 2;
            this.ordersDataGrid.SelectionChanged += new System.EventHandler(this.OrdersGridSelectionChanged);
            // 
            // orderNum
            // 
            this.orderNum.FillWeight = 29.68227F;
            this.orderNum.HeaderText = "";
            this.orderNum.Name = "orderNum";
            this.orderNum.ReadOnly = true;
            // 
            // orderId
            // 
            this.orderId.FillWeight = 26.42133F;
            this.orderId.HeaderText = "Id";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // orderTable
            // 
            this.orderTable.FillWeight = 81.3382F;
            this.orderTable.HeaderText = "Τραπέζι";
            this.orderTable.Name = "orderTable";
            this.orderTable.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.FillWeight = 179.4185F;
            this.orderDate.HeaderText = "Ημερομηνία";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            // 
            // orderTime
            // 
            this.orderTime.FillWeight = 151.2699F;
            this.orderTime.HeaderText = "Ώρα";
            this.orderTime.Name = "orderTime";
            this.orderTime.ReadOnly = true;
            // 
            // orderAmount
            // 
            this.orderAmount.FillWeight = 65.99057F;
            this.orderAmount.HeaderText = "Ποσό";
            this.orderAmount.Name = "orderAmount";
            this.orderAmount.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(453, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(576, 77);
            this.label5.TabIndex = 4;
            this.label5.Text = "Προϊόντα παραγγελίας";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.sumLbl, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 466);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(444, 41);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sumLbl.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sumLbl.ForeColor = System.Drawing.Color.Green;
            this.sumLbl.Location = new System.Drawing.Point(225, 0);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(216, 41);
            this.sumLbl.TabIndex = 1;
            this.sumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Σύνολο";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(453, 466);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(576, 41);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 71);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Φίλτρα";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.Controls.Add(this.goFiltersBtn, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(438, 52);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // goFiltersBtn
            // 
            this.goFiltersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goFiltersBtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.goFiltersBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.goFiltersBtn.Location = new System.Drawing.Point(382, 3);
            this.goFiltersBtn.Name = "goFiltersBtn";
            this.tableLayoutPanel3.SetRowSpan(this.goFiltersBtn, 2);
            this.goFiltersBtn.Size = new System.Drawing.Size(53, 46);
            this.goFiltersBtn.TabIndex = 7;
            this.goFiltersBtn.Text = "Ok";
            this.goFiltersBtn.UseVisualStyleBackColor = true;
            this.goFiltersBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dateTo, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateToEnabled, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(228, 23);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(148, 26);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // dateTo
            // 
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTo.Enabled = false;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(38, 3);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(107, 20);
            this.dateTo.TabIndex = 7;
            this.dateTo.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // dateToEnabled
            // 
            this.dateToEnabled.AutoSize = true;
            this.dateToEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateToEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateToEnabled.Location = new System.Drawing.Point(3, 3);
            this.dateToEnabled.Name = "dateToEnabled";
            this.dateToEnabled.Size = new System.Drawing.Size(29, 20);
            this.dateToEnabled.TabIndex = 1;
            this.dateToEnabled.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(228, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Εώς";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(69, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Από";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Τραπέζι";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableBox
            // 
            this.tableBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableBox.FormattingEnabled = true;
            this.tableBox.Location = new System.Drawing.Point(3, 25);
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(60, 21);
            this.tableBox.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dateFrom, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.dateFromEnabled, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(69, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(153, 26);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // dateFrom
            // 
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFrom.Enabled = false;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(40, 3);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(110, 20);
            this.dateFrom.TabIndex = 8;
            this.dateFrom.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // dateFromEnabled
            // 
            this.dateFromEnabled.AutoSize = true;
            this.dateFromEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateFromEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFromEnabled.Location = new System.Drawing.Point(3, 3);
            this.dateFromEnabled.Name = "dateFromEnabled";
            this.dateFromEnabled.Size = new System.Drawing.Size(31, 20);
            this.dateFromEnabled.TabIndex = 0;
            this.dateFromEnabled.UseVisualStyleBackColor = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrdersForm";
            this.Text = "Παραγγελίες";
            this.Load += new System.EventHandler(this.FormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersPerDayChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView ordersDataGrid;
        private System.Windows.Forms.DataGridView orderItemsDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAmount;
        private System.Windows.Forms.DataVisualization.Charting.Chart ordersPerDayChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button goFiltersBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.CheckBox dateToEnabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tableBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.CheckBox dateFromEnabled;
    }
}