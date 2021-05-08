using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa em console, que receba do usuário um texto (na mesma linha) " +
                "o primeiro nome, idade, o salario e a primeira letra do nome");
            

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double salario = double.Parse(vet[2]);
            char letra = char.Parse(vet[3]);

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(salario.ToString("F2"));
            Console.WriteLine(letra);

        }
    }
}
