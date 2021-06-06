using System;


namespace ConstrutoresESobrecarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this (nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            double P = Preco * Quantidade;
            return P;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;

        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;

        }

        public override string ToString()
        {
            return Nome + ", R$: " + Preco.ToString("F2") + ", " + Quantidade + " unidades" + ", Total R$: " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
