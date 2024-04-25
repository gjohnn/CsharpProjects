namespace ConsoleApp1;

public abstract class GrandFather
{
    public string name;

    public GrandFather(string name)
    {
        this.name = name;
    }

    public virtual string irAlaGuerra()
    {
        return name+" esta yendo a la guerra";
    }
}