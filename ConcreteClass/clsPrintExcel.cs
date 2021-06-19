using PrintInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcreteClass
{
    public class clsPrintExcel : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Print Excel Data");
        }
    }
}
