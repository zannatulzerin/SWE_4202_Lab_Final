using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        List<student> students = new List<student>();
        List<teacher> teachers = new List<teacher>();
        List<admin> admins = new List<admin>();

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveStudentInfoButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            int id = Convert.ToInt32(IDTextBox.Text);
            string semester = SemesterTextBox.Text;
            string department = DepartmentTextBox.Text;

            student Students_emp = new student();
            Students_emp.id = id;
            Students_emp.name = name;
            Students_emp.semester = semester;
            Students_emp.department = department;

            student_emp.Add(Students_emp);

            MessageBox.Show("Student Info has been added successfully");

        }

        private void ClearStudentInfoButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = String.Empty;
            IDTextBox.Text = String.Empty;
            SemesterTextBox.Text = String.Empty;
            DepartmentTextBox.Text = String.Empty;

            MessageBox.Show("Cleared successfully");
        }

        private void ShowStudentInfoButton_Click(object sender, EventArgs e)
        {
            StudentListbox.Items.Clear();

            for (int i=0; i<StudentListbox.Count; i++)
            {
                StudentListbox.Items.Add(student[i].getInfo());
            }
        }
    }
}
