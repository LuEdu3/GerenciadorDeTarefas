namespace Layout
{
    class Formatacao
    {

        public static void ImprimirCabecalho()
        {
            Console.WriteLine("\t\t\t\t╔════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t║     gerenciador de tarefas     ║".ToUpper());
            Console.WriteLine("\t\t\t\t╚════════════════════════════════╝");

            Console.Write("\n\t1 - Adicionar Tarefa\n");
            Console.Write("\n\t2 - Listar Tarefas\n");
            Console.Write("\n\t3 - Concluir Tarefa\n");
            Console.Write("\n\t4 - Remover Tarefa\n");
            Console.Write("\n\t0 - Sair\n");

            Console.Write($"\n\tEscolha uma opção: ");
        }

        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }
    }
}