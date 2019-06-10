namespace WindowsFormsApp1
{
    partial class TeslimAlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeslimAlma));
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridTeslimAlma = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.panelRapor = new System.Windows.Forms.Panel();
            this.comboBolum = new System.Windows.Forms.ComboBox();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeslimAlma)).BeginInit();
            this.panelRapor.SuspendLayout();
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
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(125, 50);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(122, 20);
            this.txtAdSoyad.TabIndex = 18;
            this.txtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ad Soyada Göre Ara:";
            // 
            // gridTeslimAlma
            // 
            this.gridTeslimAlma.AllowUserToAddRows = false;
            this.gridTeslimAlma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeslimAlma.Location = new System.Drawing.Point(9, 76);
            this.gridTeslimAlma.Name = "gridTeslimAlma";
            this.gridTeslimAlma.ReadOnly = true;
            this.gridTeslimAlma.Size = new System.Drawing.Size(776, 298);
            this.gridTeslimAlma.TabIndex = 16;
            this.gridTeslimAlma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTeslimAlma_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Durum :";
            // 
            // comboDurum
            // 
            this.comboDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Location = new System.Drawing.Point(361, 49);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(159, 21);
            this.comboDurum.TabIndex = 20;
            this.comboDurum.SelectedIndexChanged += new System.EventHandler(this.comboDurum_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(253, 48);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(45, 23);
            this.btnAra.TabIndex = 21;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panelRapor
            // 
            this.panelRapor.Controls.Add(this.label3);
            this.panelRapor.Controls.Add(this.comboBolum);
            this.panelRapor.Controls.Add(this.btnRaporla);
            this.panelRapor.Location = new System.Drawing.Point(550, 12);
            this.panelRapor.Name = "panelRapor";
            this.panelRapor.Size = new System.Drawing.Size(235, 64);
            this.panelRapor.TabIndex = 22;
            // 
            // comboBolum
            // 
            this.comboBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBolum.FormattingEnabled = true;
            this.comboBolum.Location = new System.Drawing.Point(3, 37);
            this.comboBolum.Name = "comboBolum";
            this.comboBolum.Size = new System.Drawing.Size(151, 21);
            this.comboBolum.TabIndex = 23;
            this.comboBolum.SelectedIndexChanged += new System.EventHandler(this.comboBolum_SelectedIndexChanged);
            // 
            // btnRaporla
            // 
            this.btnRaporla.Location = new System.Drawing.Point(157, 35);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(75, 23);
            this.btnRaporla.TabIndex = 0;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.UseVisualStyleBackColor = true;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bölüme Göre Raporlama";
            // 
            // TeslimAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(797, 386);
            this.Controls.Add(this.panelRapor);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.comboDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridTeslimAlma);
            this.Controls.Add(this.btnGeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TeslimAlma";
            this.Text = "TeslimAlma";
            this.Load += new System.EventHandler(this.TeslimAlma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTeslimAlma)).EndInit();
            this.panelRapor.ResumeLayout(false);
            this.panelRapor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridTeslimAlma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel panelRapor;
        private System.Windows.Forms.ComboBox comboBolum;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.Label label3;
    }
}