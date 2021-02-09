using System;

class Program
{
    static void Main(string[] args)
    {
        InheritedClass inherited = new InheritedClass(200);
    }
}

class BaseClass
{
    public string Name;
    protected string Description;
    private int value;

    public BaseClass(int value)
    {
        this.value = value;
    }
}

class InheritedClass : BaseClass
{
    private int newValue;

    public InheritedClass(int newValue) : base(100)
    {
        this.newValue = newValue;
    }
}
