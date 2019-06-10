namespace WindowsFormsApp1
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnHesapBilgileri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYedek = new System.Windows.Forms.Button();
            this.btnEmanetVerme = new System.Windows.Forms.Button();
            this.btnTeslimAlma = new System.Windows.Forms.Button();
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnSilinmis = new System.Windows.Forms.Button();
            this.btnKullanıcı = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "kitaplar.png");
            this.imageList1.Images.SetKeyName(1, "kullanıcı.png");
            this.imageList1.Images.SetKeyName(2, "yedek.png");
            this.imageList1.Images.SetKeyName(3, "cikis.png");
            this.imageList1.Images.SetKeyName(4, "emanet.png");
            this.imageList1.Images.SetKeyName(5, "silinmis.png");
            this.imageList1.Images.SetKeyName(6, "teslimalma.png");
            this.imageList1.Images.SetKeyName(7, "hesapbilgileri.png");
            // 
            // btnHesapBilgileri
            // 
            this.btnHesapBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapBilgileri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHesapBilgileri.ImageKey = "hesapbilgileri.png";
            this.btnHesapBilgileri.ImageList = this.imageList1;
            this.btnHesapBilgileri.Location = new System.Drawing.Point(477, 171);
            this.btnHesapBilgileri.Name = "btnHesapBilgileri";
            this.btnHesapBilgileri.Size = new System.Drawing.Size(131, 65);
            this.btnHesapBilgileri.TabIndex = 6;
            this.btnHesapBilgileri.Text = "Hesabım";
            this.btnHesapBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHesapBilgileri.UseVisualStyleBackColor = true;
            this.btnHesapBilgileri.Click += new System.EventHandler(this.btnHesapBilgileri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "cikis.png";
            this.btnCikis.ImageList = this.imageList1;
            this.btnCikis.Location = new System.Drawing.Point(477, 242);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(131, 65);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYedek
            // 
            this.btnYedek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedek.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYedek.ImageKey = "yedek.png";
            this.btnYedek.ImageList = this.imageList1;
            this.btnYedek.Location = new System.Drawing.Point(477, 100);
            this.btnYedek.Name = "btnYedek";
            this.btnYedek.Size = new System.Drawing.Size(131, 65);
            this.btnYedek.TabIndex = 6;
            this.btnYedek.Text = "Yedekleme İşlemleri";
            this.btnYedek.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYedek.UseVisualStyleBackColor = true;
            this.btnYedek.Click += new System.EventHandler(this.btnYedek_Click);
            // 
            // btnEmanetVerme
            // 
            this.btnEmanetVerme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetVerme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmanetVerme.ImageKey = "emanet.png";
            this.btnEmanetVerme.ImageList = this.imageList1;
            this.btnEmanetVerme.Location = new System.Drawing.Point(21, 29);
            this.btnEmanetVerme.Name = "btnEmanetVerme";
            this.btnEmanetVerme.Size = new System.Drawing.Size(131, 65);
            this.btnEmanetVerme.TabIndex = 0;
            this.btnEmanetVerme.Text = "Emanet Verme";
            this.btnEmanetVerme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmanetVerme.UseVisualStyleBackColor = true;
            this.btnEmanetVerme.Click += new System.EventHandler(this.btnEmanetVerme_Click);
            // 
            // btnTeslimAlma
            // 
            this.btnTeslimAlma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimAlma.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeslimAlma.ImageKey = "teslimalma.png";
            this.btnTeslimAlma.ImageList = this.imageList1;
            this.btnTeslimAlma.Location = new System.Drawing.Point(21, 100);
            this.btnTeslimAlma.Name = "btnTeslimAlma";
            this.btnTeslimAlma.Size = new System.Drawing.Size(131, 65);
            this.btnTeslimAlma.TabIndex = 2;
            this.btnTeslimAlma.Text = "Teslim Alma";
            this.btnTeslimAlma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeslimAlma.UseVisualStyleBackColor = true;
            this.btnTeslimAlma.Click += new System.EventHandler(this.btnTeslimAlma_Click);
            // 
            // btnKitap
            // 
            this.btnKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitap.ImageKey = "kitaplar.png";
            this.btnKitap.ImageList = this.imageList1;
            this.btnKitap.Location = new System.Drawing.Point(21, 171);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(131, 65);
            this.btnKitap.TabIndex = 2;
            this.btnKitap.Text = "Kitap İşlemleri";
            this.btnKitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnSilinmis
            // 
            this.btnSilinmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilinmis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSilinmis.ImageKey = "silinmis.png";
            this.btnSilinmis.ImageList = this.imageList1;
            this.btnSilinmis.Location = new System.Drawing.Point(477, 29);
            this.btnSilinmis.Name = "btnSilinmis";
            this.btnSilinmis.Size = new System.Drawing.Size(131, 65);
            this.btnSilinmis.TabIndex = 5;
            this.btnSilinmis.Text = "Silinmiş Kayıtlar";
            this.btnSilinmis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSilinmis.UseVisualStyleBackColor = true;
            this.btnSilinmis.Click += new System.EventHandler(this.btnSilinmis_Click);
            // 
            // btnKullanıcı
            // 
            this.btnKullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcı.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKullanıcı.ImageKey = "kullanıcı.png";
            this.btnKullanıcı.ImageList = this.imageList1;
            this.btnKullanıcı.Location = new System.Drawing.Point(21, 242);
            this.btnKullanıcı.Name = "btnKullanıcı";
            this.btnKullanıcı.Size = new System.Drawing.Size(131, 65);
            this.btnKullanıcı.TabIndex = 3;
            this.btnKullanıcı.Text = "Kullanıcı İşlemleri";
            this.btnKullanıcı.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullanıcı.UseVisualStyleBackColor = true;
            this.btnKullanıcı.Click += new System.EventHandler(this.btnKullanıcı_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(637, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnHesapBilgileri);
            this.Controls.Add(this.btnYedek);
            this.Controls.Add(this.btnEmanetVerme);
            this.Controls.Add(this.btnTeslimAlma);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.btnSilinmis);
            this.Controls.Add(this.btnKullanıcı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnKullanıcı;
        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnYedek;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnEmanetVerme;
        private System.Windows.Forms.Button btnSilinmis;
        private System.Windows.Forms.Button btnTeslimAlma;
        private System.Windows.Forms.Button btnHesapBilgileri;
    }
}