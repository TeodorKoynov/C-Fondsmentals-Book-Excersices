using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter22Excersices
{
    public class Dog
    {
        private string name = null;

        private int age = 0;

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }


    }
}
