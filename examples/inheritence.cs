using System;

public class Inheritance
{
    public static void Main()
    {
        //Inheritance Example Start
        Employee employee = new Employee("Jane Smith", 28, "jane.smith@example.com");
        employee.PrintDetails();

        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("John Doe", 35, "john.doe@example.com", 50000);
        FullTimeEmployee.PrintRole();
        fullTimeEmployee.PrintDetails();

        PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Alice Johnson", 25, "alice.johnson@example.com", 20, 20);
        PartTimeEmployee.PrintRole();
        partTimeEmployee.PrintDetails();
    }
}

public class Employee
{
    public string name;
    public int age;
    public string email;

    public Employee() { } // <- allows derived constructors to omit base(...) calls

    public Employee(string name, int age, string email)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Email: {email}");
    }
}

public class FullTimeEmployee : Employee
{
    public double salary;
    static string Role = "Full-Time";
    public static void PrintRole()
    {
        Console.WriteLine($"Role: {Role}");
    }
    public FullTimeEmployee(string name, int age, string email, double salary)
        : base(name, age, email)            // <- added
    {
        this.salary = salary;
        // (optional) you can remove redundant assignments to name/age/email if present
    }
    public new void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Salary: {salary}");
    }
}

public class PartTimeEmployee : Employee
{
    public double hourlyRate;
    public int hoursWorked;
    static string Role = "Part-Time";
    public static void PrintRole()
    {
        Console.WriteLine($"Role: {Role}");
    }
    public PartTimeEmployee(string name, int age, string email, double hourlyRate, int hoursWorked)
        : base(name, age, email)            // <- added
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Hourly Rate: {hourlyRate}, Hours Worked: {hoursWorked}");
    }
}
