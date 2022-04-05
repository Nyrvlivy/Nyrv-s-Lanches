/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyrv_s_Lanches
{
    internal class Program
    {
        public class Funcionario //funcionários autorizados
        {
            public Funcionario() {}

            public string Nome { get; set; }
            public int Idade { get; set; }

            public Funcionario(string nome, int idade)
            {
                this.Nome = nome;
                this.Idade = idade;
            }
        }

        static List<Funcionario> funcionarios;

        static void Main(string[] args)
        {
            funcionarios = new List<Funcionario>();
            funcionarios.Add(new Funcionario("Luiz", 20));
            funcionarios.Add(new Funcionario("Paula", 21));
            funcionarios.Add(new Funcionario("Jorge",22 ));
            funcionarios.Add(new Funcionario("Paula", 24));
            funcionarios.Add(new Funcionario("Camila", 25));
            funcionarios.Add(new Funcionario("Matheus", 24));
            funcionarios.Add(new Funcionario("Lívia", 23));


            //foreach (Funcionario p in funcionarios)
            //{
            //    Console.WriteLine(p.Nome + " " + p.Idade);
            //}

            /*
            struct Combo
            {
                public string Hamburguer;
                public string BatataFrita;
                public string Bebida;
                public Combo(string hamburguer, string batatafrita, string bebida)
                {
                    Hamburguer = hamburguer;
                    BatataFrita = batatafrita;
                    Bebida = bebida;
                }
                public void ExibirDados()
                {
                    Console.WriteLine($"Hamburguer : {Hamburguer} " +
                                      $"\nBatataFrita: {BatataFrita} " +
                                      $"\nBebida     : {Bebida}" +
                                      $"");
                }
            }
            */
            /*
            static void Main(string[] args)
            {
                
                List<Combo> combos = new List<Combo>();
                combos.Add(new Combo("Picanha", "Batata frita", "Bebida"));
                combos.Add(new Combo("Double", "Batata frita", "Bebida"));
                combos.Add(new Combo("Cheddar", "Batata frita", "Bebida"));
                combos.Add(new Combo("Frango", "Batata frita", "Bebida"));
                combos.Add(new Combo("Peixe", "Batata frita", "Bebida"));
                combos.Add(new Combo("Veggan", "Batata frita", "Bebida"));
                foreach (Combo combo in combos)
                {
                    combo.ExibirDados();
                    }
                */



/*


            Console.Write("Insira seu nome para autenticação:");
                Console.WriteLine();
                string nome2 = Console.ReadLine();

                //if nome2 

                Console.WriteLine();

                Console.WriteLine($"Bem-vindo(a) ao sistema de inventário da Nyrv's Lanches, {nome2}!");
                Console.WriteLine();

                Console.WriteLine($"Qual ferramenta deseja utilizar?" +
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

*/

