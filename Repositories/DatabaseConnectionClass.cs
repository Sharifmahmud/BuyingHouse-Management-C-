using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DatabaseConnectionClass
    {
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        public DatabaseConnectionClass()
        {
            string connectionString = @"Data Source=DESKTOP-LK29PPH\SQLEXPRESS;Initial Catalog=88232C74EB23C65A8286E7F163C9F13D_ FINAL -WORKING NOW\C# PROJECT(3)\BUYINGHOUSEMANAGEMENTSYSTEM\BUYINGHOUSEMANAGEMENTSYSTEMDB.MDF;Integrated Security=True;Connect Timeout=30";
            myConnection = new SqlConnection(connectionString);
        }

        public void ConnectWithDB()
        {
         
                myConnection.Open();
            
            
        }
        public void CloseConnection()
        {
            myConnection.Close();
        }

        public SqlDataReader GetData(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            //SqlDataReader sdr = myCommand.ExecuteReader();
            //return sdr;
            return myCommand.ExecuteReader();
        }
        public int ExecuteSQL(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            //int x= myCommand.ExecuteNonQuery();
            //return x;
            return myCommand.ExecuteNonQuery();
        }
    }
}
