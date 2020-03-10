namespace TavernOrderManagement.Presentation.ChildForms
{
    partial class SetQuantityForm
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
            this.completeQuantityInput = new System.Windows.Forms.Button();
            this.cancelQuantityInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.num0 = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.completeQuantityInput, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cancelQuantityInput, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.quantityInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // completeQuantityInput
            // 
            this.completeQuantityInput.BackColor = System.Drawing.Color.Black;
            this.completeQuantityInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completeQuantityInput.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.completeQuantityInput.ForeColor = System.Drawing.Color.Lime;
            this.completeQuantityInput.Location = new System.Drawing.Point(3, 224);
            this.completeQuantityInput.Name = "completeQuantityInput";
            this.completeQuantityInput.Size = new System.Drawing.Size(136, 34);
            this.completeQuantityInput.TabIndex = 14;
            this.completeQuantityInput.Text = "Ok";
            this.completeQuantityInput.UseVisualStyleBackColor = false;
            this.completeQuantityInput.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // cancelQuantityInput
            // 
            this.cancelQuantityInput.BackColor = System.Drawing.Color.Black;
            this.cancelQuantityInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelQuantityInput.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cancelQuantityInput.ForeColor = System.Drawing.Color.Red;
            this.cancelQuantityInput.Location = new System.Drawing.Point(145, 224);
            this.cancelQuantityInput.Name = "cancelQuantityInput";
            this.cancelQuantityInput.Size = new System.Drawing.Size(136, 34);
            this.cancelQuantityInput.TabIndex = 13;
            this.cancelQuantityInput.Text = "X";
            this.cancelQuantityInput.UseVisualStyleBackColor = false;
            this.cancelQuantityInput.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Επιλέξτε Ποσότητα";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityInput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.quantityInput, 2);
            this.quantityInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityInput.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.quantityInput.Location = new System.Drawing.Point(3, 29);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(278, 31);
            this.quantityInput.TabIndex = 1;
            this.quantityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.num0, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.clearBtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button10, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 158);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // num0
            // 
            this.num0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num0.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.num0.Location = new System.Drawing.Point(95, 120);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(86, 35);
            this.num0.TabIndex = 15;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // clearBtn
            // 
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearBtn.Location = new System.Drawing.Point(3, 120);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(86, 35);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button9.Location = new System.Drawing.Point(187, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 33);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button8.Location = new System.Drawing.Point(95, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 33);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button7.Location = new System.Drawing.Point(3, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 33);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button6.Location = new System.Drawing.Point(187, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 33);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button5.Location = new System.Drawing.Point(95, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button4.Location = new System.Drawing.Point(3, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.Location = new System.Drawing.Point(187, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.Location = new System.Drawing.Point(95, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button10.Location = new System.Drawing.Point(187, 120);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 35);
            this.button10.TabIndex = 16;
            this.button10.Text = ".";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NumberButtonClicked);
            // 
            // SetQuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetQuantityForm";
            this.Text = "SetQuantityForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button completeQuantityInput;
        private System.Windows.Forms.Button cancelQuantityInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
    }
}