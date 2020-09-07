using System;

namespace Chapter2Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -44;
            sbyte aa = -115;
            int aaaa = 4825932;
            int vvv = -10000;
            ushort si = 20000;
            byte tp = 224;
            uint gi = 970700000;
            byte b = 97;
            byte v = 112;
            int go = -1000000;
            ushort moi = 1990;
            long moiche = 123456789123456789;

            double da = 34.567839023d;
            decimal doi = 34.567839023m;

            float koko = 12.345f;
            float gigo = 8923.1234857f;
            decimal dodo = 3456.091124875956542151256683467m;

            decimal num1 = 30.122m;
            decimal result = num1 * 0.00001m;
            Console.WriteLine(result);

            string numInHex = Convert.ToString(72, 16);
            Console.WriteLine(numInHex);
            char sym = '\u0072';
            Console.WriteLine(sym);

            bool isMale = true;

            string str = "Hello";
            string str2 = "World!";
            object greetings = str + " " + str2;
            string strGreatings = greetings.ToString();
            Console.WriteLine(greetings);
            Console.WriteLine(strGreatings);

            //string one = ""The "use" of quotations causes difficulties."";
            string two = "\"The \"use\" of quotations causes difficulties.\"";

            string heart = @"
                             oo  oo
                           oo  oo  oo
                             o    o
                                o ";
            Console.WriteLine(heart);

            string triangle = @"
                ©
               © ©
              ©   ©
             ©     ©
            ©       ©
           © © © © © ©";
            Console.Write(triangle);

            string firtName;
            string lastName;
            byte age;
            char gender;
            uint keyNumber;
            int number = 12;
            int number1 = 123;
            Console.Write("number 1 is:" + number + "number 2 is" + number1);
            int gogo = number;
            number = number1;
            number1 = gogo;
            Console.WriteLine("number 1 is: " + number + "number 2 is" + number1);






        }

    }
}
