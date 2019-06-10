using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Baglanti
    {
        public OracleConnection baglan;
        public Baglanti()
        {
           baglan = new OracleConnection("DATA SOURCE=DESKTOP-L0GT8MC:1521/xe;PASSWORD=12345;PERSIST SECURITY INFO=True;USER ID=ADAM");
        }
      
    }
}
