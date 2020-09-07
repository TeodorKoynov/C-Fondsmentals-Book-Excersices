using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11Excersice
{
    class Cat
    {
        private string name;

        private string color;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public Cat()
        {
            this.name = "Unknown";
            this.color = "Black";
        }

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Mew()
        {
            Console.WriteLine("{0} said MEWWWWWW!", this.name);
        }
    }
}
