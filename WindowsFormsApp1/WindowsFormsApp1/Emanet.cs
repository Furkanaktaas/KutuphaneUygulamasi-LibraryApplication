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

namespace WindowsFormsApp1
{
    public partial class Emanet : Form
    {
        Baglanti baglanti = new Baglanti();
        OracleCommand komut = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        DataTable dt = new DataTable();
        static string gridKitapID, gridKullaniciID;

        public Emanet()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Emanet_Load(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            komut = new OracleCommand("SELECT * FROM KITAP K INNER JOIN DURUM D ON K.DURUMID=D.DURUMID WHERE K.DURUMID=1", baglanti.baglan);
            da = new OracleDataAdapter();
            dt = new DataTable();
            da.SelectCommand = komut;
            da.Fill(dt);
            gridKitap.DataSource = dt;
            komut = new OracleCommand("SELECT * FROM KULLANICI", baglanti.baglan);
            da = new OracleDataAdapter();
            dt = new DataTable();
            da.SelectCommand = komut;
            da.Fill(dt);
            gridKullanici.DataSource = dt;
            GridDuzenle();
            // **************************** GRİDLERİ DOLDURMA       
            btnEmanetVer.Visible = false;
            panelKitap.Visible = true;
            panelKullanici.Visible = false;
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            if (gridKitap.SelectedRows.Count == 0)
                MessageBox.Show("Lütfen Kitap Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                gridKitapID = gridKitap.CurrentRow.Cells[0].Value.ToString();
                panelKitap.Visible = false;
                panelKullanici.Visible = true;
                btnİleri.Visible = false;
                btnEmanetVer.Visible = true;
            }
        }

        public void GridDuzenle()
        {
            gridKitap.Columns[0].Visible = false;
            gridKitap.Columns[6].Visible = false;
            gridKitap.Columns[7].Visible = false;
            gridKitap.Columns[3].HeaderText = "SAYFA SAYISI";
            gridKitap.Columns[4].HeaderText = "YAYIN EVİ";
            gridKitap.Columns[8].HeaderText = "DURUM";
            gridKullanici.Columns[0].Visible = false;
            gridKullanici.Columns[5].Visible = false;
            gridKullanici.Columns[7].Visible = false;
            gridKitap.ClearSelection();
            gridKullanici.ClearSelection();
            gridKitap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridKullanici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            if (gridKullanici.SelectedRows.Count == 0)
                MessageBox.Show("Lütfen Kullanıcı Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                gridKullaniciID = gridKullanici.CurrentRow.Cells[0].Value.ToString();
                komut = new OracleCommand("insert into ODUNC values(ODUNC_ID_SEQ.NEXTVAL,TO_DATE('" + DateTime.Now.ToShortDateString() + "','DD/MM/YYYY'),NULL," + gridKullaniciID + "," + gridKitapID + ")", baglanti.baglan);
                komut.ExecuteNonQuery();
                komut = new OracleCommand("update KITAP set DURUMID=2 where KITAPID = " + gridKitapID + "", baglanti.baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("Emanet İşlemi Başarı ile Tamamlandı", "BAŞARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Emanet emanet = new Emanet();
                emanet.Show();
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
                komut = new OracleCommand("SELECT * FROM KITAP K INNER JOIN DURUM D ON K.DURUMID=D.DURUMID WHERE K.DURUMID=1", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKitap.DataSource = dt;
                GridDuzenle();
            }
            else
            {
                komut = new OracleCommand("SELECT * FROM KITAP K INNER JOIN DURUM D ON K.DURUMID=D.DURUMID WHERE K.DURUMID=1 and K.AD='" + txtKitapAd.Text.ToLower() + "'", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKitap.DataSource = dt;
                GridDuzenle();
            }
        }

        private void txtKitapAd_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtKullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void btnKullaniciAra_Click(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            if (txtKullanici.Text.Trim() == "")
            {
                komut = new OracleCommand("SELECT * FROM KULLANICI", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKullanici.DataSource = dt;
                GridDuzenle();
            }
            else
            {
                string[] parcalar = txtKullanici.Text.ToLower().Split(' ');
                komut = new OracleCommand("KULLANICI_CEK_AD_SOYAD_PROC", baglanti.baglan);
                komut.CommandType = CommandType.StoredProcedure;
                if (parcalar.Length == 1)
                {
                    komut.Parameters.Add("P_AD", OracleDbType.Varchar2).Value = parcalar[0].ToString();
                    komut.Parameters.Add("P_SOYAD", OracleDbType.Varchar2).Value = "BOS";
                }
                else if (parcalar.Length == 2)
                {
                    komut.Parameters.Add("P_AD", OracleDbType.Varchar2).Value = parcalar[0].ToString();
                    komut.Parameters.Add("P_SOYAD", OracleDbType.Varchar2).Value = parcalar[1].ToString();
                }
                komut.Parameters.Add("KUL_AD_SOYAD_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKullanici.DataSource = dt;
                GridDuzenle();
                gridKullanici.Columns[8].Visible = false;
                gridKullanici.Columns[9].Visible = false;
            }
        }
    }
}
