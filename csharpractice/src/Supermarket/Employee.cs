namespace csharpractice;

public class Employee : Person
{
    public Guid id = Guid.NewGuid();

    public Employee(string firstName, int age, string lastName) : base(firstName, age, lastName)
    {
    }

    public override void getInfo()
    {
        Console.WriteLine("ID: "+id+" | "+first_name+" | "+last_name+" | "+ age);

    }
}