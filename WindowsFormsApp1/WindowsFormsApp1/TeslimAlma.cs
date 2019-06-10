using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class TeslimAlma : Form
    {
        Baglanti baglanti = new Baglanti();
        OracleCommand komut = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataTable dt = new DataTable();
        KullaniciBilgileri KullaniciBilgileri = new KullaniciBilgileri();

        public TeslimAlma()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeslimAlma_Load(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            gridTeslimAlma.ClearSelection();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            gridTeslimAlma.Columns.Add(btn);
            btn.HeaderText = "Teslim Alma";
            btn.Text = "Teslim Al";
            btn.Name = "btnTeslim";
            btn.UseColumnTextForButtonValue = true;
            // ******************** GRİDE TESLİM AL BUTON EKLEME
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            gridTeslimAlma.Columns.Add(btn2);
            btn2.HeaderText = "Kayıt Silme";
            btn2.Text = "Sil";
            btn2.Name = "btnSil";
            btn2.UseColumnTextForButtonValue = true;
            // ******************** GRİDE SİL BUTON EKLEME
            komut = new OracleCommand("SELECT * FROM ODUNC O INNER JOIN KULLANICI KU ON O.KULLANICIID = KU.KULLANICIID INNER JOIN KITAP K ON O.KITAPID = K.KITAPID WHERE O.DONUS_TARIHI IS NULL", baglanti.baglan);
            da = new OracleDataAdapter();
            dt = new DataTable();
            da.SelectCommand = komut;
            da.Fill(dt);
            gridTeslimAlma.DataSource = dt;
            GridDuzenle();
            // ************************ GRİD DOLDURMA SONU
            comboDurum.Items.Add("EMANETTE OLANLAR");
            comboDurum.Items.Add("TESLİM EDİLMİŞLER");
            // ************************** COMBO DURUM DOLDURMA SONU
            comboBolum.Items.Add("Bilgisayar Mühendisliği");
            comboBolum.Items.Add("Elektrik-Elektronik Mühendisliği");
            comboBolum.Items.Add("İnşaat Mühendisliği");
            //************************** COMBO BOLUM DORLDURMA
            panelRapor.Visible = false;

            if (KullaniciBilgileri.yetkiID == "2")
                gridTeslimAlma.Columns[1].Visible = false;
            // ********** PERSONEL YETKİSİ KISITLAMA
        }

        public void GridDuzenle()
        {
            gridTeslimAlma.Columns[1].Visible = false;
            gridTeslimAlma.Columns[2].Visible = false;
            gridTeslimAlma.Columns[5].Visible = false;
            gridTeslimAlma.Columns[6].Visible = false;
            gridTeslimAlma.Columns[7].Visible = false;
            gridTeslimAlma.Columns[12].Visible = false;
            gridTeslimAlma.Columns[14].Visible = false;
            gridTeslimAlma.Columns[15].Visible = false;
            gridTeslimAlma.Columns[21].Visible = false;
            gridTeslimAlma.Columns[3].HeaderText = "VERİLİŞ TARİHİ";
            gridTeslimAlma.Columns[4].HeaderText = "DÖNÜŞ TARİHİ";
            gridTeslimAlma.Columns[16].HeaderText = "KİTAP ADI";
            gridTeslimAlma.Columns[18].HeaderText = "SAYFA SAYISI";
            gridTeslimAlma.Columns[19].HeaderText = "YAYIN EVİ";
            gridTeslimAlma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void gridTeslimAlma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridTeslimAlma.Columns["btnTeslim"].Index)
            {
                if (baglanti.baglan.State == ConnectionState.Closed)
                {
                    baglanti.baglan.Open();
                }
                komut = new OracleCommand("UPDATE ODUNC SET DONUS_TARIHI=TO_DATE('" + DateTime.Now.ToShortDateString() + "','DD/MM/YYYY') WHERE ODUNCID =" + gridTeslimAlma.CurrentRow.Cells[2].Value.ToString() + " ", baglanti.baglan);
                komut.ExecuteNonQuery();
                komut = new OracleCommand("UPDATE KITAP SET DURUMID=1 WHERE KITAPID=" + gridTeslimAlma.CurrentRow.Cells[15].Value.ToString() + "", baglanti.baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("Teslim Alma Başarılı.", "BAŞARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                TeslimAlma teslimAlma = new TeslimAlma();
                teslimAlma.Show();
            }
            else if (e.ColumnIndex == gridTeslimAlma.Columns["btnSil"].Index)
            {
                komut = new OracleCommand("DELETE FROM ODUNC WHERE ODUNCID =" + gridTeslimAlma.CurrentRow.Cells[2].Value.ToString() + " ", baglanti.baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Başarılı", "BAŞARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                komut = new OracleCommand("SELECT * FROM ODUNC O INNER JOIN KULLANICI KU ON O.KULLANICIID = KU.KULLANICIID INNER JOIN KITAP K ON O.KITAPID = K.KITAPID WHERE O.DONUS_TARIHI IS NOT NULL", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridTeslimAlma.DataSource = dt;
                GridDuzenle();
                gridTeslimAlma.Columns[1].Visible = true;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            if (txtAdSoyad.Text.Trim() == "")
            {
                komut = new OracleCommand("SELECT * FROM ODUNC O INNER JOIN KULLANICI KU ON O.KULLANICIID = KU.KULLANICIID INNER JOIN KITAP K ON O.KITAPID = K.KITAPID WHERE O.DONUS_TARIHI IS NULL", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridTeslimAlma.DataSource = dt;
                GridDuzenle();
            }
            else
            {
                string[] parcalar = txtAdSoyad.Text.ToLower().Split(' ');
                komut = new OracleCommand("SELECT * FROM ODUNC O INNER JOIN KULLANICI KU ON O.KULLANICIID = KU.KULLANICIID INNER JOIN KITAP K ON O.KITAPID = K.KITAPID WHERE O.DONUS_TARIHI IS NULL AND KU.AD='" + parcalar[0].ToString() + "' AND KU.SOYAD = '" + parcalar[1].ToString() + "'", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridTeslimAlma.DataSource = dt;
            }
        }

        private void comboDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            if (comboDurum.SelectedItem.ToString() == "EMANETTE OLANLAR")
            {
                komut = new OracleCommand("SELECT * FROM ODUNC O INNER JOIN KULLANICI KU ON O.KULLANICIID = KU.KULLANICIID INNER JOIN KITAP K ON O.KITAPID = K.KITAPID WHERE O.DONUS_TARIHI IS NULL", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridTeslimAlma.DataSource = dt;
                GridDuzenle();
                gridTeslimAlma.Columns[0].Visible = true;
                gridTeslimAlma.Columns[1].Visible = false;
                panelRapor.Visible = false;
            }
            else if (comboDurum.SelectedItem.ToString() == "TESLİM EDİLMİŞLER")
            {
                komut = new OracleCommand("SELECT * FROM ODUNC O INNER JOIN KULLANICI KU ON O.KULLANICIID = KU.KULLANICIID INNER JOIN KITAP K ON O.KITAPID = K.KITAPID WHERE O.DONUS_TARIHI IS NOT NULL", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridTeslimAlma.DataSource = dt;
                GridDuzenle();
                gridTeslimAlma.Columns[0].Visible = false;
                panelRapor.Visible = true;
                if (KullaniciBilgileri.yetkiID != "2")
                    gridTeslimAlma.Columns[1].Visible = true;
            }
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            pdfileYazma(gridTeslimAlma);
        }

        private void comboBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            komut = new OracleCommand("  SELECT KU.AD, KU.SOYAD ,K.AD, K.YAZAR, K.TUR, OG.BOLUMAD FROM ODUNC O INNER JOIN KULLANICI KU ON O.KULLANICIID= KU.KULLANICIID INNER JOIN KITAP K ON O.KITAPID = K.KITAPID INNER JOIN OGRENCI OG ON KU.KULLANICIID= OG.KULLANICIID WHERE O.DONUS_TARIHI IS NOT NULL AND OG.BOLUMAD ='" + comboBolum.SelectedItem.ToString().ToLower() + "' ", baglanti.baglan);
            da = new OracleDataAdapter();
            dt = new DataTable();
            da.SelectCommand = komut;
            da.Fill(dt);
            gridTeslimAlma.DataSource = dt;
            gridTeslimAlma.Columns[1].Visible = false;
        }

        public void pdfileYazma(DataGridView veriTablosu)
        {
            try
            {
                PdfPTable pdfTablosu = new PdfPTable(veriTablosu.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTablosu.DefaultCell.BorderWidth = 1;
                foreach (DataGridViewColumn sutun in veriTablosu.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in veriTablosu.Rows)
                {
                    foreach (DataGridViewCell cell in satir.Cells)
                    {
                        pdfTablosu.AddCell(Convert.ToString(cell.Value));
                    }
                }

                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.FileName = "rapor";
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "PDF Dosyası|*.pdf";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(dosyakaydet.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTablosu);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }

        }


    }
}
