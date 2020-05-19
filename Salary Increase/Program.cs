using System;
using System.Collections.Generic;

namespace Salary_Increase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab: Encapsulation!");
            Console.WriteLine("2.Salary Increase!");

            var lines = 5;
            var persons = new List<Person>();

            Console.WriteLine("Please Enter Name Age and Salary :");
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            Console.WriteLine("Please Enter bonus Percentage :");
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));


        }
    }
}
