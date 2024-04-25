namespace ConsoleApp1;

public class Son : Father
{
    public Son(string name) : base(name)
    {
    }

    public override string irAlaGuerra()
    {
        return name + " está yendo a la guerra como su padre.";
    }
}
