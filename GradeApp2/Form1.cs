using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QuizLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = NameTextBox.Text;
            int ID = Convert.ToInt32(IDTextBox.Text);
            int Semester = Convert.ToInt32(SemesterTextBox.Text);
            int NumberofClasses = Convert.ToInt32(NumberofclassesTextBox.Text);
            double MidMarks = Convert.ToDouble(MidTextBox.Text);
            double FinalMarks = Convert.ToDouble(FinalTextBox.Text);
            double Quiz1 = Convert.ToDouble(Quiz1TextBox.Text);
            double Quiz2 = Convert.ToDouble(Quiz2TextBox.Text);
            double Quiz3 = Convert.ToDouble(Quiz3TextBox.Text);
            double Quiz4 = Convert.ToDouble(Quiz4TextBox.Text);
            double AttendedClasses = Convert.ToDouble(NumberofClasses);
            double Attendance = (AttendedClasses / 28) * 30;
            double[] ArrayofQuiz = { Quiz1, Quiz2, Quiz3, Quiz4 };
            Array.Sort(ArrayofQuiz);
            double QuizTotal = 0;
            for (int i = 1; i < ArrayofQuiz.Length; i++)
            {
                QuizTotal = QuizTotal + ArrayofQuiz[i];
            }
            AttendanceLabel.Text = "Attendance: " + Math.Round(Attendance, 2) + "/30";
            MidLabel.Text = "Mid: " + MidMarks + "/75";
            QuizLabel.Text = "Quiz: " + QuizTotal + "/45";
            FinalLabel.Text = "Final: " + FinalMarks + "/150";
            double Total = Attendance + MidMarks + QuizTotal + FinalMarks;
            TotalLabel.Text = "Total: " + Math.Round(Total, 2) + "/300";
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
            GradeLabel.Text = "Grade: " + Grade;
            LastLineLabel.Text = Name + " obtained " + Math.Round(MarksinPercantage, 2) + "% marks.";
        }
    }
}
 