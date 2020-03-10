namespace TavernOrderManagement.Presentation.ChildForms
{
    partial class ProductsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.itemDataGrid = new System.Windows.Forms.DataGridView();
            this.countCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedQ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.editProd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteProd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.newItemBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateToEnabled = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.customQuantity = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateFromEnabled = new System.Windows.Forms.CheckBox();
            this.clearFiltersBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.itemDataGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newItemBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearFiltersBtn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.50001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 492);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1039, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Είδη";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // itemDataGrid
            // 
            this.itemDataGrid.AllowUserToAddRows = false;
            this.itemDataGrid.AllowUserToDeleteRows = false;
            this.itemDataGrid.AllowUserToResizeRows = false;
            this.itemDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countCol,
            this.prodId,
            this.prodDate,
            this.prodTime,
            this.prodCategory,
            this.prodName,
            this.prodPrice,
            this.fixedQ,
            this.editProd,
            this.deleteProd});
            this.tableLayoutPanel1.SetColumnSpan(this.itemDataGrid, 3);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemDataGrid.Location = new System.Drawing.Point(3, 88);
            this.itemDataGrid.Name = "itemDataGrid";
            this.itemDataGrid.ReadOnly = true;
            this.itemDataGrid.RowHeadersVisible = false;
            this.itemDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataGrid.Size = new System.Drawing.Size(1039, 350);
            this.itemDataGrid.TabIndex = 1;
            this.itemDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClicked);
            // 
            // countCol
            // 
            this.countCol.FillWeight = 50.76143F;
            this.countCol.HeaderText = "";
            this.countCol.Name = "countCol";
            this.countCol.ReadOnly = true;
            // 
            // prodId
            // 
            this.prodId.FillWeight = 45.15726F;
            this.prodId.HeaderText = "Id";
            this.prodId.Name = "prodId";
            this.prodId.ReadOnly = true;
            // 
            // prodDate
            // 
            this.prodDate.FillWeight = 86.45915F;
            this.prodDate.HeaderText = "Ημερομηνία";
            this.prodDate.Name = "prodDate";
            this.prodDate.ReadOnly = true;
            // 
            // prodTime
            // 
            this.prodTime.FillWeight = 86.67572F;
            this.prodTime.HeaderText = "Ώρα";
            this.prodTime.Name = "prodTime";
            this.prodTime.ReadOnly = true;
            // 
            // prodCategory
            // 
            this.prodCategory.FillWeight = 134.0242F;
            this.prodCategory.HeaderText = "Κατηγορία";
            this.prodCategory.Name = "prodCategory";
            this.prodCategory.ReadOnly = true;
            // 
            // prodName
            // 
            this.prodName.FillWeight = 105.5551F;
            this.prodName.HeaderText = "Όνομα";
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            // 
            // prodPrice
            // 
            this.prodPrice.FillWeight = 87.51825F;
            this.prodPrice.HeaderText = "Τιμή";
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.ReadOnly = true;
            // 
            // fixedQ
            // 
            this.fixedQ.FillWeight = 192.7388F;
            this.fixedQ.HeaderText = "Ρυθμιζόμενη Ποσότητα";
            this.fixedQ.Name = "fixedQ";
            this.fixedQ.ReadOnly = true;
            this.fixedQ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fixedQ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // editProd
            // 
            this.editProd.FillWeight = 105.5551F;
            this.editProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProd.HeaderText = "Επεξεργασία";
            this.editProd.Name = "editProd";
            this.editProd.ReadOnly = true;
            this.editProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editProd.Text = "Επεξεργασία";
            this.editProd.UseColumnTextForButtonValue = true;
            // 
            // deleteProd
            // 
            this.deleteProd.FillWeight = 105.5551F;
            this.deleteProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProd.HeaderText = "Διαγραφή";
            this.deleteProd.Name = "deleteProd";
            this.deleteProd.ReadOnly = true;
            this.deleteProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteProd.Text = "Διαγραφή";
            this.deleteProd.UseColumnTextForButtonValue = true;
            // 
            // newItemBtn
            // 
            this.newItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.newItemBtn.BackColor = System.Drawing.Color.Transparent;
            this.newItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newItemBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            //this.newItemBtn.Image = ((System.Drawing.Image)(resources.GetObject("newItemBtn.Image")));
            this.newItemBtn.Location = new System.Drawing.Point(967, 444);
            this.newItemBtn.Name = "newItemBtn";
            this.newItemBtn.Size = new System.Drawing.Size(50, 45);
            this.newItemBtn.TabIndex = 3;
            this.newItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newItemBtn.UseVisualStyleBackColor = false;
            this.newItemBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.categoryBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.customQuantity, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1039, 49);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.41936F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.58064F));
            this.tableLayoutPanel4.Controls.Add(this.dateTo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dateToEnabled, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(758, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(139, 26);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // dateTo
            // 
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTo.Enabled = false;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(41, 3);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(95, 20);
            this.dateTo.TabIndex = 9;
            this.dateTo.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateTo.ValueChanged += new System.EventHandler(this.DatesChanged);
            // 
            // dateToEnabled
            // 
            this.dateToEnabled.AutoSize = true;
            this.dateToEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateToEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateToEnabled.Location = new System.Drawing.Point(3, 3);
            this.dateToEnabled.Name = "dateToEnabled";
            this.dateToEnabled.Size = new System.Drawing.Size(32, 20);
            this.dateToEnabled.TabIndex = 1;
            this.dateToEnabled.UseVisualStyleBackColor = true;
            this.dateToEnabled.CheckedChanged += new System.EventHandler(this.DatesCheckChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(903, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ρυθμιζόμενη Ποσότητα";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(758, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Εώς";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(387, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Κατηγορία";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Εύρεση";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(612, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Από";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(3, 23);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(378, 20);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBoxTextChanged);
            // 
            // categoryBox
            // 
            this.categoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(387, 22);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(219, 21);
            this.categoryBox.TabIndex = 6;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBoxIndexChanged);
            // 
            // customQuantity
            // 
            this.customQuantity.AutoSize = true;
            this.customQuantity.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customQuantity.Location = new System.Drawing.Point(903, 20);
            this.customQuantity.Name = "customQuantity";
            this.customQuantity.Size = new System.Drawing.Size(133, 26);
            this.customQuantity.TabIndex = 9;
            this.customQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customQuantity.UseVisualStyleBackColor = true;
            this.customQuantity.CheckedChanged += new System.EventHandler(this.CustomQuantityCheckChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82269F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.17731F));
            this.tableLayoutPanel3.Controls.Add(this.dateFrom, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateFromEnabled, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(612, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(140, 26);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // dateFrom
            // 
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFrom.Enabled = false;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(37, 3);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(100, 20);
            this.dateFrom.TabIndex = 10;
            this.dateFrom.Value = new System.DateTime(2016, 1, 1, 20, 46, 0, 0);
            this.dateFrom.ValueChanged += new System.EventHandler(this.DatesChanged);
            // 
            // dateFromEnabled
            // 
            this.dateFromEnabled.AutoSize = true;
            this.dateFromEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateFromEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFromEnabled.Location = new System.Drawing.Point(3, 3);
            this.dateFromEnabled.Name = "dateFromEnabled";
            this.dateFromEnabled.Size = new System.Drawing.Size(28, 20);
            this.dateFromEnabled.TabIndex = 0;
            this.dateFromEnabled.UseVisualStyleBackColor = true;
            this.dateFromEnabled.CheckedChanged += new System.EventHandler(this.DatesCheckChanged);
            // 
            // clearFiltersBtn
            // 
            this.clearFiltersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearFiltersBtn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearFiltersBtn.Location = new System.Drawing.Point(3, 444);
            this.clearFiltersBtn.Name = "clearFiltersBtn";
            this.clearFiltersBtn.Size = new System.Drawing.Size(98, 45);
            this.clearFiltersBtn.TabIndex = 5;
            this.clearFiltersBtn.Text = "Καθαρισμός Φίλτρων";
            this.clearFiltersBtn.UseVisualStyleBackColor = true;
            this.clearFiltersBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductsForm";
            this.Text = "Είδη";
            this.Load += new System.EventHandler(this.FormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView itemDataGrid;
        private System.Windows.Forms.Button newItemBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn countCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fixedQ;
        private System.Windows.Forms.DataGridViewButtonColumn editProd;
        private System.Windows.Forms.DataGridViewButtonColumn deleteProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.CheckBox customQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.CheckBox dateToEnabled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.CheckBox dateFromEnabled;
        private System.Windows.Forms.Button clearFiltersBtn;
    }
}