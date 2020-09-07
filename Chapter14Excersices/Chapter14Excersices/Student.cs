using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Chapter14Excersices
{
    class Student
    {
        private string fullName = "";
        private string course = "";
        private string courseSpecial = "";
        private string university = "";
        private string email = "";
        private string phoneNumber = "";

        private static int studentsCounter = 0;

        public string FullName
        {
            get
            {
                return this.fullName;
            }
            set
            {
                this.fullName = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }
        
        public string CourseSpecial
        {
            get
            {
                return this.courseSpecial;
            }
            set
            {
                this.courseSpecial = value;
            }
        }

        public string University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }   
    
        public static int StudentsCounter
        {
            get
            {
                return Student.studentsCounter;
            }
        }

        public Student()
        {
            this.fullName = null;
            this.course = null;
            this.courseSpecial = null;
            this.university = null;
            this.email = null;
            this.phoneNumber = null;
            studentsCounter++;
        }

        public Student(string fullName, string course, string courseSpecial, string university, string email, string phoneNumber)
        {
            this.fullName = fullName;
            this.course = course;
            this.courseSpecial = courseSpecial;
            this.university = university;
            this.email = email;
            this.phoneNumber = phoneNumber;
            studentsCounter++;
        }
    
        public void PringStudenInfo()
        {
            Console.WriteLine($"{this.fullName} {this.course} {this.courseSpecial} {this.university} {this.email} {this.phoneNumber}");
        }
    }



}
