namespace csharpractice;

public class Client : Person
{
    public string[] cart;

    public Client(string firstName, int age, string lastName) : base(firstName, age, lastName)
    {

    }

    public override void getInfo()
    {
        Console.WriteLine(first_name+" | "+last_name+" | "+ age);
        foreach (var e in cart)
        {
            Console.WriteLine(e);
        }
    }
}