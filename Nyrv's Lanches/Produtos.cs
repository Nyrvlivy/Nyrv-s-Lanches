using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyrv_s_Lanches
{
    public class Produtos : IEquatable<Produtos> //Pois estou trabalhando com uma List<T>
    {
        public string PartNome { get; set; }
        public int PartId { get; set; }
        public float PartPreco { get; set; }


        public override string ToString() //Escrever o mesmo método com parametros diferentes
        {
            return "|  ID: " + PartId + "  |  R$" + PartPreco + "  |  Descrição: " + PartNome; //Como é visível no sistema
        }
        public override bool Equals(object objeto)
        {
            if (objeto == null) return false;
            Produtos objAsPart = objeto as Produtos;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals(Produtos outro)
        {
            if (outro == null) return false;
            return (this.PartId.Equals(outro.PartId));
        }
    }
    public class ListaProduto
    {
        public static void Main()
        {
            List<Produtos> parts = new List<Produtos>(); // Lista de itens e características
            parts.Capacity = 9999; //Limitando a quantidade de produtos para não ultrpassar o id de 4 dígitos

            //Nome, ID e Preço de cada combo | ID de 9999 até 8499 é para combos, após esse valor, só para produtos isolados.
            parts.Add(new Produtos() { PartNome = "Combo Picanha    ", PartId = 8499, PartPreco = 31.99f });
            parts.Add(new Produtos() { PartNome = "Combo Bacon      ", PartId = 9599, PartPreco = 30.99f });
            parts.Add(new Produtos() { PartNome = "Combo Cheddar    ", PartId = 9699, PartPreco = 29.99f });
            parts.Add(new Produtos() { PartNome = "Combo Ovo        ", PartId = 9799, PartPreco = 28.99f });
            parts.Add(new Produtos() { PartNome = "Combo Frango     ", PartId = 9849, PartPreco = 26.99f });
            parts.Add(new Produtos() { PartNome = "Combo Peixe      ", PartId = 9899, PartPreco = 26.99f });
            parts.Add(new Produtos() { PartNome = "Combo Veggan     ", PartId = 9949, PartPreco = 34.99f });

            Console.WriteLine();

        // PAINEL DE FERRAMENTA

        painel:
            {
                Console.WriteLine();
                Console.WriteLine($"\n>>>>ESSE É O PAINEL DE FERRAMENTAS!<<<<" +
                                  $"\nAqui você pode manipular todos os produtos cadastrados e buscar a informação que precisa!" +
                                  $"\nAbaixo estão listadas as ferramentas que você tem acesso! Por favor, selecione o número de uma opção:" +
                                  $"\n" +
                                  $"\n[1] - Informações sobre a tabela de Produtos;" +
                                  $"\n[2] - Produtos cadastrados (ID, Preço e Descrição);" +
                                  $"\n[3] - Buscar produto por ID;" +
                                  $"\n[4] - Cadastrar produtos;" +
                                  $"\n[5] - Alterar propriedades de produtos;" +
                                  $"\n[6] - Remover item da tabela;" +
                                  $"\n");

                int opcaoPainel = int.Parse(Console.ReadLine());


                // FERRAMENTA 1

                Console.WriteLine("\nLotação máxima de produtos:         {0}u", parts.Capacity); //Quantidade máxima de produtos na lista e no inventário.
                Console.WriteLine("Quantidade de produtos cadastrados: {0}", parts.Count); //Quantidade de produtos cadastrados
                Console.WriteLine();

                // FERRAMENTA 2 - VISUALIZAR

                foreach (Produtos aPart in parts)
                {
                    Console.WriteLine(aPart);
                }

                // FERRAMENTA 3 - BUSCA POR ID E PRODUTO

                while (true)

                {

                    Console.WriteLine();
                    Console.WriteLine("\nDeseja efetuar uma busca por ID de algum produto ou combo? Digite s/n");
                    string r3 = Console.ReadLine().ToLower();
                    Console.WriteLine();

                    if (r3 == "s")
                    {
                        while (true)
                        {
                            Console.WriteLine("Digite o valor do ID, com 4 números:");
                            int valorID = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nContém produto com o seguinte ID {0}: {1}", valorID, parts.Contains(new Produtos { PartId = valorID }));
                            // LEMBRETE: CONSEGUIR LOCALIZAR DESCRIÇÃO DO PRODUTO E PREÇO PELO ID

                            Console.WriteLine("\nDeseja buscar por outro ID? Digite s/n");
                            string r4 = Console.ReadLine().ToLower();
                            Console.WriteLine();
                            if (r4 == "s")
                            {
                                break;
                            }
                            else if (r4 == "n")
                            {
                                Console.WriteLine("Quer voltar ao Painel de Ferramentas? Digite s/n");
                                string r9 = Console.ReadLine().ToLower();

                                if (r9 == "s") goto painel;
                                else Environment.Exit(0);
                            }

                            else
                            {
                                Console.WriteLine("Quer voltar ao Painel de Ferramentas? Digite s/n");
                                goto painel;
                            }

                        }
                    }
                    else if (r3 == "n")
                    {
                        Console.WriteLine("Quer voltar ao Painel de Ferramentas? Digite s/n");
                        string r6 = Console.ReadLine().ToLower();
                        if (r6 == "s") goto painel;
                        else
                        {
                            if (r6 == "n")
                            {
                                Console.WriteLine("Okay, você foi desconectado do sistema e deverá efetuar autenticação para acessar novamente! Até...");
                                Environment.Exit(0);
                            }
                        }
                    }
                    else
                    {
                        Console.Write("Por favor! Irei perguntar novamente! Pressione qualquer tecla para continuar!");
                    }
                }


            }

            
        }
    }
}



