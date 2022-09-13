namespace MarcosPauloPacifico_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
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
                }

            } while (option != "2");
            
        }
    }
}