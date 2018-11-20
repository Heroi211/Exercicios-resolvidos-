using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1
{
    class televisoes : Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public televisoes(int Id, string Nome, double Preco, int Quantidade)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public override double CalculaValor()
        {
            double valortotal;
            return valortotal = Quantidade * Preco;
        }
        public override string ToString()
        {
            return "A televisão de Id: " + Id
                + "/ nome: " + Nome
                + "/ R$" + Preco.ToString("F2");
        }
    }
}
