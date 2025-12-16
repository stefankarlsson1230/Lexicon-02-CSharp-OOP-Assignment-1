namespace Excercise_1
{
    internal class Customer: Person
    {
        // Properties
        public List<Sale> PurchasesList { get; set; }

        // Constructors
        public Customer(string firstName, string lastName, int age) : base(firstName, lastName, age) 
        {
            PurchasesList = new List<Sale>();
        }
        

        // Methods
        public override string ToString()
        {
            return base.ToString() + " is a customer";
        }

        public int GetNumberOfPurchases() => PurchasesList.Count;

        public double GetPriceTotal()
        {
            double sum = 0;

            foreach (Sale purchase in PurchasesList)
            {
                sum += purchase.Price;
            }

            return sum;
        }

        public double GetAveragePrice() => GetPriceTotal() / GetNumberOfPurchases();

        public void PrintStatistics()
        {
            WriteLine($"Following is statistics for {FirstName} {LastName}!");
            WriteLine($"Number of purchases: {GetNumberOfPurchases()}");
            WriteLine($"Purchases total: ${GetPriceTotal()}");
            WriteLine($"Average purchases: ${GetAveragePrice():#.##}");
        }

        public void PrintShoppingList()
        {
            WriteLine($"List of purchases for {FirstName} {LastName}\n");

            foreach (Sale purchase in PurchasesList)
            {
                WriteLine($"Product: {purchase.Product,-20} Price: ${purchase.Price,-10} Seller: {purchase.Employee.FirstName} {purchase.Employee.LastName}");
            }
            WriteLine("-----------------------------------------------------------------------------");
        }

    }
}
