using System.ComponentModel;
using System.Data.Common;
using System.Formats.Tar;
using Tarefas;

namespace GerenciarTarefas
{
    
    public class Gerenciar
    {
        private static readonly IEnumerable<object> tarefasLista;

        public static void AdicionarTarefa()
        {   
            List<string> tarefasLista = new List<string>();
            Console.WriteLine("Adicionar tarefa: ");
            string adicionarLista = Console.ReadLine();
            tarefasLista.Add(adicionarLista);

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
