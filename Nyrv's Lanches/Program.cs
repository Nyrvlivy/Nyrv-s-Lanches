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
            struct Combo
            {
            public string hamburguer;
            public string batata;
            public string bebida;

            public Combo(string hamburguer, string batata, string bebida)


                List<Combo> combos = new List<Combo>();
            combos.Add(new Combo("Picanha", "BatataFrita", "Bebida");
            combos.Add(new Combo("Duplo", "BatataFrita", "Bebida");
            combos.Add(new Combo("Cheddar", "BatataFrita", "Bebida");
            combos.Add(new Combo("Frango", "BatataFrita", "Bebida");
            combos.Add(new Combo("Peixe", "BatataFrita", "Bebida");
            combos.Add(new Combo("Veggan", "BatataFrita", "Bebida");
            }

        Console.Write("Insira seu nome:");
            Console.WriteLine();
            string nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Bem-vindo(a) ao sistema de atendimento online da Nyrv's Lanches, prazer em recebê-lo(a), {nome}!");
            Console.WriteLine();

            Console.WriteLine($"Para iniciar seu pedido, selecione as opções de acordo com a sua preferência!" +
                              $"\n");
            

            Console.WriteLine($"\nGostaria de adquirir um de nossos deliciosos combos com hamburguer, batata-frita e bebida? (são mais em conta, no tamanho do seu bolso e da sua fome)? Digite s/n para cotinuar" +
                              $"\n");

            string resposta1 = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (resposta1 == "s")
            {
                Console.WriteLine($"Boa escolha, esses são os nossos combos");
            }

            else
            {

                if (resposta1 == "n")
                Console.WriteLine("Okay, vamos efetuar seu pedido por partes");

                else
                {
                    
                   Console.WriteLine("Por favor, utilize apenas a letra 's' ou 'n' para responder!");
                }
            }
           













            Console.ReadKey();

        }
    }
}
