namespace Excercise_1
{
    internal class Sale
    {
        // Properties
        public string Product {  get; set; }
        public double Price { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public DateTime TransactionDate { get; set; }

        // Constructors
        public Sale(string product, double price, Customer customer, Employee employee)
        {
            Product = product;
            Price = price;
            Customer = customer;
            Employee = employee;
            TransactionDate = DateTime.Now;

            customer.PurchasesList.Add(this);
            employee.SalesList.Add(this);
        }

        // Methods

        // This NewSale method is pointless. I will move this functionallity to the constructor 
        // public void NewSale(Customer customer, Employee employee)
        // {
        //    customer.PurchasesList.Add(this);
        //    employee.SalesList.Add(this);
        // }
    }
}
