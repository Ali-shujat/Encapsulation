using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_of_Data
{
    class Person
    {
        private string firstName;
        private string lastName;
        private decimal salary;
        private int age;

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain less than 3 characters!");
                }
                this.firstName = value;
            }

        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("First name cannot contain less than 3 characters!");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;
            }
        }
        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 dollar!");
                }
                this.salary = value;
            }
        }


        public Person(string fName, string lastName, int age, decimal salary)
        {
            this.firstName = fName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} recieves {this.Salary}$ dollars. Age:{this.Age}";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary * percentage / 200;
            }
        }
    }
}
