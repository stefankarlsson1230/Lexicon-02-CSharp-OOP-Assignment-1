# C# Object Oriented Programming Assignment 1


This assignment should be created in one Visual studio solution with three projects - 
Exercise 1, Exercise 2 and Exercise 3.

Each new class you create in this assignment should be created in a separate file. 

## Exercise 1 
 
### Exercise 1.1 – Creating a class 
Create a class that represents a **person**. Let the class hold information about the 
person first name, last name and age. Let the constructor take in above data as 
parameters.  

### Exercise 1.2 – Adding methods to the class 
Add a method Speak that writes out “Hello my name is {first name} {last name}” to 
the screen when calling it on a person object, where {first name} and {last name} 
is switched out with the actual value stored for the given object. 
 
### Exercise 1.3 – Printing the person class directly 
Try using the Console.WriteLine to write out the **Person** object to the screen by passing 
the object as parameter. That is, Console.WriteLine( personObj ). What is the output? 

### Exercise 1.4 – Printing the Person class directly (Continued) 
Now, override the default ToString() method in the *Person* class, and let it return 
the first name, last name and age concatenated. 
Try calling the Console.WriteLine(Person object) and see what happens.  

### Exercise 1.5 – Counting the number of Person-objects created 
In this example, we are going to write the functionality for keeping count of the 
number of *Person* object created. Write a private static integer variable in the *Person*
class named InstanceCount, and write a static method named IncreaseInstanceCount that 
increases the InstanceCount variable by one each time the method is called. Also create 
one static method that returns the current InstanceCount value.

Where could you call the IncreaseInstanceCount method, so that it increases the 
InstanceCount each time we create a new person? 
 
### Exercise 1.6 – Inheritance 
Write an *Employee* class and a *Customer* class that are descendants (subclasses) 
of the *Person* class. Implement a *Salary* property in the *Employee* class.

Create constructors in both classes that calls the base *Person* class constructor 
passing the information it needs (see figure below).

On both the **Employee** class and **Customer** class, override the ToString-method 
and let the method return a string value depending on whether they’re customers or 
employees.

Create a new static method in your Program-class that takes a *Person* object as 
parameter. Inside the method, call the Console.WriteLine-method and pass the 
*Person*-object as parameter. In your main method, call the method with both an 
*Employee* and *Customer* object.  

![passing data to base constructor](fig1.jpg)
*Figure 1 Passing data to base constructor*

