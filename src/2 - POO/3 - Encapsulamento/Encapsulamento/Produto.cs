using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Produto
    {

        // Ordem sugerida para criar classe:
        // Atributos privados
        // Proprioedades autoimplementadas
        // Construtores
        // Propriedades customizadas
        // Outros métodos da classe

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null)
                    _nome = value;
            }
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
            return _nome + ", R$: " + Preco.ToString("F2") + ", " + Quantidade + " unidades" + ", Total R$: " + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
