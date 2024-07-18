using System.Windows.Forms;

namespace OgrenciSistemiSelcanErcan
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.BtnOgrenciGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OgrenciAd = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtOgretmenSifre = new System.Windows.Forms.TextBox();
            this.TxtOgretmenAdı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnOgretmenGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOgrenciGiris
            // 
            this.BtnOgrenciGiris.Location = new System.Drawing.Point(144, 327);
            this.BtnOgrenciGiris.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOgrenciGiris.Name = "BtnOgrenciGiris";
            this.BtnOgrenciGiris.Size = new System.Drawing.Size(141, 35);
            this.BtnOgrenciGiris.TabIndex = 2;
            this.BtnOgrenciGiris.Text = "GİRİŞ";
            this.BtnOgrenciGiris.UseVisualStyleBackColor = true;
            this.BtnOgrenciGiris.Click += new System.EventHandler(this.BtnOgrenciGiris_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci Numara ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 157);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(238, 267);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 30);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OgrenciAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.BtnOgrenciGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(471, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 398);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Giriş";
            // 
            // OgrenciAd
            // 
            this.OgrenciAd.Location = new System.Drawing.Point(238, 225);
            this.OgrenciAd.Name = "OgrenciAd";
            this.OgrenciAd.Size = new System.Drawing.Size(125, 30);
            this.OgrenciAd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Öğrenci Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtOgretmenSifre);
            this.groupBox2.Controls.Add(this.TxtOgretmenAdı);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.BtnOgretmenGiris);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 407);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğretmen Giriş";
            // 
            // TxtOgretmenSifre
            // 
            this.TxtOgretmenSifre.Location = new System.Drawing.Point(243, 289);
            this.TxtOgretmenSifre.Name = "TxtOgretmenSifre";
            this.TxtOgretmenSifre.Size = new System.Drawing.Size(100, 30);
            this.TxtOgretmenSifre.TabIndex = 10;
            // 
            // TxtOgretmenAdı
            // 
            this.TxtOgretmenAdı.Location = new System.Drawing.Point(243, 225);
            this.TxtOgretmenAdı.Name = "TxtOgretmenAdı";
            this.TxtOgretmenAdı.Size = new System.Drawing.Size(100, 30);
            this.TxtOgretmenAdı.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(118, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 157);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // BtnOgretmenGiris
            // 
            this.BtnOgretmenGiris.Location = new System.Drawing.Point(118, 348);
            this.BtnOgretmenGiris.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOgretmenGiris.Name = "BtnOgretmenGiris";
            this.BtnOgretmenGiris.Size = new System.Drawing.Size(141, 35);
            this.BtnOgretmenGiris.TabIndex = 2;
            this.BtnOgretmenGiris.Text = "GİRİŞ";
            this.BtnOgretmenGiris.UseVisualStyleBackColor = true;
            this.BtnOgretmenGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button BtnOgrenciGiris;
        private Label label2;
        private TextBox TxbAdı;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private MaskedTextBox OgrenciAd;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private Label label4;
        private PictureBox pictureBox2;
        private Button BtnOgretmenGiris;
        private Label label3;
        private TextBox TxtOgretmenSifre;
        private TextBox TxtOgretmenAdı;
    }
}