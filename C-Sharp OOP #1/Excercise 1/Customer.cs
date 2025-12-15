namespace Excercise_1
{
    internal class Customer: Person
    {
        // Constructors
        public Customer(string firstName, string lastName, int age) : base(firstName, lastName, age) {}

        // Methods
        public override string ToString()
        {
            return base.ToString() + " is a customer";
        }
    }
}
