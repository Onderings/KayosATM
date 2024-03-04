namespace KayosAtm
{
    partial class Account
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AccountNumberTb = new System.Windows.Forms.TextBox();
            this.AccountNameTb = new System.Windows.Forms.TextBox();
            this.SurNameTb = new System.Windows.Forms.TextBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.PhoneNumberTb = new System.Windows.Forms.TextBox();
            this.JobTb = new System.Windows.Forms.TextBox();
            this.PinTb = new System.Windows.Forms.TextBox();
            this.EducationTb = new System.Windows.Forms.ComboBox();
            this.DateOfBirthTable = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 85);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1109, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1153, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "KAYOS BANKACILIK ÇÖZÜMLERİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(162, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "İSİM:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(136, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "TCKN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(696, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 40);
            this.label8.TabIndex = 10;
            this.label8.Text = "D.T.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(655, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 40);
            this.label9.TabIndex = 11;
            this.label9.Text = "ŞİFRE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(612, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 40);
            this.label10.TabIndex = 12;
            this.label10.Text = "MESLEK:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(593, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 40);
            this.label11.TabIndex = 13;
            this.label11.Text = "ÖĞRENİM:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(596, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 40);
            this.label12.TabIndex = 14;
            this.label12.Text = "TELEFON:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(113, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 40);
            this.label13.TabIndex = 15;
            this.label13.Text = "ADRES:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(82, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 40);
            this.label14.TabIndex = 16;
            this.label14.Text = "SOY İSİM:";
            // 
            // AccountNumberTb
            // 
            this.AccountNumberTb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.AccountNumberTb.Location = new System.Drawing.Point(290, 191);
            this.AccountNumberTb.MaxLength = 11;
            this.AccountNumberTb.Name = "AccountNumberTb";
            this.AccountNumberTb.Size = new System.Drawing.Size(250, 38);
            this.AccountNumberTb.TabIndex = 17;
            this.AccountNumberTb.TextChanged += new System.EventHandler(this.AccountNumberTb_TextChanged);
            this.AccountNumberTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountNumberTb_KeyPress);
            // 
            // AccountNameTb
            // 
            this.AccountNameTb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.AccountNameTb.Location = new System.Drawing.Point(290, 268);
            this.AccountNameTb.MaxLength = 50;
            this.AccountNameTb.Name = "AccountNameTb";
            this.AccountNameTb.Size = new System.Drawing.Size(250, 38);
            this.AccountNameTb.TabIndex = 18;
            // 
            // SurNameTb
            // 
            this.SurNameTb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.SurNameTb.Location = new System.Drawing.Point(290, 342);
            this.SurNameTb.MaxLength = 50;
            this.SurNameTb.Name = "SurNameTb";
            this.SurNameTb.Size = new System.Drawing.Size(250, 38);
            this.SurNameTb.TabIndex = 19;
            // 
            // AddressTb
            // 
            this.AddressTb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.AddressTb.Location = new System.Drawing.Point(290, 430);
            this.AddressTb.MaxLength = 400;
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(250, 105);
            this.AddressTb.TabIndex = 20;
            // 
            // PhoneNumberTb
            // 
            this.PhoneNumberTb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.PhoneNumberTb.Location = new System.Drawing.Point(819, 342);
            this.PhoneNumberTb.MaxLength = 10;
            this.PhoneNumberTb.Name = "PhoneNumberTb";
            this.PhoneNumberTb.Size = new System.Drawing.Size(250, 38);
            this.PhoneNumberTb.TabIndex = 21;
            this.PhoneNumberTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTb_KeyPress);
            // 
            // JobTb
            // 
            this.JobTb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.JobTb.Location = new System.Drawing.Point(819, 424);
            this.JobTb.MaxLength = 20;
            this.JobTb.Name = "JobTb";
            this.JobTb.Size = new System.Drawing.Size(250, 38);
            this.JobTb.TabIndex = 23;
            // 
            // PinTb
            // 
            this.PinTb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.PinTb.Location = new System.Drawing.Point(819, 192);
            this.PinTb.MaxLength = 6;
            this.PinTb.Name = "PinTb";
            this.PinTb.Size = new System.Drawing.Size(250, 38);
            this.PinTb.TabIndex = 26;
            this.PinTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PinTb_KeyPress);
            // 
            // EducationTb
            // 
            this.EducationTb.AllowDrop = true;
            this.EducationTb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.EducationTb.FormattingEnabled = true;
            this.EducationTb.Items.AddRange(new object[] {
            "İlkokul",
            "Ortaokul",
            "Lise",
            "Önlisans",
            "Lisans",
            "Yüksek Lisans",
            "Doktora"});
            this.EducationTb.Location = new System.Drawing.Point(819, 265);
            this.EducationTb.Name = "EducationTb";
            this.EducationTb.Size = new System.Drawing.Size(250, 40);
            this.EducationTb.TabIndex = 27;
            // 
            // DateOfBirthTable
            // 
            this.DateOfBirthTable.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.DateOfBirthTable.Location = new System.Drawing.Point(819, 506);
            this.DateOfBirthTable.MaxDate = new System.DateTime(2024, 1, 2, 0, 0, 0, 0);
            this.DateOfBirthTable.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthTable.Name = "DateOfBirthTable";
            this.DateOfBirthTable.Size = new System.Drawing.Size(250, 38);
            this.DateOfBirthTable.TabIndex = 28;
            this.DateOfBirthTable.Value = new System.DateTime(2024, 1, 2, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            this.button1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(364, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 92);
            this.button1.TabIndex = 29;
            this.button1.Text = "HESAP OLUŞTUR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            this.button2.Location = new System.Drawing.Point(619, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 92);
            this.button2.TabIndex = 30;
            this.button2.Text = "VAZGEÇ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 686);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 11);
            this.panel2.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            this.label5.Location = new System.Drawing.Point(415, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 40);
            this.label5.TabIndex = 32;
            this.label5.Text = "HESAP OLUŞTUR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(140, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "(Kimlik numaranız, hesap numaranız olacaktır.)";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 697);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateOfBirthTable);
            this.Controls.Add(this.EducationTb);
            this.Controls.Add(this.PinTb);
            this.Controls.Add(this.JobTb);
            this.Controls.Add(this.PhoneNumberTb);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.SurNameTb);
            this.Controls.Add(this.AccountNameTb);
            this.Controls.Add(this.AccountNumberTb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AccountNumberTb;
        private System.Windows.Forms.TextBox AccountNameTb;
        private System.Windows.Forms.TextBox SurNameTb;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.TextBox PhoneNumberTb;
        private System.Windows.Forms.TextBox JobTb;
        private System.Windows.Forms.TextBox PinTb;
        private System.Windows.Forms.ComboBox EducationTb;
        private System.Windows.Forms.DateTimePicker DateOfBirthTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}