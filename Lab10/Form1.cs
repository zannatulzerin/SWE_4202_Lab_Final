using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> information = new List<string>();


        private void button1_Click(object sender, EventArgs e)
        {
            string ID = searchIDtextBox.Text;

            for(int i=0; i<IDList.Count; i++)
            {
                if (IDList[i].ID == ID)
                {

                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"D:\Uniiii\1_2\Swe 4202\Lab10\Lab10"))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    Employee employee = new Employee();
                    employee.name = values[0];
                    employee.email = values[1];
                    employee.salary = values[2];
                    employee.hiring_date = values[3];
                    employee.phone_number = values[4];
                    employee.address = values[5];
                    employee.Add(employee);
                    listBox1.Items.Add(employee);

                    
                }
            }
        }
    }
}

     
