using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hastane_Otomasyon_Uygulaması
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-B4REV5U;Initial Catalog=Hastane_Otomasyonu_Veritabanı;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
