using System;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int getal1, getal2, getal3, som;
            Console.Write("Getal 1: ");
            getal1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Getal 2: ");
            getal2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Getal 3: ");
            getal3 = Convert.ToInt16(Console.ReadLine());
            som = getal1 * getal2 * getal3;
            Console.WriteLine(getal1  + " * " + getal2 + " * " + getal3 + " = " + som);
            Console.ReadLine();
        }
    }
}
