using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Account
    {
        private string billno;

        public string Billno
        {
            get { return billno; }
            set { billno = value; }
        }
        
        
        
        
        private string month;

        public string Month
        {
            get { return month; }
            set { month = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private float houserent;

        public float Houserent
        {
            get { return houserent; }
            set { houserent = value; }
        }

        private float emptotalsal;

        public float Emptotalsal
        {
            get { return emptotalsal; }
            set { emptotalsal = value; }
        }

        private float utilities;

        public float Utilities
        {
            get { return utilities; }
            set { utilities = value; }
        }

        private float totalamount;

        public float Totalamount
        {
            get { return totalamount; }
            set { totalamount = value; }
        }




        
    }

}
