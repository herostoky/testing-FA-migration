namespace TestingByeFA;

public class Person
{
    public int Age { get; private set; }
    public string? Name { get; private set; }
    public Address? Address { get; private set; }

    public bool IsAdult() => Age >= 18;

    public Person()
    {
    }

    public Person(int age, string? name, Address? address)
    {
        Age = age;
        Name = name;
        Address = address;
    }

    public void CelebrateBirthday()
    {
        Console.WriteLine("Happy birthday !!");
        Age++;
    }
}

public class Address
{
    public string? City { get; set; }
}