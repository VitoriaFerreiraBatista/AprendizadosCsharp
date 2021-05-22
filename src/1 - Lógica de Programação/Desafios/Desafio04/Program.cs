using System;
using System.Globalization;

namespace Desafio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite o número do colaborador");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite a carga horária do colaborador");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o valor/hora do colaborador");
            double valorh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horas * valorh;
            Console.WriteLine("Número: "+ numero+" Salário: R$ "+ salario.ToString("F2"));
        }
    }
}
