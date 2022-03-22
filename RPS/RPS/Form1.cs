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

namespace RPS
{
    public partial class Form1 : Form
    {
     List<string> Lists = new List<string>();

        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\marksheet.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Grades dummy_grade = new Grades(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]);
                    Lists.GradesList.Add(dummy_grade);
                }
            }
            InitializeListBoxValues();
        }
        private void InitializeListBoxValues()
        {
            listBox1.Items.Clear();
            foreach (Grades temp in Lists.GradesList)
            {
                listBox1.Items.Add(temp.getInfo());
            }
        }
  

        private void button1_Click(object sender, EventArgs e)
        {
         
            double quiz1 = Convert.ToDouble(quiz1textbox.Text);
            double quiz2 = Convert.ToDouble(quiz2textbox.Text);
            double quiz3 = Convert.ToDouble(quiz3textbox.Text);
            double quiz4 = Convert.ToDouble(quiz4textbox.Text);
            double mid = Convert.ToDouble(midtextbox.Text);
            double final = Convert.ToDouble(finaltextbox.Text);
            double total = Convert.ToDouble(totaltextbox.Text);
            int percentage = Convert.ToInt32(percentagetextbox.Text);
            string grade = gradetextbox.Text;
            double attendance = Convert.ToDouble(Attendancetextbox.Text);
            double[] ArrayofQuiz = { quiz1, quiz2, quiz3, quiz4 };
            Array.Sort(ArrayofQuiz);
            double QuizTotal = 0;
            for (int i = 1; i < ArrayofQuiz.Length; i++)
            {
                QuizTotal = QuizTotal + ArrayofQuiz[i];
            }
            Attendancetextbox.Text = "Attendance: " + Math.Round(attendance, 2) + "/30";
            midtextbox.Text = "Mid: " + mid + "/75";
            qtotaltextbox.Text = "Quiz: " + QuizTotal + "/45";
            finaltextbox.Text = "Final: " + final + "/150";
            double Total = attendance + mid + QuizTotal + final;
            totaltextbox.Text = "Total: " + Math.Round(Total, 2) + "/300";
            double MarksinPercantage = (Total / 300) * 100;
            string Grade;
            if (MarksinPercantage >= 80)
            {
                Grade = "A+";
            }
            else if (MarksinPercantage >= 75 && MarksinPercantage <= 79)
            {
                Grade = "A";
            }
            else if (MarksinPercantage >= 70 && MarksinPercantage <= 74)
            {
                Grade = "A-";
            }
            else if (MarksinPercantage >= 65 && MarksinPercantage <= 69)
            {
                Grade = "B+";
            }
            else if (MarksinPercantage >= 60 && MarksinPercantage <= 64)
            {
                Grade = "B";
            }
            else if (MarksinPercantage >= 55 && MarksinPercantage <= 59)
            {
                Grade = "B-";
            }
            else if (MarksinPercantage >= 50 && MarksinPercantage <= 54)
            {
                Grade = "C+";
            }
            else if (MarksinPercantage >= 45 && MarksinPercantage <= 49)
            {
                Grade = "C";
            }
            else if (MarksinPercantage >= 40 && MarksinPercantage <= 44)
            {
                Grade = "D";
            }
            else
            {
                Grade = "F";
            }
            gradetextbox.Text = "Grade: " + Grade;
        }
    }


}
