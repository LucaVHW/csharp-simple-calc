using System;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int getal1, getal2, som;
            Console.Write("Getal 1: ");
            getal1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Getal 2: ");
            getal2 = Convert.ToInt16(Console.ReadLine());
            som = getal1 + getal2;
            Console.WriteLine(getal1 + " + " + getal2 + " = " + som);
            som = getal1 - getal2;
            Console.WriteLine(getal1 + " - " + getal2 + " = " + som);
            som = getal1 * getal2;
            Console.WriteLine(getal1 + " x " + getal2 + " = " + som);
            som = getal1 / getal2;
            Console.WriteLine(getal1 + " / " + getal2 + " = " + som);
            som = getal1 % getal2;
            Console.WriteLine(getal1 + " mod " + getal2 + " = " + som);
            Console.ReadLine();
        }
    }
}
