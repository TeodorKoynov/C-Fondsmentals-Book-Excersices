using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter20Excersices
{
    public class Student : Human, IComparable<Student>
        
    {
        private int grade = 0;

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public int CompareTo(Student student)
        {
            if (this.grade > student.grade)
            {
                return 1;
            }
            if (this.grade < student.grade)
            {
                return -1;
            }
            return 0;
        }
        public static Student[] Sort(Student[] students)
        {
            Student[] arr = students;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) == -1)
                    {
                        Student swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }
                }
            }
            return arr;
        }
    }
}
