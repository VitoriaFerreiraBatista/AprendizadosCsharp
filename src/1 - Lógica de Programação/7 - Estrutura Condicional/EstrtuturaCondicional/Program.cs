using System;

namespace EstrtuturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura condicional simples
            Console.WriteLine("Informe um valor inteiro e verifique apenas se o mesmo é um valor par.");

            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("O valor digitado é par!");
            }

            Console.WriteLine("Informe um valor inteiro e verifique apenas se o mesmo é um valor ímpar.");

            int z = int.Parse(Console.ReadLine());

            if (z % 2 != 0)
            {
                Console.WriteLine(" O valor digitado é impar!");
            }


            //Estrutura condicional composta
            Console.WriteLine("Informe um valor inteiro e verifique se o mesmo é um valor par ou impar.");

            int y = int.Parse(Console.ReadLine());
            if (y % 2 == 0)
            {
                Console.WriteLine("O valor digitado é par!");


            }
            else
            {
                Console.WriteLine(" O valor digitado é impar!");
            }



            //Estrutura condicional encadeada
            Console.WriteLine("Informe um valor inteiro e verifique se o mesmo é um valor negativo, nulo ou positivo.");
            int v = int.Parse(Console.ReadLine());
            if (v < 0)
            {
                Console.WriteLine("O valor digitado é negativo!");
            }
             else if (v == 0){

                Console.WriteLine(" O valor digitado é nulo!");
            }

            else
            {
                Console.WriteLine("O valor digitado é positivo!");
            }

            

        }
    }
}
