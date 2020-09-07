using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Chapter11Excersice
{
    class Car
    {
        private int hoursePower;

        private string mark;

        private string model;

        private string color;

        private static bool started = false;

        public int HP
        {
            get
            {
                return this.hoursePower;
            }
            set
            {
                this.hoursePower = value;
            }
        }

        public string Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string Color
        {
            get 
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public Car()
        {
            this.mark = "Unknown";
            this.model = "Unknown";
            this.color = "Unknown";
            this.hoursePower = 0;
        }

        public Car(string mark, string model, int hp, string color)
        {
            this.mark = mark;
            this.model = model;
            this.hoursePower = hp;
            this.color = color;
        }

        public void StartEngine()
        {
            if (started == true)
            {
                Console.WriteLine("The car was\'t stoped!");
            }
            else
            {
                Console.WriteLine("RUUM RUMM! ENGINE STARTED!");
                started = true;
            }
        }

        public void StopEngine()
        {
            if(started == false)
            {
                Console.WriteLine("The engin was\'t running");
            }
            else
            {
                Console.WriteLine("The car is shutted down!");
                started = false;
            }
        }

        public static void Race(Car car1, Car car2)
        {
            car1.StartEngine();
            car2.StartEngine();
            if(car1.hoursePower > car2.hoursePower)
            {
                Console.WriteLine("THE WINNER IS {0}", car1.Model + " " + car1.Mark);
            }
            else if(car2.hoursePower > car1.hoursePower)
            {
                Console.WriteLine("THE WINNER IS {0}", car2.Model + " " + car2.Mark);
            }
            else
            {
                Console.WriteLine("DRAW!!!");
            }
        }

    }
}
