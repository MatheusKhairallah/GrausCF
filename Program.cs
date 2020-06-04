using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um valor que corresponderá em °C e será convertido para °F");
            Console.Write("°C: ");
            double C=Convert.ToDouble(Console.ReadLine());
            double CF= C * 1.8 + 32;
            Console.Clear();
            Console.WriteLine($"{C}°C em °F é={CF}");
        }
    }
}
