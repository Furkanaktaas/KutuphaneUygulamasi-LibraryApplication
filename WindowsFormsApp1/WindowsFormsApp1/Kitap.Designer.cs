namespace WindowsFormsApp1
{
    partial class Kitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridKitap = new System.Windows.Forms.DataGridView();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnExceldenAktar = new System.Windows.Forms.Button();
            this.txtUzanti = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "geridon.png");
            this.imageList1.Images.SetKeyName(1, "ekle.png");
            this.imageList1.Images.SetKeyName(2, "exceleaktar.png");
            this.imageList1.Images.SetKeyName(3, "exceldenaktar.png");
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(322, 49);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(122, 20);
            this.txtKitapAd.TabIndex = 13;
            this.txtKitapAd.TextChanged += new System.EventHandler(this.txtKitapAd_TextChanged);
            this.txtKitapAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapAd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kitap Adına Göre Ara:";
            // 
            // gridKitap
            // 
            this.gridKitap.AllowUserToAddRows = false;
            this.gridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKitap.Location = new System.Drawing.Point(9, 76);
            this.gridKitap.Name = "gridKitap";
            this.gridKitap.ReadOnly = true;
            this.gridKitap.Size = new System.Drawing.Size(776, 298);
            this.gridKitap.TabIndex = 10;
            // 
            // comboDurum
            // 
            this.comboDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Location = new System.Drawing.Point(75, 49);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(121, 21);
            this.comboDurum.TabIndex = 9;
            this.comboDurum.SelectedIndexChanged += new System.EventHandler(this.comboDurum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Durum Türü :";
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniEkle.ImageKey = "ekle.png";
            this.btnYeniEkle.ImageList = this.imageList1;
            this.btnYeniEkle.Location = new System.Drawing.Point(707, 34);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(78, 37);
            this.btnYeniEkle.TabIndex = 11;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeniEkle.UseVisualStyleBackColor = true;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
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
            // btnExcel
            // 
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.ImageKey = "exceleaktar.png";
            this.btnExcel.ImageList = this.imageList1;
            this.btnExcel.Location = new System.Drawing.Point(601, 34);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 36);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "Excele Aktar";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnExceldenAktar
            // 
            this.btnExceldenAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExceldenAktar.ImageKey = "exceldenaktar.png";
            this.btnExceldenAktar.ImageList = this.imageList1;
            this.btnExceldenAktar.Location = new System.Drawing.Point(488, 34);
            this.btnExceldenAktar.Name = "btnExceldenAktar";
            this.btnExceldenAktar.Size = new System.Drawing.Size(107, 36);
            this.btnExceldenAktar.TabIndex = 14;
            this.btnExceldenAktar.Text = "Excelden Aktar";
            this.btnExceldenAktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExceldenAktar.UseVisualStyleBackColor = true;
            this.btnExceldenAktar.Click += new System.EventHandler(this.btnExceldenAktar_Click);
            // 
            // txtUzanti
            // 
            this.txtUzanti.Location = new System.Drawing.Point(488, 12);
            this.txtUzanti.Name = "txtUzanti";
            this.txtUzanti.Size = new System.Drawing.Size(107, 20);
            this.txtUzanti.TabIndex = 15;
            this.txtUzanti.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(797, 386);
            this.Controls.Add(this.txtUzanti);
            this.Controls.Add(this.btnExceldenAktar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnYeniEkle);
            this.Controls.Add(this.gridKitap);
            this.Controls.Add(this.comboDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kitap";
            this.Text = "Kitap";
            this.Load += new System.EventHandler(this.Kitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeniEkle;
        private System.Windows.Forms.DataGridView gridKitap;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnExceldenAktar;
        private System.Windows.Forms.TextBox txtUzanti;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}