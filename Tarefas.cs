using System.Data.Common;
using Layout;

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
        public void Concluir()
        {
            Concluido = true;
        }
        public string ExibirTarefa => $"[{(Concluido ? "X" : " ")}] ID: {Id.ToString()} - {Descricao}";
    }
}