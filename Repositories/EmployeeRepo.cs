using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entity;
using System.Data.SqlClient;

namespace Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
         DatabaseConnectionClass dcc;

        public EmployeeRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public bool InsertEmployee(Employee emp)
        {
            string query = "INSERT into ManageEmployees VALUES('" + emp.EmpId + "', '" + emp.Name+ "', '"+emp.PhnNumber+"','"+emp.Email+"', "+emp.Salary+", '"+emp.Designation+"')";
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

        public bool DeleteEmployee(Employee emp)
        {
            string query = "DELETE from ManageEmployees WHERE EmpId = '" + emp.EmpId + "'";
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

        public bool UpdateEmployee(Employee emp)
        {
            string query = "UPDATE ManageEmployees SET  EmpName = '" + emp.Name + "', EmpPhoneNo = '" + emp.PhnNumber + "', Email='" + emp.Email + "',Salary = " + emp.Salary + ", Designation = '" + emp.Designation + "' WHERE EmpId = '" + emp.EmpId + "'";
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

        public Employee GetEmployee(string empId)
        {
            Employee emp = null;
            string query = "SELECT * from ManageEmployees WHERE EmpId = '" + empId + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr =  dcc.GetData(query);

            while (sdr.Read())
            {
                emp = new Employee();
                emp.EmpId = sdr["EmpId"].ToString();
                emp.Name = sdr["EmpName"].ToString();
                emp.PhnNumber = sdr["EmpPhoneNo"].ToString();
                emp.Email = sdr["Email"].ToString();
                emp.Salary = Convert.ToDouble(sdr["Salary"]);
                emp.Designation = sdr["Designation"].ToString();
            }
            dcc.CloseConnection();
            return emp;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> listOfEmployee = new List<Employee>();
            string query = "SELECT * FROM ManageEmployees";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Employee emp = new Employee();
                emp.EmpId = sdr["EmpId"].ToString();
                emp.Name = sdr["EmpName"].ToString();
                emp.PhnNumber = sdr["EmpPhoneNo"].ToString();
                emp.Email = sdr["Email"].ToString();
                emp.Salary = Convert.ToDouble(sdr["Salary"]); //can not convert to int
                emp.Designation = sdr["Designation"].ToString();
                listOfEmployee.Add(emp);
            }
            dcc.CloseConnection();

            return listOfEmployee;
        }
    }



   
}
