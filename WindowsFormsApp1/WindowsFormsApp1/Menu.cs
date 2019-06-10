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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnKullanıcı_Click(object sender, EventArgs e)
        {
            Kulllanici kulllanici = new Kulllanici();
            kulllanici.Show();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnYedek_Click(object sender, EventArgs e)
        {
            Yedek yedek = new Yedek();
            yedek.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }

        private void btnSilinmis_Click(object sender, EventArgs e)
        {
            Silinmis silinmis = new Silinmis();
            silinmis.Show();
        }

        private void btnEmanetVerme_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet();
            emanet.Show();
        }

        private void btnTeslimAlma_Click(object sender, EventArgs e)
        {
            TeslimAlma teslimAlma = new TeslimAlma();
            teslimAlma.Show();
        }

        private void btnHesapBilgileri_Click(object sender, EventArgs e)
        {
            HesapBilgileri hesapBilgileri = new HesapBilgileri();
            hesapBilgileri.Show();
        }
    }
}
