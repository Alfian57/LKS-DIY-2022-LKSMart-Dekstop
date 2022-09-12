namespace Toko
{
    partial class FLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailOrPhone = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number / Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIN Number";
            // 
            // txtEmailOrPhone
            // 
            this.txtEmailOrPhone.Location = new System.Drawing.Point(79, 161);
            this.txtEmailOrPhone.Name = "txtEmailOrPhone";
            this.txtEmailOrPhone.Size = new System.Drawing.Size(509, 30);
            this.txtEmailOrPhone.TabIndex = 1;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(79, 252);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(509, 30);
            this.txtPin.TabIndex = 2;
            this.txtPin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "LKS Mart";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(676, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtEmailOrPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailOrPhone;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

