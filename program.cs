using System;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            int intGetal1, intGetal2, intSom;
            Console.Write("Geef getal1: ");
            intGetal1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Geef getal2: ");
            intGetal2 = Convert.ToInt16(Console.ReadLine());
            intSom = intGetal1 + intGetal2;
            Console.WriteLine("De som bedraagt: " + intSom.ToString());
            Console.ReadLine();
        }
    }
}
