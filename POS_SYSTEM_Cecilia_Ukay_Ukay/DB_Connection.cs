﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    internal class DB_Connection
    {
        public string MyConnection()
        {
            //Data Source = LENOVO - PC\SQLEXPRESS; Initial Catalog = POS_Cecilia; Integrated Security = True// database in velarde
            string con = @"Data Source=DESKTOP-STAD1GF\SQLEXPRESS;Initial Catalog=POS_Cecilia;Integrated Security=True"; 
            return con;
           
        }
    }
}
