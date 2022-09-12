namespace Toko
{
    partial class FCart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.cbUsePoint = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblPlatformFee = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "CART";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(991, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment Type";
            // 
            // cbPayment
            // 
            this.cbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Location = new System.Drawing.Point(161, 235);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(367, 33);
            this.cbPayment.TabIndex = 4;
            // 
            // cbUsePoint
            // 
            this.cbUsePoint.AutoSize = true;
            this.cbUsePoint.Location = new System.Drawing.Point(12, 274);
            this.cbUsePoint.Name = "cbUsePoint";
            this.cbUsePoint.Size = new System.Drawing.Size(261, 29);
            this.cbUsePoint.TabIndex = 5;
            this.cbUsePoint.Text = "Pay Using Available Point";
            this.cbUsePoint.UseVisualStyleBackColor = true;
            this.cbUsePoint.CheckedChanged += new System.EventHandler(this.cbUsePoint_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "5% Platform Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sub-Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Available Point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Amout To Pay";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(408, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "=================================";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(583, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(408, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "=================================";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(997, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(428, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "+";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(198, 324);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(75, 25);
            this.lblSubTotal.TabIndex = 16;
            this.lblSubTotal.Text = "label13";
            // 
            // lblPlatformFee
            // 
            this.lblPlatformFee.AutoSize = true;
            this.lblPlatformFee.Location = new System.Drawing.Point(198, 362);
            this.lblPlatformFee.Name = "lblPlatformFee";
            this.lblPlatformFee.Size = new System.Drawing.Size(75, 25);
            this.lblPlatformFee.TabIndex = 17;
            this.lblPlatformFee.Text = "label13";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(770, 324);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 25);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "label13";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Location = new System.Drawing.Point(198, 431);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(75, 25);
            this.lblTotal2.TabIndex = 19;
            this.lblTotal2.Text = "label13";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(770, 362);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(75, 25);
            this.lblPoint.TabIndex = 20;
            this.lblPoint.Text = "label13";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(770, 431);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(75, 25);
            this.lblPay.TabIndex = 21;
            this.lblPay.Text = "label13";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Image";
            this.Column2.HeaderText = "Image";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Name";
            this.Column3.HeaderText = "Name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Qty";
            this.Column5.HeaderText = "Qty";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Edit";
            this.Column6.Image = global::Toko.Properties.Resources.edit;
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Delete";
            this.Column7.Image = global::Toko.Properties.Resources.delete;
            this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPlatformFee);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbUsePoint);
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCart";
            this.Load += new System.EventHandler(this.FCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.CheckBox cbUsePoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblPlatformFee;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
    }
}