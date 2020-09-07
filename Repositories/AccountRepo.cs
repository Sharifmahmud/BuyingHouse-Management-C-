using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using Interfaces;

namespace Repositories
{
    public class AccountRepo : IAccountRepo
    {
        DatabaseConnectionClass dcc;

        public AccountRepo() { dcc = new DatabaseConnectionClass(); }

        public bool InsertAccount(Account acc)
        {

            string query = "INSERT into Accounts VALUES('"+acc.Billno+"','" + acc.Month + "', " + acc.Year + ", " + acc.Houserent + "," + acc.Emptotalsal + " ," + acc.Utilities + "," + acc.Totalamount + ")";
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

        public bool DeleteAccount(Account acc)
        {
            string query = "DELETE from Accounts WHERE BillNo = '" + acc.Billno + " '";
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

        public bool UpdateAccount(Account acc)
        {
            string query = "UPDATE Accounts SET Month='" + acc.Month + "',Year =" + acc.Year + ", HouseRent=" + acc.Houserent + ",EmpTotalSal=" + acc.Emptotalsal + " ,Utilities=" + acc.Utilities + ",TotalAmount=" + acc.Totalamount + " WHERE BillNo='" + acc.Billno + "'";
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

        public Account GetAccount(string billno)
        {
           Account acc = null;
           string query = "SELECT * from Accounts WHERE BillNo = '" + billno + " '";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                acc = new Account();
                acc.Billno = sdr["BillNo"].ToString();
                acc.Month = sdr["Month"].ToString();
                acc.Year = Convert.ToInt32(sdr["Year"]);
                acc.Houserent = Convert.ToInt32(sdr["HouseRent"]);
                acc.Emptotalsal = Convert.ToInt32(sdr["EmpTotalSal"]);
                acc.Utilities = Convert.ToInt32(sdr["Utilities"]);
                acc.Totalamount = Convert.ToInt32(sdr["TotalAmount"]);
            }
            dcc.CloseConnection();
            return acc;
        }
        public List<Account> GetAllAccount()
        {
            List<Account> listOfAccount = new List<Account>();
            string query = "SELECT * FROM Accounts";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Account acc = new Account();
                acc.Billno = sdr["BillNo"].ToString();
                acc.Month = sdr["Month"].ToString();
                acc.Year = Convert.ToInt32(sdr["Year"]);
                acc.Houserent = Convert.ToInt32(sdr["HouseRent"]);
                acc.Emptotalsal = Convert.ToInt32(sdr["EmpTotalSal"]);
                acc.Utilities = Convert.ToInt32(sdr["Utilities"]);
                acc.Totalamount = Convert.ToInt32(sdr["TotalAmount"]);
                listOfAccount.Add(acc);


                

            }

            dcc.CloseConnection();

            return listOfAccount;
        

       }
    }
}
