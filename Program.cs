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
                Console.WriteLine("1- Acessar\n2- Cancelar");
                option = Console.ReadLine();
            } while (option != "2");
            
        }
    }
}