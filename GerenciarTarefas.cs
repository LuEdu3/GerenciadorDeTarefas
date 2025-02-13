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
            Console.WriteLine("Adicionar tarefa: ");
            string adicionarLista = Console.ReadLine();
            tarefasLista.Add(new Tarefa(IdCount, adicionarLista));
            IdCount++;

        }
        public void ListarTarefas()
        {
            if (tarefasLista.Count == 0)
            {
                Formatacao.Cor("Nao há tarefas", ConsoleColor.White);

            }
            else
            {
                Formatacao.Cor("Tarefas: ", ConsoleColor.White);
                foreach (var tarf in tarefasLista)
                {
                    Console.WriteLine($"{tarf}\n");

                }
            }
        }
    }
}
