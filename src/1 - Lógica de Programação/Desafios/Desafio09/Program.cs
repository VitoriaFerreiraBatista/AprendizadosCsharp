using System;

namespace Desafio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor inteiro para A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Informe um valor inteiro para B: ");
            int B = int.Parse(Console.ReadLine());

            if (A == 0 || B == 0 || B % A == 0 || A % B == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}
