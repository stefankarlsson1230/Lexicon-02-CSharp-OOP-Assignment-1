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
        }

        // Methods
        public void NewSale(Customer customer, Employee employee)
        {
            customer.PurchasesList.Add(this);
            employee.SalesList.Add(this);
        }
    }
}
