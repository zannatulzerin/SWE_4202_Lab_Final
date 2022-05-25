using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05
{
    List<Medicine> Medicines = new List<Medicine>();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = MedNameTextBox.Text;
            int amount = Convert.ToInt32(AmountTextBox.Text);
            int price = Convert.ToInt32(PriceTextBox.Text);
            string userID = UserIDTextBox.Text;

            Medicine medicine = new Medicine();
            medicine.name = name;
            medicine.amount = amount;
            medicine.price = price;

            Medicines.Add(medicine);

        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            string id = UserID1TextBox.Text;
            string name = MedName1TextBox.Text;
            int amount = Convert.ToInt32(Amount1TextBox.Text);
            int price = Convert.ToInt32(TotalpriceTextBox.Text);

            for(int i = 0; i < Medicines.Count; i++)
            {
                if(id == Medicine[i].ID)
                {
                    if(amount >= Medicine[i].Amount)
                    {

                    }

                }
            }
        }
    }
}
