using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class Kulllanici : Form
    {
        Baglanti baglanti = new Baglanti();
        OracleCommand komut = new OracleCommand();
        DataTable dt = new DataTable();
        OracleDataAdapter da = new OracleDataAdapter();


        public Kulllanici()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle kullaniciEkle = new KullaniciEkle();
            kullaniciEkle.Show();
            this.Close();
        }

        private void Kulllanici_Load(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            komut = new OracleCommand("select * from KULLANICI k INNER JOIN YETKI Y ON K.YETKIID = Y.YETKIID ", baglanti.baglan);
            da.SelectCommand = komut;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridKullanici.DataSource = dt;
            GridDuzenle();

            // ************************ GRİD DOLDURMA SONU 
            komut = new OracleCommand("select AD from YETKI", baglanti.baglan);
            OracleDataReader dr = komut.ExecuteReader();
            comboKullaniciTuru.Items.Add("TÜMÜ");
            while (dr.Read())
            {
                comboKullaniciTuru.Items.Add(dr["AD"]);
            }
            // ****************************************** COMBO DURUMU DOLDURMA SONU 

        }

        public void GridDuzenle()
        {
            gridKullanici.Columns[0].Visible = false;
            gridKullanici.Columns[5].Visible = false;
            gridKullanici.Columns[7].Visible = false;
            gridKullanici.Columns[8].Visible = false;
            gridKullanici.Columns[9].HeaderText = "YETKİ TÜRÜ";
            gridKullanici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void comboKullaniciTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            if (comboKullaniciTuru.SelectedItem.ToString() == "TÜMÜ")
            {
                komut = new OracleCommand("select * from KULLANICI k INNER JOIN YETKI Y ON K.YETKIID = Y.YETKIID", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKullanici.DataSource = dt;
                GridDuzenle();
            }
            else
            {
                komut = new OracleCommand("select * from KULLANICI k INNER JOIN YETKI Y ON K.YETKIID = Y.YETKIID WHERE Y.AD='" + comboKullaniciTuru.SelectedItem.ToString() + "'", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKullanici.DataSource = dt;
                GridDuzenle();
            }
        }

        private void txtEposta_TextChanged(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            if (txtEposta.Text.Trim() == "")
            {
                komut = new OracleCommand("select * from KULLANICI k INNER JOIN YETKI Y ON K.YETKIID = Y.YETKIID", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKullanici.DataSource = dt;
                GridDuzenle();
            }
            else
            {
                komut = new OracleCommand("KULLANICI_CEK_EPOSTA_PROC", baglanti.baglan);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.Add("P_AD", OracleDbType.Varchar2).Value = txtEposta.Text.ToLower();
                komut.Parameters.Add("KUL_CEK_EPOSTA_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKullanici.DataSource = dt;
                GridDuzenle();
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
                komut = new OracleCommand("select * from KULLANICI k INNER JOIN YETKI Y ON K.YETKIID = Y.YETKIID", baglanti.baglan);
                da = new OracleDataAdapter();
                dt = new DataTable();
                da.SelectCommand = komut;
                da.Fill(dt);
                gridKullanici.DataSource = dt;
                GridDuzenle();
            }
            else
            {
                string[] parcalar = txtAdSoyad.Text.ToLower().Split(' ');
                komut = new OracleCommand("KULLANICI_CEK_AD_SOYAD_PROC", baglanti.baglan);
                komut.CommandType = CommandType.StoredProcedure;
                if (parcalar.Length == 1)
                {
                    komut.Parameters.Add("P_AD", OracleDbType.Varchar2).Value = parcalar[0].ToString();
                    komut.Parameters.Add("P_SOYAD", OracleDbType.Varchar2).Value = "BOS";
                }
                else if (parcalar.Length==2)
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
            }
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}

