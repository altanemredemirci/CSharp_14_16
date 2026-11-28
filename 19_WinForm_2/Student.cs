using System;
using System.Collections.Generic;
using System.Text;

namespace _19_WinForm_2
{
    internal class Student
    {
        public string NameSurname { get; set; }
        public string University { get; set; }
        public string Gender { get; set; }
        public List<string> Lessons { get; set; } = new List<string>();
        public int  Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProfileImage { get; set; }

        //public Student()
        //{
        //    Lessons = new List<string>();
        //}
    }
}
