using Chapter22Excersices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Cache;

namespace Chapter22Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 32, 15, 60 };
            Console.WriteLine(numbers.ToString<int>());
            numbers.IncreseWith(3);
            Console.WriteLine(numbers.ToString<int>());

            var newNums = numbers.FindAll((i) =>
                {
                    Console.WriteLine(i);
                    return (i % 2) == 0;
                });

            var myCar = new { Color = "Black", Brand = "Lamborgini", Speed = 210 };
            Console.WriteLine(myCar.ToString());

            var arr = new[] { new { X = 1, Y = 15},
                                new { X = 2, Y = 1 },
                                new { X = 3, Y = 5 } };

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            List<int> evenNum = numbers.FindAll(x => (x - 10) == 0);
            Console.WriteLine(evenNum.ToString<int>());

            List<Dog> dogs = new List<Dog>
            {
                new Dog("Jack", 14),
                new Dog("John", 4),
                new Dog("Loker", 114),
                new Dog("Miker", 214)
            };

            var names = dogs.Select(x => x.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            var newDogs = dogs.Select(
                x => new { Age = x.Age, FirstLetter = x.Name[0] });

            foreach (var dog in newDogs)
            {
                Console.WriteLine(dog);
            }

            var sortedDogs = dogs.OrderByDescending(x => x.Age);
            foreach (var dog in sortedDogs)
            {
                Console.WriteLine(dog.Name + " " + dog.Age);
            }

            Func<bool> boolFunc = () => true;
            Func<int, bool> intFunc = (x) => x < 10;

            if (boolFunc() && intFunc(1))
            {
                Console.WriteLine("1 < 10");
            }

            List<int> theNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evenNumbs =
                from numb
                in theNumbers
                where numb % 2 == 0
                select numb;

            foreach (var item in evenNumbs)
            {
                Console.WriteLine($"The number {item} is even");
            }

            string[] words = { "Coconut", "Cook", "Mangorant" };
            var sortedWords =
                from word in words
                orderby word.Length descending
                select word;

            foreach (var item in sortedWords)
            {
                Console.WriteLine(item);
            }

            int[] myNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 50, 100 };
            int devider = 5;

            var newNumbers =
                from number in myNumbers
                group number by number % devider into union
                select new { Remainder = union.Key, Numbers = union };

            foreach (var item in newNumbers)
            {
                Console.WriteLine($"Remainder {item.Remainder} number");
                foreach (var number in item.Numbers)
                {
                    Console.WriteLine(number);
                }
            }

            List<Category> categories = new List<Category>()
            {
                new Category { ID = 1, Name = "Friut"},
                new Category { ID = 2, Name = "Vegetable"},
                new Category { ID = 3, Name = "Drink"},
                new Category { ID = 4, Name = "Sweet"}
            };

            List<Product> products = new List<Product>()
            {
                new Product { Name = "Bannan", CategoryID = 1},
                new Product { Name = "Candy", CategoryID = 4},
                new Product { Name = "Cola", CategoryID = 3},
                new Product { Name = "Pepsi", CategoryID = 3},
                new Product { Name = "Carrot", CategoryID = 2 }
            };

            var productsWithCategories =
                from category in categories
                join product in products
                on category.ID equals product.CategoryID
                select new
                {
                    Name = product.Name,
                    Category = category.Name
                };
            foreach (var item in productsWithCategories)
            {
                Console.WriteLine(item);
            }
        }
    }
}
