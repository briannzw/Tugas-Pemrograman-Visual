using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Tugas_Program_Kasir___Pertemuan_7
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = LAPTOP-VSQVNNEU; initial catalog=Kasir; integrated security = true";
            return Conn;
        }
    }
}
