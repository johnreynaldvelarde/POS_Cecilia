using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    internal class DB_Connection
    {
        public string MyConnection()
        {
            string con = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=PosSystem;Integrated Security=True"; // database in velarde
            return con;
        }
    }
}
