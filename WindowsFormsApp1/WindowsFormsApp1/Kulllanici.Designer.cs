namespace WindowsFormsApp1
{
    partial class Kulllanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kulllanici));
            this.label1 = new System.Windows.Forms.Label();
            this.comboKullaniciTuru = new System.Windows.Forms.ComboBox();
            this.gridKullanici = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Türü:";
            // 
            // comboKullaniciTuru
            // 
            this.comboKullaniciTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKullaniciTuru.FormattingEnabled = true;
            this.comboKullaniciTuru.Location = new System.Drawing.Point(84, 47);
            this.comboKullaniciTuru.Name = "comboKullaniciTuru";
            this.comboKullaniciTuru.Size = new System.Drawing.Size(121, 21);
            this.comboKullaniciTuru.TabIndex = 1;
            this.comboKullaniciTuru.SelectedIndexChanged += new System.EventHandler(this.comboKullaniciTuru_SelectedIndexChanged);
            // 
            // gridKullanici
            // 
            this.gridKullanici.AllowUserToAddRows = false;
            this.gridKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKullanici.Location = new System.Drawing.Point(12, 74);
            this.gridKullanici.Name = "gridKullanici";
            this.gridKullanici.ReadOnly = true;
            this.gridKullanici.Size = new System.Drawing.Size(835, 298);
            this.gridKullanici.TabIndex = 2;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeriDon.ImageKey = "geridon.png";
            this.btnGeriDon.ImageList = this.imageList1;
            this.btnGeriDon.Location = new System.Drawing.Point(12, 12);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(98, 29);
            this.btnGeriDon.TabIndex = 3;
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
            this.imageList1.Images.SetKeyName(1, "ekle.png");
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniEkle.ImageKey = "ekle.png";
            this.btnYeniEkle.ImageList = this.imageList1;
            this.btnYeniEkle.Location = new System.Drawing.Point(769, 31);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(78, 37);
            this.btnYeniEkle.TabIndex = 3;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeniEkle.UseVisualStyleBackColor = true;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Epostaya Göre Ara:";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(315, 48);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(122, 20);
            this.txtEposta.TabIndex = 5;
            this.txtEposta.TextChanged += new System.EventHandler(this.txtEposta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad ve Soyada Göre Arama :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(590, 47);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 7;
            this.txtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(696, 47);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(41, 20);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Kulllanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(859, 386);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnYeniEkle);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.gridKullanici);
            this.Controls.Add(this.comboKullaniciTuru);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kulllanici";
            this.Text = "Kullanıcı";
            this.Load += new System.EventHandler(this.Kulllanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKullaniciTuru;
        private System.Windows.Forms.DataGridView gridKullanici;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnYeniEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnAra;
    }
}