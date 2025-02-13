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
            Console.Write("Adicionar tarefa: ");
            string adicionarLista = Console.ReadLine();
            tarefasLista.Add(new Tarefa(IdCount, adicionarLista));
            IdCount++;

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
            Console.Write("\nDigite o Id da tarefa concluída: ", ConsoleColor.White);
            int concluirId = int.Parse(Console.ReadLine());
            Tarefa tarefaRetorno = tarefasLista.Find(t => t.Id == concluirId);
            if(tarefaRetorno != null)
            {
                tarefaRetorno.Concluir();
                Formatacao.Cor($"Tarefa concluída\n", ConsoleColor.Green);
            }
            else
            {
                Formatacao.Cor("Tarefa não encontrada", ConsoleColor.White);
            }
        }
        public void RemoverTarefa()
        {
            Console.Write("Digite o Id da tarefa que deseja remover: ", ConsoleColor.White);
            int removerId = int.Parse(Console.ReadLine());
            Tarefa tarefaRetorno = tarefasLista.Find(t => t.Id == removerId);
            if(tarefaRetorno != null)
            {
                tarefasLista.Remove(tarefaRetorno);
                Formatacao.Cor($"Tarefa concluída\n", ConsoleColor.Green);
            }
            else
            {
                Formatacao.Cor("Tarefa não encontrada", ConsoleColor.White);
            }
        }
    }
}
