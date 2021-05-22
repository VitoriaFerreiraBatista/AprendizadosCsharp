using System;
using System.Globalization;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o diâmetro do círculo");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) / 2;
            double area =  Math.Pow(raio, 2) * 3.14159;
            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
                    
        }
    }
}
