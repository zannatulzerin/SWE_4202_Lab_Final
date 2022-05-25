using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class Medicine
    {
        public string name, ID;
        public int amount;
        public double price;
        
        public void sellMedicine(int n)
        {
            amount -= n;
        }

        public string getInfo()
        {
            string info = ID + "\t" + name + "\t" + Convert.ToString(amount);
            return info;
        }

    }
}
