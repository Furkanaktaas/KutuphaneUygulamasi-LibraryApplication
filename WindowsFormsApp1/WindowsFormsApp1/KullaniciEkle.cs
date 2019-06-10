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
    public partial class KullaniciEkle : Form
    {
        OracleCommand komut = new OracleCommand();
        Baglanti baglanti = new Baglanti();

        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            komut = new OracleCommand("select * from YETKI", baglanti.baglan);
            OracleDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboYetki.Items.Add(dr["AD"]);
            }
            if (KullaniciBilgileri.yetkiID == "2")
            {
                comboYetki.Items.Remove("ADMIN");
                comboYetki.Items.Remove("PERSONEL");
            }
            // ************************** COMBO YETKI DOLDURMA SON
            lblOgrenciUyari.Text = "Bu Bölüm Sadece \n  Öğrenci İçin Doldurulacaktır.";
            PasifYapma();
            comboBolum.Items.Add("Bilgisayar Mühendisliği");
            comboBolum.Items.Add("Elektrik-Elektronik Mühendisliği");
            comboBolum.Items.Add("İnşaat Mühendisliği");
        }

        private void btnKullaniciGeriDon_Click(object sender, EventArgs e)
        {
            Kulllanici kulllanici = new Kulllanici();
            kulllanici.Show();
            this.Hide();
        }

        private void comboYetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboYetki.SelectedItem.ToString() == "OGRENCI")
            {
                txtSifre.Enabled = false;
                txtDonem.Enabled = true;
                txtOkulAd.Enabled = true;
                txtOkulNo.Enabled = true;
                txtDonem.Enabled = true;
                comboBolum.Visible = true;
            }
            else if (comboYetki.SelectedItem.ToString() == "UYE")
            {
                txtSifre.Enabled = false;
                PasifYapma();
            }
            else
            {
                txtSifre.Enabled = true;
                PasifYapma();
            }
        }

        public void PasifYapma()
        {
            txtDonem.Enabled = false;
            txtOkulAd.Enabled = false;
            txtOkulNo.Enabled = false;
            txtDonem.Enabled = false;
            comboBolum.Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() == "" || txtSoyad.Text.Trim() == "" || txtEposta.Text.Trim() == "" || txtAdres.Text.Trim() == "" || txtTelefon.Text.Trim() == "")
            {
                MessageBox.Show("Boş Alan Bırakmadan Doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int yetkiID;
                if (KullaniciBilgileri.yetkiID == "1")
                    yetkiID = Convert.ToInt32(comboYetki.SelectedIndex.ToString()) + 1;
                else
                    yetkiID = Convert.ToInt32(comboYetki.SelectedIndex.ToString()) + 3;
                komut = new OracleCommand("KUL_INS_PROC", baglanti.baglan);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.Add("P_AD", OracleDbType.Varchar2).Value = txtAd.Text.ToLower();
                komut.Parameters.Add("P_SOYAD", OracleDbType.Varchar2).Value = txtSoyad.Text.ToLower();
                komut.Parameters.Add("P_EPOSTA", OracleDbType.Varchar2).Value = txtEposta.Text.ToLower();
                komut.Parameters.Add("P_ADRES", OracleDbType.Varchar2).Value = txtAdres.Text.ToLower();
                if (yetkiID == 3 || yetkiID == 4)
                {
                    komut.Parameters.Add("P_SIFRE", OracleDbType.Varchar2).Value = null;
                }
                else
                {
                    komut.Parameters.Add("P_SIFRE", OracleDbType.Varchar2).Value = txtSifre.Text;
                }
                komut.Parameters.Add("P_TELEFON", OracleDbType.Decimal).Value = txtTelefon.Text;
                komut.Parameters.Add("P_YETKIID", OracleDbType.Decimal).Value = yetkiID;
                if (yetkiID == 3)
                {
                    komut.Parameters.Add("P_OKULAD", OracleDbType.Varchar2).Value = txtOkulAd.Text.ToLower();
                    komut.Parameters.Add("P_OKULNO", OracleDbType.Decimal).Value = txtOkulNo.Text;
                    komut.Parameters.Add("P_BOLUMAD", OracleDbType.Varchar2).Value = comboBolum.SelectedItem.ToString().ToLower() ;
                    komut.Parameters.Add("P_DONEMNO", OracleDbType.Decimal).Value = txtDonem.Text;
                }
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Ekleme İşlemi Başarılı", "BAŞARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                KullaniciEkle kullaniciEkle = new KullaniciEkle();
                kullaniciEkle.Show();
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOkulNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDonem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
