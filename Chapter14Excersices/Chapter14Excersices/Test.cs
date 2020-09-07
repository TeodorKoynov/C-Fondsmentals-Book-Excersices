using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter14Excersices
{
    class Test
    {
        private static Student[] students;

        public static void TestStudents()
        {
            CreateStudents();
            foreach(Student student in students)
            {
                student.PringStudenInfo();
            }
        }
        static void CreateStudents()
        {
            students = new Student[3];
            for (int i = 0; i < 3; i++)
            {     
                students[i] = new Student("gogo", "biology", "brain", "Harvard", "GO", "dontHabd");
            }
        }
    }
}
