using System;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva dois valores que serão somados");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int resultado = valor1 + valor2;
            Console.WriteLine("SOMA = " + resultado);
        }
    }
}
