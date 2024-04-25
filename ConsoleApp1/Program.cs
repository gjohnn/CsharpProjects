using System.Threading.Channels;

namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        Father padre = new Father("asd padre");
        Son hijo = new Son("nashe hijo");
        Console.WriteLine(padre.irAlaGuerra());
        Console.WriteLine(hijo.irAlaGuerra());
    }
}

