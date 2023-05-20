using System;
using System.Data.SqlClient;


namespace POS_SYSTEM_Cecilia_Ukay_Ukay
{
    internal class DB_Connection
    {
        SqlConnection cn = new SqlConnection();


        SqlCommand cmd = new SqlCommand();

        public string MyConnection()
        {
            //Data Source=DESKTOP-STAD1GF\SQLEXPRESS;Initial Catalog=POS_Cecilia;Integrated Security=True
            //// database in velarde
            ///
            string con = "Data Source=COLA\\SQLEXPRESS;Initial Catalog=cecila;Integrated Security=True";
            return con;

            //"Data Source=COLA\\SQLEXPRESS;Initial Catalog=cecila;Integrated Security=True" --dapiton Connection
        }

        public void conDb() { //this functions connect to the db

            try {

                cn.Close();
                cn.ConnectionString = MyConnection(); //this connects the string connection that was created
                cn.Open();

            }
            catch (Exception e) {

                MessageBox.Show("Problem in connection string");
            
            
            }
        
        }

        public void uid(string query) {

            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();




            cn.Close();

        
        
        
        }


    }
}
