using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Kitap : Form
    {
        Baglanti baglanti = new Baglanti();
        OracleCommand komut = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataTable dt = new DataTable();

        public Kitap()
        {
            InitializeComponent();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.Show();
            this.Close();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kitap_Load(object sender, EventArgs e)
        {

            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            komut = new OracleCommand("Select * from KITAP K INNER JOIN DURUM D ON K.DURUMID=D.DURUMID", baglanti.baglan);
            da = new OracleDataAdapter();
            dt = new DataTable();
            da.SelectCommand = komut;
            da.Fill(dt);
            gridKitap.DataSource = dt;
            GridDuzenle();
            // **************************************** KİTAP GRİDİNİ DOLDURMA SONU
            komut = new OracleCommand("select AD from DURUM", baglanti.baglan);
            OracleDataReader dr = komut.ExecuteReader();
            comboDurum.Items.Add("TÜMÜ");
            while (dr.Read())
            {
                comboDurum.Items.Add(dr["AD"]);
            }
            // ****************************************** KİTAP DURUMU DOLDURMA SONU 
        }

        public void GridDuzenle()
        {
            gridKitap.Columns[1].HeaderText = "Kitap Adı";
            gridKitap.Columns[1].Width = 200;
            gridKitap.Columns[2].HeaderText = "Yazarı";
            gridKitap.Columns[2].Width = 150;
            gridKitap.Columns[3].HeaderText = "Sayfa Sayısı";
            gridKitap.Columns[4].HeaderText = "Yayın Evi";
            gridKitap.Columns[5].HeaderText = "Türü";
            gridKitap.Columns[8].HeaderText = "Durum Bilgisi";
            gridKitap.Columns[8].Name = "Durum";
            gridKitap.Columns[0].Visible = false;
            gridKitap.Columns[6].Visible = false;
            gridKitap.Columns[7].Visible = false;

            for (int i = 0; i < gridKitap.Rows.Count; i++)
            {
                Application.DoEvents();
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(gridKitap.Rows[i].Cells["DURUMID"].Value) == 1)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (Convert.ToInt32(gridKitap.Rows[i].Cells["DURUMID"].Value) == 2)
                {
                    renk.BackColor = Color.Red;
                }
                gridKitap.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void txtKitapAd_TextChanged(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            if (txtKitapAd.Text.Trim() == "")
            {
                komut = new OracleCommand("Select * from KITAP K INNER JOIN DURUM D ON K.DURUMID=D.DURUMID", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKitap.DataSource = dt;
                GridDuzenle();
            }
            else
            {
                komut = new OracleCommand("KITAP_GETIR_KITAPAD_PROC", baglanti.baglan);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.Add("P_AD", OracleDbType.Varchar2).Value = txtKitapAd.Text.ToLower();
                komut.Parameters.Add("KITAP_GETIR_KITAPAD_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKitap.DataSource = dt;
                GridDuzenle();
            }
        }

        private void comboDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            if (comboDurum.SelectedItem.ToString() == "TÜMÜ")
            {
                komut = new OracleCommand("Select * from KITAP K INNER JOIN DURUM D ON K.DURUMID=D.DURUMID", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKitap.DataSource = dt;
                GridDuzenle();
            }
            else
            {
                komut = new OracleCommand("Select * from KITAP K INNER JOIN DURUM D ON K.DURUMID=D.DURUMID WHERE D.AD='" + comboDurum.SelectedItem.ToString() + "'", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKitap.DataSource = dt;
                GridDuzenle();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            Microsoft.Office.Interop.Excel.Application Excelver = new Microsoft.Office.Interop.Excel.Application();
            Excelver.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook objBook = Excelver.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet objSheet = (Microsoft.Office.Interop.Excel.Worksheet)objBook.Worksheets.get_Item(1);
            for (int i = 1; i < gridKitap.Columns.Count; i++)
            {
                if (i == 6 || i == 7)
                    continue;
                Microsoft.Office.Interop.Excel.Range objRange = (Microsoft.Office.Interop.Excel.Range)objSheet.Cells[1, i + 1];
                objRange.Value2 = gridKitap.Columns[i].HeaderText;

            }
            for (int i = 1; i < gridKitap.Columns.Count; i++)
            {
                if (i == 6 || i == 7)
                    continue;
                for (int j = 0; j < gridKitap.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range objRange = (Microsoft.Office.Interop.Excel.Range)objSheet.Cells[j + 2, i + 1];
                    objRange.Value2 = gridKitap[i, j].Value;

                }
            }
        }

        private void txtKitapAd_KeyPress(object sender, KeyPressEventArgs e)
        {
      
        }

        private void btnExceldenAktar_Click(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            openFileDialog1.ShowDialog();
            txtUzanti.Text = openFileDialog1.FileName;
            string dosya_yolu = openFileDialog1.FileName;
            OleDbConnection deneme = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;  Data Source = " + dosya_yolu + "; Extended Properties = Excel 12.0");
            deneme.Open();
            string sorgu = "select * from [Kitaplar$] ";
            OleDbDataAdapter data_adaptor = new OleDbDataAdapter(sorgu, deneme);
            deneme.Close();
            DataTable dt = new DataTable();
            data_adaptor.Fill(dt);
            gridKitap.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string cumle = "INSERT INTO KITAP VALUES(KITAP_ID_SEQ.NEXTVAL,'" + gridKitap.Rows[i].Cells["AD"].Value + "','" + gridKitap.Rows[i].Cells["YAZAR"].Value + "'," + gridKitap.Rows[i].Cells["SAYFA_SAYISI"].Value + ",'" + gridKitap.Rows[i].Cells["YAYIN_EVI"].Value + "','" + gridKitap.Rows[i].Cells["TUR"].Value + "',1)";
                OracleCommand komut = new OracleCommand(cumle, baglanti.baglan);
                komut.ExecuteNonQuery();
            }
            MessageBox.Show("Yükleme İşlemi başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Kitap kitap = new Kitap();
            kitap.Show();

        }
    }
}

