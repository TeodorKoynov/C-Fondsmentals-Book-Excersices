using System;

namespace Chapter12Excersice
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.IOException get = new System.IO.IOException("get some help");
            System.IO.IOException bad = new System.IO.IOException("Stop it!", get);
            System.IO.FileNotFoundException notFound = new System.IO.FileNotFoundException("Cannot fing", "Mongo.js", get);
            ApplicationException badAplication = new ApplicationException("The site is trash", get);
            Console.WriteLine(bad.InnerException.Message);
            System.FormatException k = new System.FormatException("Invalid number");
            try
            {
                int num = int.Parse(Console.ReadLine());
                num = (int)Math.Sqrt(num);
                Console.WriteLine(num);
            }
            
            finally
            {
                Console.WriteLine("Good bye!");
            }




            
        }


    }
}
