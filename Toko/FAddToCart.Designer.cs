namespace Toko
{
    partial class FAddToCart
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
            this.txtName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(21, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 40);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(304, 126);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(56, 25);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "Price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 177);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(363, 211);
            this.textBox1.TabIndex = 3;
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Location = new System.Drawing.Point(143, 426);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(23, 25);
            this.txtCount.TabIndex = 4;
            this.txtCount.Text = "1";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(195, 413);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 50);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(59, 413);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 50);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FAddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FAddToCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddToCart";
            this.Load += new System.EventHandler(this.FAddToCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtCount;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button button1;
    }
}