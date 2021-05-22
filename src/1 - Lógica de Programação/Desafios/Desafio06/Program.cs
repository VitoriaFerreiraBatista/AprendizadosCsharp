using System;
using System.Globalization;

namespace Desafio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de B: ");
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de C: ");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo = (A * C) / 2;
            double circulo = 3.14159 * Math.Pow(C, 2);
            double trapezio = (A + B) * C / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine("TRIÂNGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture) + " CÍRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture) + " TRAPÉZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture) + " QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture) + " RETÂNGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
