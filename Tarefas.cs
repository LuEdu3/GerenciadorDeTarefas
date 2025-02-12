using System.Data.Common;

namespace Tarefas
{
    public class Tarefa
    {
        List<string> nomeDaLista = new List<string>();


        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluido { get; set; }

        public void Tarefas(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Concluido = false;
        }

        public void ExibirTarefa()
        {
            string Texto = Concluido ? "X" : "";
            for(int i = 1; i > Id; Id++)
            {
            Console.Write("Tarefas:\n");
            Id++;
            Console.WriteLine($"[{Texto}] ID: {Id} - {Descricao} ");



            }
        }
    }
}