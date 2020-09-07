using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepo : IOrderRepo
    {
        
        DatabaseConnectionClass dcc;

        public OrderRepo() { dcc = new DatabaseConnectionClass(); }

        public bool InsertOrder(Order ord)
        {

            string query = "INSERT into Orders VALUES('"+ord.Clientname+"','" + ord.Orderno + "', '" +ord.Ordertype  + "', " +ord.Quantity + "," +ord.Cost + " ,'"+ord.Clientemail+"','" + ord.Clientnum + "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }

        }

        public bool DeleteOrder(Order ord)
        {
            string query = "DELETE from Orders WHERE OrderNo = '" + ord.Orderno + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }

        public bool UpdateOrder(Order ord)
        {
            string query = "UPDATE Orders SET ClientName='" + ord.Clientname + "',OrderType='" + ord.Ordertype + "' , Quantity=" + ord.Quantity + ", Cost=" + ord.Cost + ", ClientEmail='"+ord.Clientemail+"' ,ClientNumber='" + ord.Clientnum + "' WHERE OrderNo = '" + ord.Orderno + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }

        public Order GetOrder(string orderno)
        {
           Order ord = null;
           string query = "SELECT * from Orders WHERE OrderNo = '" + orderno + "' ";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                ord = new Order();
                ord.Clientname = sdr["ClientName"].ToString();
                ord.Orderno =sdr["OrderNo"].ToString();
                ord.Ordertype = sdr["OrderType"].ToString();
                ord.Quantity = Convert.ToInt32(sdr["Quantity"]);
                ord.Cost = Convert.ToInt32(sdr["Cost"]);
                ord.Clientemail = sdr["ClientEmail"].ToString();
                ord.Clientnum = sdr["ClientNumber"].ToString();
                
                
            }
            dcc.CloseConnection();
            return ord;
        }

        public List<Order> GetAllOrder()
        {
            List<Order> listOfOrder = new List<Order>();
            string query = "SELECT * FROM Orders";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Order ord = new Order();
                ord.Clientname = sdr["ClientName"].ToString();
                ord.Orderno = sdr["OrderNo"].ToString();
                ord.Ordertype = sdr["OrderType"].ToString();
                ord.Quantity = Convert.ToInt32(sdr["Quantity"]);
                ord.Cost = Convert.ToInt32(sdr["Cost"]);
                ord.Clientemail = sdr["ClientEmail"].ToString();
                ord.Clientnum = sdr["ClientNumber"].ToString();

                listOfOrder.Add(ord);
            }
            dcc.CloseConnection();

            return listOfOrder;
        }

       
    }

}
