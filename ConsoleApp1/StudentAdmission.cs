﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentAdmission
    {
        //Publisher
        //Event Sender

        /*
         * Steps:
         * 1. Define a Delegate
         * 2. Define an Event based on that Delegate
         * 3. Raise the Event
         */

        public delegate void StudentAdmittedEventHandler(object sender, EventArgs e);
        public event StudentAdmittedEventHandler StudentAdmitted;

        public void Admit(Student student)
        {
            Console.WriteLine($"Admitting Student. . .{student.name}.");
            

            OnStudentAdmitted();
        }

        protected virtual void OnStudentAdmitted()
        {
            if (StudentAdmitted != null)
            {
                StudentAdmitted(this, EventArgs.Empty);
            }
        }
    }
}
