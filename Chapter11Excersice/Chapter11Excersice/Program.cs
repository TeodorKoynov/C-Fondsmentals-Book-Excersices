using System;
using System.Numerics;
using System.Security.Authentication.ExtendedProtection;

namespace Chapter11Excersice
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Sequence.NextValue());
            }
            Console.WriteLine(Sequence.NextValue());

            Car lambo = new Car("Lamborgini", "Aventador", 200, "Yellow");
            Car ferari = new Car("Ferrari", "Laferari", 190, "Red");
            Car.Race(lambo, ferari);
            
        }
    }
}
