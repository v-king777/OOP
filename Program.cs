using System;

class Program
{
    static void Main(string[] args)
    {
        DerivedClass derivedClass = new DerivedClass();
        derivedClass.Display();
    }
}

class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }
}
