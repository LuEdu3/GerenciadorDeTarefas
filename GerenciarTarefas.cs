using System.ComponentModel;
using System.Data.Common;
using System.Formats.Tar;
using Tarefas;

namespace GerenciarTarefas
{
    
    public class Gerenciar
    {
        // private static readonly IEnumerable<object> tarefasLista;
            List<Tarefa> tarefasLista = new List<Tarefa>();

        public static void AdicionarTarefa()
        {   
            Console.WriteLine("Adicionar tarefa: ");
            string adicionarLista = Console.ReadLine();
            tarefasLista.Add(new Tarefa(1,adicionarLista));

        }
        public static void ListarTarefas()
        {
            foreach(var tarf in tarefasLista)
            {
                Console.WriteLine($"{tarf}\n");
            }
        }
    }
}
