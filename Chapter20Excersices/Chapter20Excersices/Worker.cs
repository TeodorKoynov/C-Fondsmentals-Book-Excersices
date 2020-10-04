using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter20Excersices
{
    public class Worker : Human
    {
        private int overPaid = 0;
        private int workHours = 0;

        public int OverPaid
        {
            get { return this.overPaid; }
            set { this.overPaid = value; }
        }

        public int WorkHours
        {
            get { return this.workHours; }
            set { this.workHours = value; }
        }

        public Worker(string firstName, string lastName, int workHours, int overPaid)
            :base(firstName, lastName)
        {
            this.workHours = workHours;
            this.overPaid = overPaid;
        }
    
        public static void PrintOverPaidMoney(Worker worker)
        {
            Console.WriteLine(worker.overPaid * worker.workHours);
        }
    }
}
