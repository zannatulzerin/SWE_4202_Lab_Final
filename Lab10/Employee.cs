using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Employee
    {
        public int id;
        public string name;
        public string email;
        public string address;
        public string phone_number;
        public string salary;
        public string hiring_date;

        public Employee(string empid,string name,string email,string phone_number,string address,string salary)
        {
            this.name = name;
            this.email = email;
            this.phone_number = phone_number;
            this.address = address;
            this.salary = salary;

        }
        public Employee()
        {
            List<string> information = new List<string>();
        }
    }
}
