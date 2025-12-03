using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_De_Tarefas.Controller;

namespace Cadastro_De_Tarefas.Controller
{
    internal class FuncionarioController
    {
        List<string> FuncionariosLista = new List<string>();
        public void CadastrarFuncionario(string nome, DateTime data, string email, int ID)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email))
            {
                return;
            }
            FuncionariosLista.Add(nome);

        }
        public List<string> ListarFuncionario()
        {
            return FuncionariosLista;        
        }


    }
}
