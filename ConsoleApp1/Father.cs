namespace ConsoleApp1;

public class Father : GrandFather
{
    public Father(string name) : base(name)
    {
    }

    public override string irAlaGuerra()
    {
        return name + " está yendo a la guerra como su padre.";
    }
}
