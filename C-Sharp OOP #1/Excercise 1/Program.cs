using Excercise_1;

// Person person = new("Totte", "Bengtsson", 33);

Customer customer1 = new("Anna", "Svensson", 28);
Customer customer2 = new("Erik", "Johansson", 34);
Customer customer3 = new("Maria", "Lindberg", 41);
Customer customer4 = new("Johan", "Karlsson", 52);
Customer customer5 = new("Sara", "Nilsson", 25);
Customer customer6 = new("Anders", "Berg", 47);
Customer customer7 = new("Elin", "Holm", 31);
Customer customer8 = new("Per", "Åkesson", 60);
Customer customer9 = new("Karin", "Ekström", 38);
Customer customer10 = new("Mikael", "Fors", 44);

Employee employee1 = new("Lotta", "Sten", 33, 32000);
Employee employee2 = new("Henrik", "Blom", 45, 42000);
Employee employee3 = new("Camilla", "Nord", 29, 29500);


//person.Speak();
//Console.WriteLine(person);
//Console.WriteLine("Number of instances: " + Person.GetInstanceCount());

//Console.WriteLine();
//Print(customer1);
//Print(employee1);

Sale sale1 = new("Laptop", 1299, customer1, employee1);
Sale sale2 = new("Mobile Phone", 899, customer2, employee2);
Sale sale3 = new("Tablet", 499, customer3, employee3);
Sale sale4 = new("Headphones", 199, customer4, employee1);
Sale sale5 = new("Smartwatch", 349, customer5, employee2);

Sale sale6 = new("TV", 1599, customer6, employee3);
Sale sale7 = new("Game Console", 649, customer7, employee1);
Sale sale8 = new("Keyboard", 129, customer8, employee2);
Sale sale9 = new("Mouse", 79, customer9, employee3);
Sale sale10 = new("Webcam", 149, customer10, employee1);

Sale sale11 = new("Router", 189, customer1, employee2);
Sale sale12 = new("External Hard Drive", 249, customer2, employee3);
Sale sale13 = new("Monitor", 399, customer3, employee1);
Sale sale14 = new("Printer", 299, customer4, employee2);
Sale sale15 = new("USB Flash Drive", 29, customer5, employee3);

Sale sale16 = new("Microphone", 219, customer6, employee1);
Sale sale17 = new("Speakers", 279, customer7, employee2);
Sale sale18 = new("Graphics Card", 999, customer8, employee3);
Sale sale19 = new("Docking Station", 329, customer9, employee1);
Sale sale20 = new("Portable SSD", 279, customer10, employee2);


WriteLine("--- Employee Statistics ---\n");

employee1.PrintStatistics();
WriteLine();
employee2.PrintStatistics();
WriteLine();
employee3.PrintStatistics();


WriteLine("\n\n--- Sales by each employee ---\n");

employee1.PrintSalesList();
WriteLine();
employee2.PrintSalesList();
WriteLine();
employee3.PrintSalesList();



WriteLine("\n--- Some Customer Statistics ---\n");

customer1.PrintStatistics();
WriteLine();
customer2.PrintStatistics();
WriteLine();
customer3.PrintStatistics();

WriteLine();

customer1.PrintShoppingList();
WriteLine();
customer2.PrintShoppingList();
WriteLine();
customer3.PrintShoppingList();




// Methods
static void Print(Person person)
{
    Console.WriteLine(person);
}




