using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Tarefas.Model
{
    internal class Funcionarios
    {
        public string nome { get; set; }
        public DateTime data { get; set; }
        public string email { get; set; }
        public int ID { get; set; }

        public Funcionarios(string nome, DateTime data, string email, int id)
        {
            this.nome = nome;
            this.data = data;
            this.email = email;
            this.ID = id;
        }
    }
}
