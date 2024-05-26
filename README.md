# NullPattern

Null Pattern is a C# implementation demonstrating the Null Object Design Pattern. This pattern helps in dealing with null references by providing a default object instead of using null references. This can prevent null reference exceptions and make the code more readable and maintainable.

## Features

- **Demonstrates Null Object Pattern**: Shows how to implement and use the Null Object Design Pattern in C#.
- **Improves Code Quality**: Helps to avoid null reference exceptions and makes the code cleaner.
- **Educational**: Useful for learning and teaching the Null Object Design Pattern.

## Installation

To get started with NullPattern, clone the repository and build the project using .NET.

```bash
git clone https://github.com/stevsharp/NullPattern.git
cd NullPattern
dotnet build

## Example
Here is a basic example demonstrating the Null Object Pattern:

public interface ICustomer
{
    string GetName();
}

public class RealCustomer : ICustomer
{
    private string _name;

    public RealCustomer(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}

public class NullCustomer : ICustomer
{
    public string GetName()
    {
        return "Not Available";
    }
}

public class CustomerFactory
{
    public static ICustomer GetCustomer(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return new NullCustomer();
        }
        return new RealCustomer(name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICustomer customer1 = CustomerFactory.GetCustomer("John Doe");
        ICustomer customer2 = CustomerFactory.GetCustomer(null);

        Console.WriteLine("Customer 1: " + customer1.GetName());
        Console.WriteLine("Customer 2: " + customer2.GetName());
    }
}
