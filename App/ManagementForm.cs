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

namespace App
{
    public partial class ManagementForm : Form
    {
        Order o2;
        Login l;
        public ManagementForm(Login l)
        {
            InitializeComponent();
            this.l = l;
            welcomelbl.Text += " " + l.UserName;
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {

        }
        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void manageempclick(object sender, EventArgs e)
        {
            if (l.Role == 0)
            {
                ManageEmployees me = new ManageEmployees(l);
                this.Visible = false;
                me.Visible = true;
            }
            else
            {
                MessageBox.Show("You Are Not Allowed To Visit Here");
            }

            
        }

        private void orderclick(object sender, EventArgs e)
        {
            if (l.Role == 0 || l.Role == 2)
            {
                Orders o1 = new Orders(l);
                this.Visible = false;
                o1.Visible = true;
            }
            else
            {
                MessageBox.Show("You Are Not Allowed To Visit Here");
            }

            
        }

        private void Accountsclick(object sender, EventArgs e)
        {
            if (l.Role == 0 || l.Role==1)
            {
                Accounts a1 = new Accounts(l);
                this.Visible = false;
                a1.Visible = true;
            }
            else
            {
                MessageBox.Show("You Are Not Allowed To Visit Here");
            }
            

        }

        private void logoutbtnclick(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Visible = false;
            lf.Visible = true;
        }

    }
}
