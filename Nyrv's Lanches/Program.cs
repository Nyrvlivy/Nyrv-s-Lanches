using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyrv_s_Lanches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Insira seu nome:");
            Console.WriteLine();
            string nome = Console.ReadLine();

            Console.WriteLine($"Bem-vindo(a) ao sistema de atendimento online da Nyrv's Lanches, prazer em recebê-lo(a), {nome}!");

            Console.WriteLine($"Para iniciar seu pedido, selecione as opções de acordo com a sua preferência!" +
                                $"\nGostaria de adquirir um de nossos deliciosos combos? (são mais em conta, no tamanho do seu bolso e da sua fome)? Digite s/n para cotinuar" +
                                $"\n");
            string resposta1 = Console.ReadLine();
            if (resposta1 != "s","n")
                Console.WriteLine("Por favor, utilize apenas a letra 's' ou 'n' para responder!");
            else
            {
                if (resposta1 == "s")
                    Console.WriteLine(Boa escolha, esses são os nossos combos);
                else
                    Console.WriteLine(Okay, vamos efetuar seu pedido por partes);
            }
           













            Console.ReadKey();

        }
    }
}
