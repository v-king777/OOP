using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Obj
    {
        public void Display<T>(T param)
        {
            Console.WriteLine(param.ToString());
        }
    }
}
