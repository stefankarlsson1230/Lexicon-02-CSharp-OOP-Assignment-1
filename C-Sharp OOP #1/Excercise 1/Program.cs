using Excercise_1;

Person person = new("Totte", "Bengtsson", 33);
Customer customer = new("Bengt", "Lilja", 45);
Employee employee = new("Lotta", "Sten", 33, 32000);


person.Speak();
Console.WriteLine(person);
Console.WriteLine("Number of instances: " + Person.GetInstanceCount());

Console.WriteLine();
Print(customer);
Print(employee);



// Methods
static void Print(Person person)
{
    Console.WriteLine(person);
}




