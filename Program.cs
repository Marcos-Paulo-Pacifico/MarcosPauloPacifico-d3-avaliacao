using MarcosPauloPacifico_d3_avaliacao.Models;
using MarcosPauloPacifico_d3_avaliacao.Repositories;

namespace MarcosPauloPacifico_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            UserRepository user = new();
            do
            {
                Console.WriteLine("Qual opção deseja executar?:");
                Console.WriteLine("1 - Acessar\n2 - Cancelar");
                option = Console.ReadLine();

                if(option == "1")
                {
                    Console.WriteLine("Insira seu email:");
                    var email = Console.ReadLine();
                    Console.WriteLine("Insira sua senha:");
                    var pwd = Console.ReadLine();

                    foreach(var userRead in user.ReadAll())
                    {
                        if(userRead.Email == email && userRead.Password == pwd)
                        {
                            Console.WriteLine("Login Efetuado com sucesso!");
                            user.CreateFolderFile();
                            user.Create(userRead);
                        }
                    }
                }

            } while (option != "2");
            
        }
    }
}