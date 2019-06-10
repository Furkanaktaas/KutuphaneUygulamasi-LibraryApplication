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
    public partial class KitapEkle : Form
    {
        Baglanti baglanti = new Baglanti();

        public KitapEkle()
        {
            InitializeComponent();
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            comboTur.Items.Add("Gelişim");
            comboTur.Items.Add("Dini");
            comboTur.Items.Add("Tarih");
            comboTur.Items.Add("Polisiye");

        }

        private void btnKitapGeriDon_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Show();
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKitapAd.Text.Trim()=="" || txtSayfaSayisi.Text.Trim() == "" || txtYayinEvi.Text.Trim() == "" || txtYazar.Text.Trim()=="" || comboTur.SelectedIndex.ToString()=="-1")
            {
                MessageBox.Show("Boş Alan Bırakmadan Doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (baglanti.baglan.State == ConnectionState.Closed)
                {
                    baglanti.baglan.Open();
                }
                OracleCommand komut = new OracleCommand("insert into Kitap values(KITAP_ID_SEQ.NEXTVAL,'" + txtKitapAd.Text.ToLower() + "','" + txtYazar.Text.ToLower() + "'," + txtSayfaSayisi.Text + ",'" + txtYayinEvi.Text.ToLower() + "','" + comboTur.SelectedItem.ToString().ToLower() + "',1)", baglanti.baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("KAYIT BAŞARI İLE TAMAMLANDI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                KitapEkle kitapEkle = new KitapEkle();
                kitapEkle.Show();
            }
           
        }

        private void txtYazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void txtSayfaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
