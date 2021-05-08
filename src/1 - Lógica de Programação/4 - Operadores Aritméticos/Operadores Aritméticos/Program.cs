using System;

namespace Operadores_Aritméticos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escreva a fórmula de Bhaskara e execute em console mostrando os resultados de ambas as raízes. O projeto tem como finalidade o estudo de operadores aritiméticos.");


            int a = 1, b = -3, c = -4;
            double delta = Math.Pow(b, 2) - (4 * a * c);
            double bhaskara = Math.Sqrt(delta);
            double X1 = (-b + bhaskara) / (2 * a);
            double X2 = (-b - bhaskara) / (2 * a);
            Console.WriteLine(X1 + " e " + X2) ;
        }
    }
}
