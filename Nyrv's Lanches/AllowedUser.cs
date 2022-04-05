/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyrv_s_Lanches
{
    internal class AllowedUser1
    { 
    struct AllowedUser
    {
        public string Nome;
        public string Cargo;
        public int Idade;
        public AllowedUser(string Nome, string Cargo, int Idade)
            {
                this.Nome = Nome;
                this.Cargo = Cargo;
                this.Idade = Idade;
            }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome : {Nome} \nCargo: {Cargo} \nIdade   : {Idade}");
        }
    }
        static void Main(string[] args)
        {
            List<AllowedUser> listaAllowedUsers = new List<AllowedUser>();                  //Listar funcionários permitidos
                        
                listaAllowedUsers.Add(new AllowedUser("Paulo", "Gerente", 22));
                listaAllowedUsers.Add(new AllowedUser("Roberta", "Vendedor", 23));
                listaAllowedUsers.Add(new AllowedUser("Camila", "Vendedor", 24));
                listaAllowedUsers.Add(new AllowedUser("Thiago", "Vendedor", 21));
                listaAllowedUsers.Add(new AllowedUser("Matheus", "Auxiliar", 19));
                listaAllowedUsers.Add(new AllowedUser("Charles", "Auxiliar", 18));

            foreach (AllowedUser allowedUser in listaAllowedUsers)
            {
                allowedUser.ExibirDados(); { }

            }




            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
*/