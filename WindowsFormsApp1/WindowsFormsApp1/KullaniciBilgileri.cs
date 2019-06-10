using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class KullaniciBilgileri
    {
        
        public static string ad, soyad, eposta, adres, kullaniciID, telefon,yetkiID;

        public void Bilgiler(OracleDataReader dr)
        {
            kullaniciID =dr["KULLANICIID"].ToString();
            ad = dr["AD"].ToString();
            soyad = dr["SOYAD"].ToString();
            eposta = dr["EPOSTA"].ToString();
            adres = dr["ADRES"].ToString();
            yetkiID = dr["YETKIID"].ToString();
            telefon = dr["TELEFON"].ToString();
        }
    }
}
