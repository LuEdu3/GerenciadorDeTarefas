using System.ComponentModel;
using System.Data.Common;
using System.Formats.Tar;
using System.Reflection.PortableExecutable;
using Tarefas;
using Layout;

namespace GerenciarTarefas
{

    public class Gerenciar
    {
        // private static readonly IEnumerable<object> tarefasLista;
        private List<Tarefa> tarefasLista = new List<Tarefa>();
        private int IdCount = 1;

        public void AdicionarTarefa()
        {
        return2:
            Console.Write("Adicionar tarefa: ");
            string adicionarLista = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(adicionarLista))
            {
                Formatacao.Cor("Não é possivel inserir tarefas vazias!\n", ConsoleColor.Red);
                goto return2;
            }
            else
            {
                tarefasLista.Add(new Tarefa(IdCount++, adicionarLista));
                Formatacao.Cor("Tarefa Adicionada\n", ConsoleColor.Green);
            }

        }
        public void ListarTarefas()
        {
            if (tarefasLista.Count == 0)
            {
                Formatacao.Cor("Nao há tarefas\n", ConsoleColor.White);

            }
            else
            {
                Formatacao.Cor("Tarefas:\n", ConsoleColor.White);
                foreach (var tarf in tarefasLista)
                {
                    Formatacao.Cor($"{tarf.ExibirTarefa}\n", ConsoleColor.Yellow);
                }
            }
        }
        public void ConcluirTarefa()
        {
        return3:
        return4:
            Console.Write("\nDigite o Id da tarefa concluída: ", ConsoleColor.White);
            if (!int.TryParse(Console.ReadLine(), out int concluirId))
            {
                Formatacao.Cor("Tarefa não encontrada\n", ConsoleColor.Red);
                goto return3;
            }
            else
            {
                Tarefa tarefaRetorno = tarefasLista.Find(t => t.Id == concluirId);
                if (tarefaRetorno != null)
                {
                    tarefaRetorno.Concluir();
                    Formatacao.Cor($"Tarefa concluída\n", ConsoleColor.Green);
                }
                else
                {
                    Formatacao.Cor("\nTarefa não encontrada! Verifique o Id informado.\n", ConsoleColor.Red);
                    goto return4;
                }
            }
        }
        public void RemoverTarefa()
        {
            return5:
            return6:
            Console.Write("\nDigite o Id da tarefa que deseja remover: ", ConsoleColor.White);
            if (!int.TryParse(Console.ReadLine(), out int removerId))
            {
                Formatacao.Cor("\nTarefa não encontrada\n", ConsoleColor.Red);
                goto return5;
            }
            else
            {
                Tarefa tarefaRetorno = tarefasLista.Find(t => t.Id == removerId);
                if (tarefaRetorno != null)
                {
                    tarefasLista.Remove(tarefaRetorno);
                    Formatacao.Cor($"\nTarefa removida\n", ConsoleColor.Green);
                }
                else
                {
                    Formatacao.Cor("\nTarefa não encontrada! Verifique o Id informado.\n", ConsoleColor.Red);
                    goto return6;
                }
            }

        }
    }
}
