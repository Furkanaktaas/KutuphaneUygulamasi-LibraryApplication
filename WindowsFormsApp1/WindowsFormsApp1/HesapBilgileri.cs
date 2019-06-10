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
    public partial class HesapBilgileri : Form
    {
        KullaniciBilgileri KullaniciBilgileri = new KullaniciBilgileri();
        Baglanti baglanti = new Baglanti();
        public HesapBilgileri()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HesapBilgileri_Load(object sender, EventArgs e)
        {
            txtAd.Text = KullaniciBilgileri.ad;
            txtAdres.Text = KullaniciBilgileri.adres;
            txtEmail.Text = KullaniciBilgileri.eposta;
            txtSoyad.Text = KullaniciBilgileri.soyad;
            txtTelefon.Text = KullaniciBilgileri.telefon;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtSifre.Text.Trim()=="")
            {
                MessageBox.Show("Şifre Alanı Boş Geçilemez", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (baglanti.baglan.State == ConnectionState.Closed)
                {
                    baglanti.baglan.Open();
                }
                OracleCommand komut = new OracleCommand("update KULLANICI set SIFRE ='"+txtSifre.Text+"' where KULLANICIID = "+KullaniciBilgileri.kullaniciID+"  ",baglanti.baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("Şifre Başarı İle Değiştirildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSifre.Text = "";
            }
        }
    }
}
