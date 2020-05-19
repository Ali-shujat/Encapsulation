namespace Salary_Increase
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
        }
        public string LastName
        {
            get { return this.lastName; }
        }
        public int Age
        {
            get { return this.age; }
        }
        public decimal Salary
        {
            get { return this.salary; }
        }


        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} recieves {this.Salary} dollars.";
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
