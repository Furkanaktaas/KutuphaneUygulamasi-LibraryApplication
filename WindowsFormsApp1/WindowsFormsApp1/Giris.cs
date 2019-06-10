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
    public partial class Giris : Form
    {
        Baglanti baglanti = new Baglanti();
        OracleCommand komut = new OracleCommand();
        KullaniciBilgileri kullaniciBilgileri = new KullaniciBilgileri();

        public Giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (baglanti.baglan.State == ConnectionState.Closed)
            {
                baglanti.baglan.Open();
            }
            komut = new OracleCommand("SELECT * from KULLANICI WHERE EPOSTA ='" + txtKullaniciAd.Text.ToLower() + "' and SIFRE = '" + txtKullaniciSifre.Text + "' ", baglanti.baglan);
            OracleDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["YETKIID"].ToString() == "1")
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                    kullaniciBilgileri.Bilgiler(dr);
                }
                else if (dr["YETKIID"].ToString() == "2")
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                    kullaniciBilgileri.Bilgiler(dr);
                }
                else
                {
                    MessageBox.Show("Kullanıcı Yetkisi Giriş İçin Yetersiz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (baglanti.baglan.State == ConnectionState.Open)
            {
                baglanti.baglan.Close();
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            txtKullaniciAd.Text = "furkan@gmail.com";
            txtKullaniciSifre.Text = "12345";
        }
    }
}
