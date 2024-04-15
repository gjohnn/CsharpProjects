namespace csharpractice;

public class Market
{
    public string name;
    public  string[] products = new []{"papa", "fideos", "arroz"};

    public Market(string name)
    {
        this.name = name;
    }

    public void showProducts()
    {
        Console.WriteLine(" --------------- Products --------------- ");
        int index = 0;
        foreach (var e in products)
        {
            index++;
            Console.WriteLine("Producto "+index+": "+ e);
        }
    }
}