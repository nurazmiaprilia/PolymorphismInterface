using System;

namespace PolymorphismInterface
{
    public class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Laserjet display dimension : 12*12");
        }

        public void Print()
        {
            Console.WriteLine("Laserjet printer printing....");
        }
    }
}