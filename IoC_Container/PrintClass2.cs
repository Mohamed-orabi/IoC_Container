using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Container
{
    class PrintClass2 : IPrintFullName
    {
        public void print()
        {
            Console.WriteLine("Mohamed Ali");
        }
    }
}
