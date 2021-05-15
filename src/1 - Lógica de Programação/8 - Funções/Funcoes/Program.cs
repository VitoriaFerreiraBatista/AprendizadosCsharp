using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros inteiros");

            int v = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine(" O maior numero é " + Maior(v,y,l));
        }

        static int Maior(int v1, int v2, int v3)
        {
            if (v1 > v2 && v1 > v3)
            {
                return v1;
            }
            else if (v2 > v3)
            {
                return v2;
            }
            else
            {
                return v3;
            }
        }

    }
}
