using System;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a hora inicial do jogo: ");
            double inicio = double.Parse(Console.ReadLine());
            Console.Write("Informe a hora final do jogo: ");
            double fim = double.Parse(Console.ReadLine());

            if (inicio == fim)
            {
                Console.WriteLine("O jogo durou 24 horas");
            }

            else if (fim < inicio)
            {
                double resultado = (fim + 24) - inicio;
                Console.WriteLine("O jogo durou " + resultado + " horas");
            }
            else
            {
                double resultado = fim - inicio;
                Console.WriteLine("O jogo durou " + resultado + " horas");
            }
        }
    }
}
