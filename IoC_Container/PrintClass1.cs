using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_Container
{
    class PrintClass1 : IPrintFullName
    {
        public void print()
        {
            Console.WriteLine("Mohamed Orabi");
        }
    }
}
