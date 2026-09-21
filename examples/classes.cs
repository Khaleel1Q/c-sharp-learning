using System;
public class Classes
{
public static void Main()
	{
       
        //Classes Example Start
        Person person = new Person("John Doe", 30, "123 Main St");
        person.PrintDetails();
        Person person2 = new Person();
        person2.PrintDetails();
        //Classes Example END

    }
}


//Classes Example start
public class Person
{
    int age;
    string name;
    string address;
     public Person() : this("Unknown", 0, "Unknown")
 {
 }
    public Person(string name, int age, string address)//constructor
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}");
    }

    ~Person()//Destructor
    {
        Console.WriteLine("Person object is being destroyed.");
    }
}
