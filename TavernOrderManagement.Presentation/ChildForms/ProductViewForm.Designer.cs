namespace TavernOrderManagement.Presentation.ChildForms
{
    partial class ProductViewForm
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
            this.newEditItemViewTitle = new System.Windows.Forms.Label();
            this.saveItemBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isKgQuantityCheck = new System.Windows.Forms.CheckBox();
            this.itemNameInput = new System.Windows.Forms.TextBox();
            this.itemCategoryInput = new System.Windows.Forms.ComboBox();
            this.itemPriceInput = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.newEditItemViewTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveItemBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearBtn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 376);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // newEditItemViewTitle
            // 
            this.newEditItemViewTitle.AutoSize = true;
            this.newEditItemViewTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newEditItemViewTitle.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newEditItemViewTitle.Location = new System.Drawing.Point(3, 0);
            this.newEditItemViewTitle.Name = "newEditItemViewTitle";
            this.newEditItemViewTitle.Size = new System.Drawing.Size(389, 37);
            this.newEditItemViewTitle.TabIndex = 0;
            this.newEditItemViewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveItemBtn
            // 
            this.saveItemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveItemBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.saveItemBtn.Location = new System.Drawing.Point(3, 303);
            this.saveItemBtn.Name = "saveItemBtn";
            this.saveItemBtn.Size = new System.Drawing.Size(389, 31);
            this.saveItemBtn.TabIndex = 1;
            this.saveItemBtn.Text = "Αποθήκευση";
            this.saveItemBtn.UseVisualStyleBackColor = true;
            this.saveItemBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.isKgQuantityCheck, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.itemNameInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.itemCategoryInput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.itemPriceInput, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 257);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Όνομα";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "Κατηγορία";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(3, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 64);
            this.label3.TabIndex = 2;
            this.label3.Text = "Τιμή";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isKgQuantityCheck
            // 
            this.isKgQuantityCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.isKgQuantityCheck.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.isKgQuantityCheck, 2);
            this.isKgQuantityCheck.Location = new System.Drawing.Point(123, 195);
            this.isKgQuantityCheck.Name = "isKgQuantityCheck";
            this.isKgQuantityCheck.Size = new System.Drawing.Size(143, 59);
            this.isKgQuantityCheck.TabIndex = 3;
            this.isKgQuantityCheck.Text = "Ρυθμιζόμενη Ποσότητα";
            this.isKgQuantityCheck.UseVisualStyleBackColor = true;
            // 
            // itemNameInput
            // 
            this.itemNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameInput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.itemNameInput.Location = new System.Drawing.Point(119, 18);
            this.itemNameInput.Name = "itemNameInput";
            this.itemNameInput.Size = new System.Drawing.Size(267, 27);
            this.itemNameInput.TabIndex = 4;
            // 
            // itemCategoryInput
            // 
            this.itemCategoryInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.itemCategoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCategoryInput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.itemCategoryInput.FormattingEnabled = true;
            this.itemCategoryInput.Location = new System.Drawing.Point(119, 82);
            this.itemCategoryInput.Name = "itemCategoryInput";
            this.itemCategoryInput.Size = new System.Drawing.Size(267, 28);
            this.itemCategoryInput.TabIndex = 5;
            // 
            // itemPriceInput
            // 
            this.itemPriceInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.itemPriceInput.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.itemPriceInput.Location = new System.Drawing.Point(119, 146);
            this.itemPriceInput.Name = "itemPriceInput";
            this.itemPriceInput.Size = new System.Drawing.Size(267, 27);
            this.itemPriceInput.TabIndex = 6;
            // 
            // clearBtn
            // 
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearBtn.Location = new System.Drawing.Point(3, 340);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(389, 33);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Καθαρισμός Πεδίων";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // ProductViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductViewForm";
            this.Load += new System.EventHandler(this.FormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label newEditItemViewTitle;
        private System.Windows.Forms.Button saveItemBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isKgQuantityCheck;
        private System.Windows.Forms.TextBox itemNameInput;
        private System.Windows.Forms.ComboBox itemCategoryInput;
        private System.Windows.Forms.TextBox itemPriceInput;
        private System.Windows.Forms.Button clearBtn;
    }
}