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
    public partial class Silinmis : Form
    {
        Baglanti baglanti = new Baglanti();
        public Silinmis()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Silinmis_Load(object sender, EventArgs e)
        {
            OracleCommand komut = new OracleCommand("SILINMIS_GETIR_PROC", baglanti.baglan);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add("SIL_GETIR_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataAdapter da = new OracleDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = komut;
            da.Fill(dt);
            gridSilinmis.DataSource = dt;
            GridDuzenle();
        }

        public void GridDuzenle()
        {
            gridSilinmis.Columns[0].Visible = false;
            gridSilinmis.Columns[1].Visible = false;
            gridSilinmis.Columns[4].Visible = false;
            gridSilinmis.Columns[5].Visible = false;
            gridSilinmis.Columns[6].Visible = false;
            gridSilinmis.Columns[11].Visible = false;
            gridSilinmis.Columns[13].Visible = false;
            gridSilinmis.Columns[14].Visible = false;
            gridSilinmis.Columns[20].Visible = false;
            gridSilinmis.Columns[2].HeaderText = "VERİLİŞ TARİHİ";
            gridSilinmis.Columns[3].HeaderText = "DÖNÜŞ TARİHİ";
            gridSilinmis.Columns[15].HeaderText = "KİTAP ADI";
            gridSilinmis.Columns[17].HeaderText = "SAYFA SAYISI";
            gridSilinmis.Columns[18].HeaderText = "YAYIN EVİ";
            gridSilinmis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
        }
    }
}
