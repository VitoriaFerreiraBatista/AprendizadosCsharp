using System;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite 4 valores inteiros");
            int A = int.Parse(Console.ReadLine()), B = int.Parse(Console.ReadLine()), C = int.Parse(Console.ReadLine()), D = int.Parse(Console.ReadLine());
            int resultado = (A * B) - (C * D);
            Console.WriteLine("DIFERENÇA = " + resultado);
        }
    }
}
