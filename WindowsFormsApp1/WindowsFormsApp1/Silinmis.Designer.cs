namespace WindowsFormsApp1
{
    partial class Silinmis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Silinmis));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridSilinmis = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSilinmis)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "geridon.png");
            // 
            // gridSilinmis
            // 
            this.gridSilinmis.AllowUserToAddRows = false;
            this.gridSilinmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSilinmis.Location = new System.Drawing.Point(12, 47);
            this.gridSilinmis.Name = "gridSilinmis";
            this.gridSilinmis.ReadOnly = true;
            this.gridSilinmis.Size = new System.Drawing.Size(773, 327);
            this.gridSilinmis.TabIndex = 5;
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
            // Silinmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(797, 386);
            this.Controls.Add(this.gridSilinmis);
            this.Controls.Add(this.btnGeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Silinmis";
            this.Text = "Silinmiş";
            this.Load += new System.EventHandler(this.Silinmis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSilinmis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView gridSilinmis;
    }
}