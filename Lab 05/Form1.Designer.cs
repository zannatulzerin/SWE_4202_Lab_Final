namespace Lab_05
{
    partial class Form1
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
            this.MedNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalpriceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Amount1TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MedName1TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MedName2TextBox = new System.Windows.Forms.TextBox();
            this.OnStock = new System.Windows.Forms.ListBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AccBalanceButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UserID1TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MedNameTextBox
            // 
            this.MedNameTextBox.Location = new System.Drawing.Point(123, 38);
            this.MedNameTextBox.Name = "MedNameTextBox";
            this.MedNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.MedNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicine Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(123, 79);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.AmountTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(123, 117);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.PriceTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Medicine List";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Teal;
            this.AddButton.Location = new System.Drawing.Point(76, 180);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 36);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellButton
            // 
            this.SellButton.BackColor = System.Drawing.Color.Teal;
            this.SellButton.Location = new System.Drawing.Point(76, 410);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(75, 38);
            this.SellButton.TabIndex = 15;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = false;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sell Medicine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Price:";
            // 
            // TotalpriceTextBox
            // 
            this.TotalpriceTextBox.Location = new System.Drawing.Point(123, 339);
            this.TotalpriceTextBox.Name = "TotalpriceTextBox";
            this.TotalpriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalpriceTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Amount:";
            // 
            // Amount1TextBox
            // 
            this.Amount1TextBox.Location = new System.Drawing.Point(123, 301);
            this.Amount1TextBox.Name = "Amount1TextBox";
            this.Amount1TextBox.Size = new System.Drawing.Size(100, 22);
            this.Amount1TextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Medicine Name:";
            // 
            // MedName1TextBox
            // 
            this.MedName1TextBox.Location = new System.Drawing.Point(123, 260);
            this.MedName1TextBox.Name = "MedName1TextBox";
            this.MedName1TextBox.Size = new System.Drawing.Size(100, 22);
            this.MedName1TextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Medicine Name:";
            // 
            // MedName2TextBox
            // 
            this.MedName2TextBox.Location = new System.Drawing.Point(653, 50);
            this.MedName2TextBox.Name = "MedName2TextBox";
            this.MedName2TextBox.Size = new System.Drawing.Size(100, 22);
            this.MedName2TextBox.TabIndex = 16;
            // 
            // OnStock
            // 
            this.OnStock.FormattingEnabled = true;
            this.OnStock.ItemHeight = 16;
            this.OnStock.Location = new System.Drawing.Point(545, 117);
            this.OnStock.Name = "OnStock";
            this.OnStock.Size = new System.Drawing.Size(208, 132);
            this.OnStock.TabIndex = 18;
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.Teal;
            this.CheckButton.Location = new System.Drawing.Point(605, 78);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 33);
            this.CheckButton.TabIndex = 19;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(541, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Current Stock";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(528, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "Current Account Balance";
            // 
            // AccBalanceButton
            // 
            this.AccBalanceButton.BackColor = System.Drawing.Color.Teal;
            this.AccBalanceButton.Location = new System.Drawing.Point(532, 342);
            this.AccBalanceButton.Name = "AccBalanceButton";
            this.AccBalanceButton.Size = new System.Drawing.Size(206, 39);
            this.AccBalanceButton.TabIndex = 23;
            this.AccBalanceButton.Text = "Check Current A/C Balance";
            this.AccBalanceButton.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "User ID:";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(123, 152);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserIDTextBox.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "User ID:";
            // 
            // UserID1TextBox
            // 
            this.UserID1TextBox.Location = new System.Drawing.Point(123, 382);
            this.UserID1TextBox.Name = "UserID1TextBox";
            this.UserID1TextBox.Size = new System.Drawing.Size(100, 22);
            this.UserID1TextBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.UserID1TextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AccBalanceButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.OnStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MedName2TextBox);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalpriceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Amount1TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MedName1TextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedNameTextBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "++";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MedNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalpriceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Amount1TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MedName1TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MedName2TextBox;
        private System.Windows.Forms.ListBox OnStock;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AccBalanceButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox UserID1TextBox;
    }
}

