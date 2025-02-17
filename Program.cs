using Layout;
using GerenciarTarefas;
using Tarefas;
using System.Net.Sockets;
Console.Clear();
Gerenciar opc1 = new Gerenciar();

while (true)
{
    Formatacao.ImprimirCabecalho();
    if (int.TryParse(Console.ReadLine(), out int opcao))
    {
        switch (opcao)
        {
            case 1:
            Console.Clear();
            opc1.AdicionarTarefa();
            break;

            case 2:
            Console.Clear();
            opc1.ListarTarefas();
            break;

            case 3:
            Console.Clear();
            opc1.ListarTarefas();
            opc1.ConcluirTarefa();
            // Console.Clear();
            // opc1.ListarTarefas();
            break;

            case 4:
            Console.Clear();
            opc1.ListarTarefas();
            opc1.RemoverTarefa();
            // Console.Clear();
            // opc1.ListarTarefas();
            break;

            // case 0:
            // Gerenciar.AdicionarTarefa();
            // break;
        }
    }
}

