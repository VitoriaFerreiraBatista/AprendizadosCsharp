using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa em console, que receba do usuário o texto: banana maçã uva morango e imprima cada palavra dessas palavras em uma linha separada");
            Console.WriteLine("Escreva o texto a ser separado");

            string[] vet = Console.ReadLine().Split(' ');
            string vet1 = vet[0];
            string vet2 = vet[1];
            string vet3 = vet[2];
            string vet4 = vet[3];

            Console.WriteLine(vet1);
            Console.WriteLine(vet2);
            Console.WriteLine(vet3);
            Console.WriteLine(vet4);

        }
    }
}
