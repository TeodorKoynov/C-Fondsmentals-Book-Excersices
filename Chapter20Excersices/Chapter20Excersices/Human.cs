using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter20Excersices
{
    public class Human
    {
        private string firstName = "";

        private string lastName = "";

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        { 
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
