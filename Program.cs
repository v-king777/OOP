using System;

class Program
{
    static void Main(string[] args)
    {
        BaseClass baseClass = new BaseClass();
        DerivedClass derivedClass = new DerivedClass();

        baseClass.Counter = -1;
        Console.WriteLine(baseClass.Counter);

        derivedClass.Counter = 1;
        Console.WriteLine(derivedClass.Counter);
    }
}

class BaseClass
{
    public virtual int Counter
    {
        get;
        set;
    }
}

class DerivedClass : BaseClass
{
    private int counter;
    public override int Counter
    {
        get
        {
            return counter;
        }
        set
        {
            if (value >= 0)
            {
                counter = value;
            }
        }
    }
}
