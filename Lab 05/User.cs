using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    public class User
    {
        public int balance;

        public void addBalance(int n, int price)
        {
            balance = balance + (n * price);
        }

        public string getBalance()
        {
            return Convert.ToString(balance);
        }
    }
}
