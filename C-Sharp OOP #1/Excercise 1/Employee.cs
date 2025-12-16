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

        public int GetNumberOfSales() => SalesList.Count;

        public double GetSalesTotal()
        {
            double sum = 0;

            foreach (Sale sale in SalesList)
            {
                sum += sale.Price;
            }

            return sum;
        }

        public double GetAverageSale() => GetSalesTotal() / GetNumberOfSales();

        public void PrintStatistics()
        {
            WriteLine($"Following is statistics for {FirstName} {LastName}!");
            WriteLine($"Number of sales: {GetNumberOfSales()}");
            WriteLine($"Sales total: ${GetSalesTotal()}");
            WriteLine($"Average sales: ${GetAverageSale():#.##}");
        }

        public void PrintSalesList()
        {
            WriteLine($"List of sales for {FirstName} {LastName}\n");

            foreach (Sale sale in SalesList)
            {
                WriteLine($"Product: {sale.Product, -20} Price: ${sale.Price, -10} Buyer: {sale.Customer.FirstName} {sale.Customer.LastName}");
            }
            WriteLine("-----------------------------------------------------------------------------");
        }
    }
}
