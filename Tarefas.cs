using System.Data.Common;

namespace Tarefas
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluido { get; set; }

        public Tarefa(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Concluido = false;
        }

        public void ExibirTarefa()
        {
            Console.Write("Tarefas:\n");
            Console.WriteLine($"[\t{(Concluido ? "X" : " ")}] ID: {Id} - {Descricao} ");
        }
    }
}