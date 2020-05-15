using System;

namespace PolymorphismInterface
{
    public class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Epson display dimension : 10*11");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}