namespace faceguitest
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResolusi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.cbKolom = new System.Windows.Forms.ComboBox();
            this.cbBaris = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cek Gambar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(544, 232);
            this.txtHasil.Multiline = true;
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(219, 197);
            this.txtHasil.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resolusi";
            // 
            // lblResolusi
            // 
            this.lblResolusi.AutoSize = true;
            this.lblResolusi.Location = new System.Drawing.Point(633, 75);
            this.lblResolusi.Name = "lblResolusi";
            this.lblResolusi.Size = new System.Drawing.Size(35, 13);
            this.lblResolusi.TabIndex = 4;
            this.lblResolusi.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Width";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(633, 93);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Height";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(633, 110);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(35, 13);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "label6";
            // 
            // cbKolom
            // 
            this.cbKolom.FormattingEnabled = true;
            this.cbKolom.Location = new System.Drawing.Point(544, 205);
            this.cbKolom.Name = "cbKolom";
            this.cbKolom.Size = new System.Drawing.Size(87, 21);
            this.cbKolom.TabIndex = 9;
            // 
            // cbBaris
            // 
            this.cbBaris.FormattingEnabled = true;
            this.cbBaris.Location = new System.Drawing.Point(675, 205);
            this.cbBaris.Name = "cbBaris";
            this.cbBaris.Size = new System.Drawing.Size(88, 21);
            this.cbBaris.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Width / Kolom ke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Height / Baris ke";
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Location = new System.Drawing.Point(548, 153);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(35, 13);
            this.lblWaktu.TabIndex = 13;
            this.lblWaktu.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBaris);
            this.Controls.Add(this.cbKolom);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResolusi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResolusi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.ComboBox cbKolom;
        private System.Windows.Forms.ComboBox cbBaris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWaktu;
    }
}

