using System;

namespace Desafio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro para verificarmos se o mesmo é par ou ímpar:");

            int y = int.Parse(Console.ReadLine());
            if (y % 2 == 0)
            {
                Console.WriteLine("PAR");


            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }
        }
    }
}
