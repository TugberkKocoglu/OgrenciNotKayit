using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotKayit
{
    public class DBContext
    {
        public SqlConnection Connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TCALSD6;Initial Catalog=OgrenciNotKayitDB;Integrated Security=True;");
            connect.Open();
            return connect;
        }

    }
}
