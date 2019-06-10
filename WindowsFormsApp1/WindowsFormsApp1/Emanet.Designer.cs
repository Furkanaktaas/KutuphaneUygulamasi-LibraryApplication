namespace WindowsFormsApp1
{
    partial class Emanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emanet));
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelKitap = new System.Windows.Forms.Panel();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridKitap = new System.Windows.Forms.DataGridView();
            this.panelKullanici = new System.Windows.Forms.Panel();
            this.btnKullaniciAra = new System.Windows.Forms.Button();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridKullanici = new System.Windows.Forms.DataGridView();
            this.btnİleri = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.panelKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            this.panelKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeriDon.ImageKey = "geridon.png";
            this.btnGeriDon.ImageList = this.imageList1;
            this.btnGeriDon.Location = new System.Drawing.Point(12, 12);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(98, 29);
            this.btnGeriDon.TabIndex = 4;
            this.btnGeriDon.Text = "Menüye Dön";
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "geridon.png");
            this.imageList1.Images.SetKeyName(1, "ileri.png");
            this.imageList1.Images.SetKeyName(2, "ekle.png");
            // 
            // panelKitap
            // 
            this.panelKitap.Controls.Add(this.txtKitapAd);
            this.panelKitap.Controls.Add(this.label1);
            this.panelKitap.Controls.Add(this.gridKitap);
            this.panelKitap.Location = new System.Drawing.Point(3, 47);
            this.panelKitap.Name = "panelKitap";
            this.panelKitap.Size = new System.Drawing.Size(794, 277);
            this.panelKitap.TabIndex = 5;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(91, 6);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(225, 20);
            this.txtKitapAd.TabIndex = 8;
            this.txtKitapAd.TextChanged += new System.EventHandler(this.txtKitapAd_TextChanged);
            this.txtKitapAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapAd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitap Adı Ara :";
            // 
            // gridKitap
            // 
            this.gridKitap.AllowUserToAddRows = false;
            this.gridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKitap.Location = new System.Drawing.Point(11, 32);
            this.gridKitap.Name = "gridKitap";
            this.gridKitap.ReadOnly = true;
            this.gridKitap.Size = new System.Drawing.Size(773, 223);
            this.gridKitap.TabIndex = 6;
            // 
            // panelKullanici
            // 
            this.panelKullanici.Controls.Add(this.btnKullaniciAra);
            this.panelKullanici.Controls.Add(this.txtKullanici);
            this.panelKullanici.Controls.Add(this.label2);
            this.panelKullanici.Controls.Add(this.gridKullanici);
            this.panelKullanici.Location = new System.Drawing.Point(3, 47);
            this.panelKullanici.Name = "panelKullanici";
            this.panelKullanici.Size = new System.Drawing.Size(794, 277);
            this.panelKullanici.TabIndex = 9;
            // 
            // btnKullaniciAra
            // 
            this.btnKullaniciAra.Location = new System.Drawing.Point(319, 4);
            this.btnKullaniciAra.Name = "btnKullaniciAra";
            this.btnKullaniciAra.Size = new System.Drawing.Size(49, 23);
            this.btnKullaniciAra.TabIndex = 9;
            this.btnKullaniciAra.Text = "ARA";
            this.btnKullaniciAra.UseVisualStyleBackColor = true;
            this.btnKullaniciAra.Click += new System.EventHandler(this.btnKullaniciAra_Click);
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(88, 6);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(225, 20);
            this.txtKullanici.TabIndex = 8;
            this.txtKullanici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullanici_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Ara :";
            // 
            // gridKullanici
            // 
            this.gridKullanici.AllowUserToAddRows = false;
            this.gridKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKullanici.Location = new System.Drawing.Point(11, 32);
            this.gridKullanici.Name = "gridKullanici";
            this.gridKullanici.ReadOnly = true;
            this.gridKullanici.Size = new System.Drawing.Size(773, 223);
            this.gridKullanici.TabIndex = 6;
            // 
            // btnİleri
            // 
            this.btnİleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİleri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİleri.ImageKey = "ileri.png";
            this.btnİleri.ImageList = this.imageList1;
            this.btnİleri.Location = new System.Drawing.Point(714, 308);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(73, 29);
            this.btnİleri.TabIndex = 10;
            this.btnİleri.Text = "İleri ";
            this.btnİleri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetVer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmanetVer.ImageKey = "ekle.png";
            this.btnEmanetVer.ImageList = this.imageList1;
            this.btnEmanetVer.Location = new System.Drawing.Point(677, 308);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(110, 29);
            this.btnEmanetVer.TabIndex = 11;
            this.btnEmanetVer.Text = "Emanet Ver";
            this.btnEmanetVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetVer.UseVisualStyleBackColor = true;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // Emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(797, 356);
            this.Controls.Add(this.btnEmanetVer);
            this.Controls.Add(this.btnİleri);
            this.Controls.Add(this.panelKullanici);
            this.Controls.Add(this.panelKitap);
            this.Controls.Add(this.btnGeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Emanet";
            this.Text = "Emanet";
            this.Load += new System.EventHandler(this.Emanet_Load);
            this.panelKitap.ResumeLayout(false);
            this.panelKitap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            this.panelKullanici.ResumeLayout(false);
            this.panelKullanici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelKitap;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridKitap;
        private System.Windows.Forms.Panel panelKullanici;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridKullanici;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.Button btnKullaniciAra;
    }
}