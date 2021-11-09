using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Student
    {
        public string FullName { get; set; }
        private int tempInt = 0;

        public int No
        {
            get;
            set;
        }
        public Student(string fullname)
        {
            FullName = fullname;
            tempInt++;
            No = tempInt;
        }
    }
}
