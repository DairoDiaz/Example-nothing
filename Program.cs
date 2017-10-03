using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, suma;
            Console.WriteLine("Ingresa numero");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa numero");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}