namespace Toko
{
    partial class FProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnGender = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPIN = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROFILE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(889, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(455, 30);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "PhoneNum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "PIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Profile Picture";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(158, 134);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.ReadOnly = true;
            this.txtPhoneNum.Size = new System.Drawing.Size(455, 30);
            this.txtPhoneNum.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(455, 30);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(158, 225);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(455, 30);
            this.txtPIN.TabIndex = 12;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(158, 268);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(455, 30);
            this.date.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(158, 318);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(455, 101);
            this.txtAddress.TabIndex = 14;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(158, 434);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(455, 33);
            this.cbGender.TabIndex = 15;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(154, 502);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(125, 125);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 16;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(285, 582);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(128, 45);
            this.btnUpload.TabIndex = 17;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(628, 83);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(109, 40);
            this.btnName.TabIndex = 18;
            this.btnName.Text = "Edit";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnPin
            // 
            this.btnPin.Location = new System.Drawing.Point(628, 220);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(109, 40);
            this.btnPin.TabIndex = 19;
            this.btnPin.Text = "Edit";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(628, 265);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(109, 40);
            this.btnDate.TabIndex = 20;
            this.btnDate.Text = "Edit";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnAddress
            // 
            this.btnAddress.Location = new System.Drawing.Point(628, 318);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(109, 40);
            this.btnAddress.TabIndex = 21;
            this.btnAddress.Text = "Edit";
            this.btnAddress.UseVisualStyleBackColor = true;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // btnGender
            // 
            this.btnGender.Location = new System.Drawing.Point(628, 429);
            this.btnGender.Name = "btnGender";
            this.btnGender.Size = new System.Drawing.Size(109, 40);
            this.btnGender.TabIndex = 22;
            this.btnGender.Text = "Edit";
            this.btnGender.UseVisualStyleBackColor = true;
            this.btnGender.Click += new System.EventHandler(this.btnGender_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(775, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 25);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Error";
            this.lblName.Visible = false;
            // 
            // lblPIN
            // 
            this.lblPIN.AutoSize = true;
            this.lblPIN.ForeColor = System.Drawing.Color.Red;
            this.lblPIN.Location = new System.Drawing.Point(775, 230);
            this.lblPIN.Name = "lblPIN";
            this.lblPIN.Size = new System.Drawing.Size(54, 25);
            this.lblPIN.TabIndex = 24;
            this.lblPIN.Text = "Error";
            this.lblPIN.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.Location = new System.Drawing.Point(775, 273);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 25);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Error";
            this.lblDate.Visible = false;
            // 
            // FProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1009, 639);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPIN);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGender);
            this.Controls.Add(this.btnAddress);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPIN;
        private System.Windows.Forms.Label lblDate;
    }
}