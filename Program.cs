using Layout;
using GerenciarTarefas;
using Tarefas;
using System.Net.Sockets;
Console.Clear();
Gerenciar opc1 = new Gerenciar();
int opcao = 0;
do
{
return1:
    Formatacao.ImprimirCabecalho();
    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Formatacao.Cor("Opção invalida.\n", ConsoleColor.Red);
         goto return1;
    }
    else
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

            case 0:
                Console.Clear();
                Formatacao.Cor("\n\tPrograma encerrado!",ConsoleColor.Yellow);
                break;
            default:
                Console.Clear();
                Formatacao.Cor("\tAção inválida!",ConsoleColor.Red);
                break;
        }
    }
}
while (opcao != 0);

