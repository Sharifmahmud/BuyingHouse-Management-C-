using Entity;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Accounts : Form
    {
        Login l;
        AccountRepo ar;
        Employee emp; //new
        public Accounts(Login l)
        {
            InitializeComponent();
            this.l = l;
            ar = new AccountRepo();
            emp = new Employee(); //new
            Totaltb.Visible = false;
            totallbl.Visible = false;
            Deletebtn.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Accounts_Load(object sender, EventArgs e)
        {

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

       private void HouseRenttb_TextChanged(object sender, EventArgs e)
       {

       }

       private void OnFormClose(object sender, FormClosedEventArgs e)
       {
           Application.Exit();
       }

       private void insertbtnclick(object sender, EventArgs e)
       {
           Account a1 = new Account();
           try
           {
               a1.Month = this.MonthComboBox.Text;
               int year = Convert.ToInt32(this.YearComboBox.Text);
               a1.Year = year;
               a1.Billno = this.BillnoTB.Text;
               int houserent =Convert.ToInt32(this.HouseRenttb.Text);
               a1.Houserent = houserent;
               int emptotalsal = Convert.ToInt32(this.EmpTotalSaltb.Text);
               a1.Emptotalsal = emptotalsal;
              int utilities = Convert.ToInt32(this.Utilitiestb.Text);
               a1.Utilities = utilities;
               a1.Totalamount = a1.Houserent + a1.Utilities+a1.Emptotalsal;

               if(ar.InsertAccount(a1))
               {
                   MessageBox.Show(a1.Month+" "+a1.Year + "'s Bill Stored");
                   this.refreshbtnclick(sender, e);
                   this.viewallbtnclick(sender, e);
               }
               else
               {
                   MessageBox.Show("Can Not Store Bill");

               }
                
           }

           catch (Exception exp)
           {
               MessageBox.Show("Invalid Data");
 
           }
               
           
       }

       private void updatebtnclick(object sender, EventArgs e)
       {
           Account a1 = new Account();
           try
           {
               a1.Month = this.MonthComboBox.Text;
               int year = Convert.ToInt32(this.YearComboBox.Text);
               a1.Year = year;
               a1.Billno = this.BillnoTB.Text;
               int houserent = Convert.ToInt32(this.HouseRenttb.Text);
               a1.Houserent = houserent;
               int emptotalsal = Convert.ToInt32(this.EmpTotalSaltb.Text);
               a1.Emptotalsal = emptotalsal;
               int utilities = Convert.ToInt32(this.Utilitiestb.Text);
               a1.Utilities = utilities;
               a1.Totalamount = a1.Houserent + a1.Utilities + a1.Emptotalsal;

               if (ar.UpdateAccount(a1))
               {
                   MessageBox.Show("Bill Updated");
                   this.refreshbtnclick(sender, e);
                   this.viewallbtnclick(sender, e);
               }

               else
               {
                   MessageBox.Show("Update not Done");
               }
           }
           catch (Exception exp)
           {
               MessageBox.Show("Invalid Data");
           }
           



       }

       private void loadbtnclick(object sender, EventArgs e)
       {
           string billno = BillnoTB.Text;

           Account acc = ar.GetAccount(billno);
           try
           {
               if (billno == null)
               {
                   MessageBox.Show("Invalid Bill No");
                   this.refreshbtnclick(sender, e);
               }
               else
               {
                   this.MonthComboBox.Text = acc.Month;
                   this.YearComboBox.Text = acc.Year + "";
                   this.BillnoTB.Text = acc.Billno;
                   this.HouseRenttb.Text = acc.Houserent + "";
                   this.EmpTotalSaltb.Text = acc.Emptotalsal + "";
                   this.Utilitiestb.Text = acc.Utilities + "";
                   this.Totaltb.Text = acc.Totalamount + "";

                   this.Refreshbtn.Enabled = true;
                   this.Loadbtn.Enabled = false;
                   this.Insertbtn.Enabled = false;
                   this.Updatebtn.Enabled = true;
                   this.Deletebtn.Enabled = true;

                   this.BillnoTB.Enabled = false;

               }

           }
           catch(Exception exp)
           {
               MessageBox.Show("Can not load");
           }

       }

       private void deletebtnclick(object sender, EventArgs e)
       {
           Account a1 = new Account();


           a1.Billno = this.BillnoTB.Text;

           try
           {
               if (ar.DeleteAccount(a1))
               {

                   MessageBox.Show("Bill Removed");
                   this.refreshbtnclick(sender, e);
                   this.viewallbtnclick(sender, e);

               }
               else
               {
                   MessageBox.Show("Can Not Remove");
               }
           }
           catch(Exception exp)
           {
               MessageBox.Show("Invalid Data");
           }

       }

       private void refreshbtnclick(object sender, EventArgs e)
       {
           this.MonthComboBox.Text = "Month";
           this.YearComboBox.Text = "Year";
           this.BillnoTB.Text = "";
           this.HouseRenttb.Text = "";
           this.EmpTotalSaltb.Text = "";
           this.Utilitiestb.Text = "";
           this.Totaltb.Text = "";

           this.Refreshbtn.Enabled = false;
           this.Loadbtn.Enabled = true;
           this.Insertbtn.Enabled = true;
           this.Updatebtn.Enabled = false;
           this.Deletebtn.Enabled = false;

           this.BillnoTB.Enabled = true;
       }

       private void viewallbtnclick(object sender, EventArgs e)
       {
          


       }


       private void SearchTBValueChanged(object sender, EventArgs e)
       {
           List<Account> listofacc = ar.GetAllAccount();
           
           string keyword = searchcosttb.Text.ToLower();
           List<Account> searchedList = listofacc.FindAll(x => ((x.Month.ToLower()).Contains(keyword)) || ((x.Year.ToString()).Contains(keyword)) || ((x.Billno.ToLower()).Contains(keyword)) || ((x.Houserent.ToString()).Contains(keyword)) || ((x.Emptotalsal.ToString()).Contains(keyword)) || ((x.Utilities.ToString()).Contains(keyword)) || ((x.Totalamount.ToString()).Contains(keyword)));
           CostView.DataSource = searchedList;

       }

       private void viewcostbtnclick(object sender, EventArgs e)
       {
           List<Account> listofacc = ar.GetAllAccount();
           this.CostView.DataSource = listofacc;
          

       }

       private void AccCellClick(object sender, DataGridViewCellEventArgs e)
       {
           this.BillnoTB.Text = CostView.Rows[e.RowIndex].Cells[0].Value.ToString();
           this.MonthComboBox.Text = CostView.Rows[e.RowIndex].Cells[1].Value.ToString();
           this.YearComboBox.Text = CostView.Rows[e.RowIndex].Cells[2].Value.ToString();
           this.HouseRenttb.Text = CostView.Rows[e.RowIndex].Cells[3].Value.ToString();
           this.EmpTotalSaltb.Text = CostView.Rows[e.RowIndex].Cells[4].Value.ToString();
           this.Utilitiestb.Text = CostView.Rows[e.RowIndex].Cells[5].Value.ToString();
           this.Totaltb.Text = CostView.Rows[e.RowIndex].Cells[6].Value.ToString();

           

           this.Refreshbtn.Enabled = true;
           this.Loadbtn.Enabled = false;
           this.Insertbtn.Enabled = false;
           this.Updatebtn.Enabled = true;
           this.Deletebtn.Enabled = true;

           this.BillnoTB.Enabled = false;
       }

       private void BillnoTB_TextChanged(object sender, EventArgs e)
       {

       }
    }
}
