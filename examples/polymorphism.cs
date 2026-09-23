using System;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";
    public Employee(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    } // <- allows derived constructors to omit base(...) calls
    public virtual void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}

public class PartTimeEmployee : Employee
{
    public PartTimeEmployee(string firstName, string lastName)
        : base(firstName, lastName)            // <- added
    {
    }
   override public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName} - Part-Time");
    }
}
public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string firstName, string lastName)
        : base(firstName, lastName)            // <- added
    {
    }
   override public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName} - Full-Time");
    }
}


public class TemporaryEmployee : Employee
{
    public TemporaryEmployee(string firstName, string lastName)
        : base(firstName, lastName)            // <- added
    {
    }
   override public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName} - Temporary");
    }
}
public class Polymorphism
{
    public static void Main(string[] args)
    {
        Employee[] employees = new Employee[4];
        employees[0] = new Employee("John", "Doe");
        employees[1] = new PartTimeEmployee("Jane", "Smith");
        employees[2] = new FullTimeEmployee("Bob", "Johnson");
        employees[3] = new TemporaryEmployee("Alice", "Williams");

        foreach (Employee employee in employees)
        {
            employee.PrintFullName();
        }
    }
}