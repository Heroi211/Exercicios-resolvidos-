using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1
{
    class Program
    {
        public static List<Equipamento> equip = new List<Equipamento>();
        public static int n;

        static void Main(string[] args)
        { 
            try
            {
                Console.WriteLine("Quantos equipamentos pretende cadastrar?");
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado");
                Console.WriteLine(e.Message);
            }
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Vai cadastrar computadores ou televisoes? C ou T");
                    char resposta = char.Parse(Console.ReadLine());

                    if (resposta == 'C' || resposta == 'c')
                    {
                        Equipamento X = telas.TelaComp();
                        double valorComp = X.CalculaValor();
                        Console.WriteLine(X);
                        Console.WriteLine("O valor total dos computadores é " + valorComp.ToString("F2"));
                    }
                    else if (resposta == 't' || resposta == 'T')
                    {

                        Equipamento Y = telas.TelaTele();
                        double valorComp = Y.CalculaValor();
                        Console.WriteLine(Y);
                        Console.WriteLine("O valor total dos computadores é " + valorComp.ToString("F2"));
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Caracter inválido: ");
                Console.WriteLine(e.Message);
            }
            for (int i = 0;i< equip.Count;i++)
            {
                Console.WriteLine("Os equipamentos cadastrados são: " + equip[i]);
            }
            Console.ReadLine();
        }
    }
}
