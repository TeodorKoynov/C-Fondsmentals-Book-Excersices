using System;

namespace Chapter20Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Gogo", "Dimitrov", 1);
            Student student2 = new Student("Gogo", "Dimitrov", 25);
            Student student3 = new Student("Gogo", "Dimitrov", 4);
            Student student4 = new Student("Gogo", "Dimitrov", 4);
            Student student5 = new Student("Gogo", "Dimitrov", 3);
            Student student6 = new Student("Gogo", "Dimitrov", 1);
            Student[] arr = { student1, student2, student3, student4, student5, student6 };
            Human human1 = new Human("Ivan", "Barachina");
            Worker worker1 = new Worker("Dimcho", "Devilqnov", 40, 10);
            Worker.PrintOverPaidMoney(worker1);

            Student.Sort(arr);
            foreach (Student str in arr)
            {
                Console.WriteLine(str.Grade);
            }
            
        }
    }
}
