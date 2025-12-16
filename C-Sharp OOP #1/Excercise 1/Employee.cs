namespace Excercise_1
{
    internal class Employee: Person
    {
        // Properties
        public double Salary { get; set; }
        public List<Sale> SalesList { get; set; }

        // Constructors
        public Employee(string firstName, string lastName, int age, double salary): base(firstName, lastName, age)
        {
            Salary = salary;
            SalesList = new List<Sale>();
        }

        // Methods
        public override string ToString()
        {
            return base.ToString() + $" is an employee with a salary of {Salary}";
        }

    }
}
