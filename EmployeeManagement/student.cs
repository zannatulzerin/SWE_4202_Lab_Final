using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class student
    {
        public int id;
        public string name;
        public string semester;
        public string department;

        public string getInfo()
        {
        string studentInfo = id.ToString() + "\t" + name + "\t" + semester + "\t" + department;
        return studentInfo;
    }
}
