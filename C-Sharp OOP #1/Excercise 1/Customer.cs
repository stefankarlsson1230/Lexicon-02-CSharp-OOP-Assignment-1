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
    }
}
