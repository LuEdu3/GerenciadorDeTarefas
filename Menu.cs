namespace GerenciadorDeTarefas
{
    class Menu
    {
        public static void TextoCentral()
        {
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║     gerenciador de tarefas     ║");
            Console.WriteLine("╚════════════════════════════════╝");
        }
        public static void Mensagem()
        {
            Console.Write("\n1 - Adicionar Tarefa");
            Console.Write("\n2 - Listar Tarefas");
            Console.Write("\n3 - Concluir Tarefa");
            Console.Write("\n4 - Remover Tarefa");
            Console.Write("\n0 - Sair");
        }
    }
}