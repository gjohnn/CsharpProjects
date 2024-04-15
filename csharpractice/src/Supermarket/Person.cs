namespace csharpractice;

public class Person
{
    public string first_name { get; set; }
    public int age{ get; set; }
    public string last_name{ get; set; }

    public Person(string firstName, int age, string lastName)
    {
        first_name = firstName;
        this.age = age;
        last_name = lastName;
    }

    public virtual void getInfo()
    {
        Console.WriteLine(first_name+" | "+last_name+" | "+ age);
    }
}