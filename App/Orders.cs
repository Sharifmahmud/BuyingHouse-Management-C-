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
   

    public partial class Orders : Form
    {
        Login l;
        //Order o1;
        OrderRepo or;
        Employee emp;
       


        public Orders(Login l)
        {
            InitializeComponent();
            this.l = l;
            emp = new Employee();
            or = new OrderRepo();
            DeleteBtn.Enabled = false;
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClientNumberTb1_TextChanged(object sender, EventArgs e)
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
            try
            {
                this.Visible = false;
                mf.Visible = true;
            }
            catch (Exception exp)
            { }
        }

        private void insertbtnclick(object sender, EventArgs e)
        {
            Order o1 = new Order();
            try
            {
                o1.Clientname = this.clientnametb.Text;
                o1.Orderno = this.OrderNoTb.Text;
                o1.Ordertype = this.OrderTypeTb.Text;
                int quantity = Convert.ToInt32(this.QualityTb.Text);
                o1.Quantity = quantity;
                double cost = Convert.ToDouble(this.CostTb.Text);
                o1.Cost = cost;
                o1.Clientemail = this.clientemailtb.Text;
                o1.Clientnum = this.ClientNumberTb1.Text + this.ClientNumberTb2.Text;


                if (or.InsertOrder(o1))
                {

                    MessageBox.Show(o1.Clientname + "'s order Placed");
                    this.refreshbtnclick(sender, e);
                    this.viewallbtnclick(sender, e);


                }
                else
                {
                    MessageBox.Show("Can Not Place Order");
                    
                }



            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data");
            }

        }
        

        private void updatebtnclick(object sender, EventArgs e)
        {
            Order ord = new Order();
            try
            {
                ord.Clientname = this.clientnametb.Text;
                ord.Orderno = this.OrderNoTb.Text;
                ord.Ordertype = this.OrderTypeTb.Text;
                int quantity = Convert.ToInt32(this.QualityTb.Text);
                ord.Quantity = quantity;
                double cost = Convert.ToDouble(this.CostTb.Text);
                ord.Cost = cost;
                ord.Clientemail = this.clientemailtb.Text;
                ord.Clientnum = this.ClientNumberTb1.Text + this.ClientNumberTb2.Text;

                if (or.UpdateOrder(ord))
                {

                    MessageBox.Show(ord.Orderno + "'s Order Updated");
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

        private void deletebtnclick(object sender, EventArgs e)
        {
            Order o1 = new Order();
            

            o1.Orderno = this.OrderNoTb.Text;
           

            if (or.DeleteOrder(o1))
            {
                
                    MessageBox.Show("Order Removed");
                    this.refreshbtnclick(sender, e);
                    this.viewallbtnclick(sender, e);
                
            }
            else
            {
                MessageBox.Show("Can Not Delete");
            }
        }

        private void loadbtnclick(object sender, EventArgs e)
        {
            string orderno = OrderNoTb.Text;

            Order ord = or.GetOrder(orderno);
            try
            {
                if (ord == null)
                {
                    MessageBox.Show("Invalid Data");
                    this.refreshbtnclick(sender, e);
                }
                else
                {
                    this.clientnametb.Text = ord.Clientname;
                    this.OrderNoTb.Text = ord.Orderno;
                    this.OrderTypeTb.Text = ord.Ordertype;
                    this.QualityTb.Text = ord.Quantity + "";
                    this.CostTb.Text = ord.Cost + "";
                    this.clientemailtb.Text = ord.Clientemail;
                    this.ClientNumberTb2.Text = ord.Clientnum.Substring(4);


                    this.RefreshBtn.Enabled = true;
                    this.LoadBtn.Enabled = false;
                    this.InsertBtn.Enabled = false;
                    this.UpdateBtn.Enabled = true;
                    this.DeleteBtn.Enabled = true;

                    this.OrderNoTb.Enabled = false;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Can not load");
            }
                


        }

        private void refreshbtnclick(object sender, EventArgs e)
        {
            this.clientnametb.Text = "";
            this.OrderNoTb.Text = "";
            this.OrderTypeTb.Text = "";
            this.QualityTb.Text = "";
            this.CostTb.Text = "";
            this.clientemailtb.Text = "";
            this.ClientNumberTb2.Text = "";
           

            this.RefreshBtn.Enabled = false;
            this.LoadBtn.Enabled = true;
            this.InsertBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;

            this.OrderNoTb.Enabled = true;
        }

        private void viewallbtnclick(object sender, EventArgs e)
        {

            List<Order> listOfOrder = or.GetAllOrder();
            this.OrderTable.DataSource = listOfOrder;

        }


        private void SearchTBValueChanged(object sender, EventArgs e)
        {
           

        }

        private void OrderNoTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchtbchange(object sender, EventArgs e)
        {
            List<Order> listOfOrder = or.GetAllOrder();
            string keyword = SearchTb.Text.ToLower();
            List<Order> searchedList = listOfOrder.FindAll(x => ((x.Clientname.ToLower()).Contains(keyword)) || ((x.Orderno.ToLower()).Contains(keyword)) || ((x.Ordertype.ToLower()).Contains(keyword)) || ((x.Quantity.ToString()).Contains(keyword)) || ((x.Cost.ToString()).Contains(keyword)) || ((x.Clientemail.ToString()).Contains(keyword)) || ((x.Clientnum.ToString()).Contains(keyword)));

            OrderTable.DataSource = searchedList;

        }

        private void OrderCellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clientnametb.Text = OrderTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.OrderNoTb.Text = OrderTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.OrderTypeTb.Text = OrderTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.QualityTb.Text = OrderTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.CostTb.Text = OrderTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.clientemailtb.Text = OrderTable.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.ClientNumberTb2.Text = (OrderTable.Rows[e.RowIndex].Cells[5].Value.ToString()).Substring(4);
            
            

            this.RefreshBtn.Enabled = true;
            this.LoadBtn.Enabled = false;
            this.InsertBtn.Enabled = false;
            this.UpdateBtn.Enabled = true;
            this.DeleteBtn.Enabled = true;

            this.OrderNoTb.Enabled = false;
        }
    }
}
