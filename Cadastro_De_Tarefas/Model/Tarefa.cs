using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Tarefas.Model
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }

        public Tarefa(string nome, DateTime data, string status)
        {
            Nome = nome;
            Data = data;
            Status = status;
        }
    }
}
