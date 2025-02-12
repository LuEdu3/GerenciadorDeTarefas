using System.Security.Cryptography.X509Certificates;

namespace Layout
{
    class Formatacao
    {

        public static void ImprimirCabecalho()
        {
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║     gerenciador de tarefas     ║");
            Console.WriteLine("╚════════════════════════════════╝");

            Console.Write("\n1 - Adicionar Tarefa");
            Console.Write("\n2 - Listar Tarefas");
            Console.Write("\n3 - Concluir Tarefa");
            Console.Write("\n4 - Remover Tarefa");
            Console.Write("\n0 - Sair\n");

            Console.WriteLine($"\nEscolha uma opção: ");
        }

        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}