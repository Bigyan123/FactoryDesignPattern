using PrintInterface;
using System;

namespace ConcreteClass
{
    public class clsPrintPDF : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Print PDF Data");
        }
    }
}
