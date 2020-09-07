using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employee
    {
        private string empId;

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string phnNumber;

        public string PhnNumber
        {
            get { return phnNumber; }
            set { phnNumber = value; }
        }
                            
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
    }

    
}
