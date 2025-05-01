namespace NtpKutuphane
{
    partial class AnaSayfaForm
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
            this.btnOdunc = new System.Windows.Forms.Button();
            this.btnTur = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnKitap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdunc
            // 
            this.btnOdunc.Image = global::NtpKutuphane.Properties.Resources.Ekran_görüntüsü_2025_04_23_115700;
            this.btnOdunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdunc.Location = new System.Drawing.Point(387, 276);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(180, 70);
            this.btnOdunc.TabIndex = 7;
            this.btnOdunc.Text = "Ödünç Kitap İşlemleri\r\n";
            this.btnOdunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdunc.UseVisualStyleBackColor = true;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // btnTur
            // 
            this.btnTur.Image = global::NtpKutuphane.Properties.Resources.Ekran_görüntüsü_2025_04_23_115649;
            this.btnTur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTur.Location = new System.Drawing.Point(187, 276);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(166, 70);
            this.btnTur.TabIndex = 6;
            this.btnTur.Text = "Tür İşlemleri";
            this.btnTur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTur.UseVisualStyleBackColor = true;
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Image = global::NtpKutuphane.Properties.Resources.Ekran_görüntüsü_2025_04_23_115633;
            this.btnOgrenci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenci.Location = new System.Drawing.Point(387, 166);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(180, 70);
            this.btnOgrenci.TabIndex = 5;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnKitap
            // 
            this.btnKitap.Image = global::NtpKutuphane.Properties.Resources.Ekran_görüntüsü_2025_04_23_115547;
            this.btnKitap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitap.Location = new System.Drawing.Point(187, 166);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(166, 70);
            this.btnKitap.TabIndex = 4;
            this.btnKitap.Text = "Kitap İşlemleri";
            this.btnKitap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // formAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnKitap);
            this.Name = "formAnaSayfa";
            this.Text = "Kütüphane Projesi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdunc;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnKitap;
    }
}

