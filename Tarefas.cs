using System.Data.Common;

namespace Tarefas
{
    class Tarefa
    {

            public int Id { get; set; }  
            public string Descricao { get; set; }

            public bool Concluido { get ; set; }

        public void Tarefa(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Concluido = false;
        }
        public void ExibirTarefa()
        {

        }
    }
}