using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories;


namespace App
{
    public partial class ManageEmployees : Form
    {
        Login l;
        EmployeeRepo er;
        LoginRepo lr;
        
        
        public ManageEmployees(Login l)
        {
            InitializeComponent();
            this.l = l;
            er = new EmployeeRepo();
            lr = new LoginRepo();
            DeleteBtn.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumTb_TextChanged(object sender, EventArgs e)
        {

        } 
        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutbtnclick(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Visible = false;
            lf.Visible = true;
        }

        private void backbtnclick(object sender, EventArgs e)
        {
            ManagementForm mf = new ManagementForm(l);
            this.Visible = false;
            mf.Visible = true;
        }

        private void Insertbtnclick(object sender, EventArgs e)
        {
            Login l = new Login();
            Employee emp = new Employee();
            int p = new Random().Next(99999999) + 10000000;
            try
            {
                l.UserName = this.EmpIdTb.Text;
                l.Password = p + " ";

                emp.EmpId = this.EmpIdTb.Text;
                emp.Name = this.EmpNameTb.Text;
                int phn = Convert.ToInt32(this.PhoneNumberTb2.Text);
                emp.PhnNumber = this.PhoneNumberTb1.Text + this.PhoneNumberTb2.Text;
                emp.Designation = this.EmailTb.Text;
                double sal = Convert.ToDouble(this.EmpSalTb.Text);
                emp.Salary = sal;
                emp.Designation = this.DesignationTb.Text;
                emp.Email = this.EmailTb.Text;

                if ((emp.Designation.ToLower()).Equals("owner"))
                {
                    l.Role = 0;
                }
                else if ((emp.Designation.ToLower()).Equals("accountant"))
                {
                    l.Role = 1;
                }
                else if ((emp.Designation.ToLower()).Equals("manager"))
                {
                    l.Role = 2;
                }
                else
                {
                    l.Role = 3;
                }


                if (lr.InsertUser(l))
                {
                    if (er.InsertEmployee(emp))
                    {
                        MessageBox.Show(emp.Name +" Added"+ Environment.NewLine+ " Id : " + emp.EmpId + " & Password : " + l.Password);
                        this.refreshbtnclick(sender, e);
                        this.viewallbtnclick(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Can Not Add " + l.UserName);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data");
            }

        }

        private void updatebtnclick(object sender, EventArgs e)
        {
            try
            {

                Employee emp = new Employee();
                emp.EmpId = this.EmpIdTb.Text;
                emp.Name = this.EmpNameTb.Text;
                emp.PhnNumber = this.PhoneNumberTb1.Text + this.PhoneNumberTb2.Text;
                double sal = Convert.ToDouble(this.EmpSalTb.Text);
                emp.Salary = sal;
                emp.Email = this.EmailTb.Text;
                emp.Designation = this.DesignationTb.Text;

                if (er.UpdateEmployee(emp))
                {
                    MessageBox.Show("Update Done");
                    this.refreshbtnclick(sender, e);
                    this.viewallbtnclick(sender, e);
                }
                else
                {
                    MessageBox.Show("Update NOT Done");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Information");
            }

        }

        private void deletebtnclick(object sender, EventArgs e)
        {
            Login l = new Login();
            l.UserName = this.EmpIdTb.Text;
            Employee emp = new Employee();
            emp.EmpId = this.EmpIdTb.Text;

           
            if (lr.DeleteUser(l))
                {
                    if (er.DeleteEmployee(emp))
                    {
                        MessageBox.Show(emp.Name + " Deleted");
                        this.refreshbtnclick(sender, e);
                        this.viewallbtnclick(sender, e);
                    }
                }
            else 
                {
                    MessageBox.Show("Can Not Delete");
                }
            
        }

        private void loadbtnclick(object sender, EventArgs e)
        {
             string empId = EmpIdTb.Text;
           
            Employee emp = er.GetEmployee(empId);

            if (emp == null)
            {
                MessageBox.Show("Invalid Id");
                this.refreshbtnclick(sender, e);
            }
            else
            {
                this.EmpNameTb.Text = emp.Name;
                this.PhoneNumberTb2.Text = emp.PhnNumber.Substring(4);
                this.EmpSalTb.Text = emp.Salary + "";
                this.EmailTb.Text = emp.Email;
                this.DesignationTb.Text = emp.Designation;

                this.RefreshBtn.Enabled = true;
                this.LoadBtn.Enabled = false;
                this.InsetBtn.Enabled = false;
                this.UpdateBtn.Enabled = true;
                this.DeleteBtn.Enabled = true;

                this.EmpIdTb.Enabled = false;
            }

        }

        private void refreshbtnclick(object sender, EventArgs e)
        {
            this.EmpIdTb.Text = "";
            this.EmpNameTb.Text = "";
            this.PhoneNumberTb2.Text = "";
            this.EmailTb.Text = "";
            this.EmpSalTb.Text = "";
            this.DesignationTb.Text = "";

            this.RefreshBtn.Enabled = false;
            this.LoadBtn.Enabled = true;
            this.InsetBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;

            this.EmpIdTb.Enabled = true;
        }

        private void viewallbtnclick(object sender, EventArgs e)
        {
            List<Employee> listOfEmployee = er.GetAllEmployees();
            this.EmpTable.DataSource = listOfEmployee;
        }

        private void SearchTBValueChanged(object sender, EventArgs e)
        {
            List<Employee> listOfEmployee = er.GetAllEmployees();
            string keyword = SearchBox.Text.ToLower();
            List<Employee> searchedList = listOfEmployee.FindAll(x => ((x.EmpId.ToLower()).Contains(keyword)) || ((x.Name.ToLower()).Contains(keyword)) || ((x.PhnNumber.ToLower()).Contains(keyword)) || ((x.Designation.ToLower()).Contains(keyword)));

            EmpTable.DataSource = searchedList;

        }

        private void EmpCellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EmpIdTb.Text = EmpTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.EmpNameTb.Text = EmpTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.PhoneNumberTb2.Text = (EmpTable.Rows[e.RowIndex].Cells[2].Value.ToString()).Substring(4);
            this.EmailTb.Text = EmpTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.EmpSalTb.Text = EmpTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.DesignationTb.Text = EmpTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            

            this.RefreshBtn.Enabled = true;
            this.LoadBtn.Enabled = false;
            this.InsetBtn.Enabled = false;
            this.UpdateBtn.Enabled = true;
            this.DeleteBtn.Enabled = true;

            this.EmpIdTb.Enabled = false;
        }

        private void EmpIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
