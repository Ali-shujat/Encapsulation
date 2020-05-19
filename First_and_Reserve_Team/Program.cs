using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_Reserve_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab: Encapsulation!");

            Console.WriteLine("4. First and Reserve Team!");
            var lines = 5;
            var persons = new List<Person>();

            Console.WriteLine("Please Enter Name and Age");
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName)
                   .ThenBy(p => p.Age)
                   .ToList()
                   .ForEach(p => Console.WriteLine(p.ToString()));

            Console.ReadKey();

            var team = new Team("N20");
            foreach(Person p in persons)
            {
                team.AddPlayer(p);
            }

            Console.WriteLine(team.Display());


            Console.ReadKey();

        }
    }
}
