using Tarefas;
using Layout;
using GerenciarTarefas;
Console.Clear();
while (true)
{
    Formatacao.ImprimirCabecalho();
    if (int.TryParse(Console.ReadLine(), out int opcao))
    {
        switch (opcao)
        {
            case 1:
            Gerenciar.AdicionarTarefa();
            break;

            case 2:
            Gerenciar.ListarTarefas();
            break;

            // case 3:
            // Gerenciar.AdicionarTarefa();
            // break;

            // case 4:
            // Gerenciar.AdicionarTarefa();
            // break;

            // case 0:
            // Gerenciar.AdicionarTarefa();
            // break;
        }
    }
}

