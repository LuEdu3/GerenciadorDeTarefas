using Tarefas;
using Layout;
Console.Clear();
while (true)
{
    Formatacao.ImprimirCabecalho();
    if (int.TryParse(Console.ReadLine(), out int opcao))
    {
        switch (opcao)
        {
            case 1:
                GerenciarTarefas nt2 = new GerenciarTarefas();
                nt2.AdicionarTarefa();
                break;
        }
    }
}
