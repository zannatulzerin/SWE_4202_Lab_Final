using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public class Grades
    {
        private string ID, Name;
        private string Attendance, Quiz1, Quiz2, Quiz3, Quiz4, Mid, Final, Viva;

        public Grades(string ID, string Name, string Attendance, string Quiz1, string Quiz2, string Quiz3, string Quiz4, string Mid, string Final, string Viva)
        {
            this.ID = ID;
            this.Name = Name;
            this.Attendance = Attendance;
            this.Quiz1 = Quiz1;
            this.Quiz2 = Quiz2;
            this.Quiz3 = Quiz3;
            this.Quiz4 = Quiz4;
            this.Mid = Mid;
            this.Final = Final;
            this.Viva = Viva;
        }
        public string getID()
        {
            return this.ID;
        }
        public string getAttendance() { return this.Attendance; }
        public string getQuiz1() { return this.Quiz1; }
        public string getQuiz2() { return this.Quiz2; }
        public string getQuiz3() { return this.Quiz3; }
        public string getQuiz4() { return this.Quiz4; }
        public string getMid() { return this.Mid; }
        public string getFinal() { return this.Final; }
        public string getViva() { return this.Viva; }
        public string getInfo()
        {
            return this.ID + " " + "\t" + this.Name + "\t\t\t\t" + this.Attendance + "\t" + this.Quiz1 + "\t" + this.Quiz2 + "\t" + this.Quiz3 + "\t" + this.Quiz4 + "\t" + this.Mid + "\t" + this.Final;
        }
    }
}
    }
}
