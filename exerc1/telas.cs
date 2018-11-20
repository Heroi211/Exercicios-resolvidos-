using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1
{
    class telas
    {
        public static computadores TelaComp()
        {
            Console.WriteLine("Digite o Id do computador: ");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do computador: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do computador : ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            return new computadores(Id, nome, preco, quantidade);
        }

        public static televisoes TelaTele()
        {
            Console.WriteLine("Digite o Id da televisão: ");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da televisão: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o preço da televisão : ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            return new televisoes(Id, nome, preco, quantidade);
        }
    }
}
