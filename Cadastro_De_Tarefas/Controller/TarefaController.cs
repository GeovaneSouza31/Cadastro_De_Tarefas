using System;
using System.Collections.Generic;
using Cadastro_De_Tarefas.Model;

namespace Cadastro_De_Tarefas.Controller
{
    internal class TarefaController
    {
        private List<Tarefa> ListaDeTarefas = new List<Tarefa>();  

        public void AdicionarTarefa(string nome, DateTime data, string status)
        {
            // Usa o construtor com parâmetros da classe Tarefa
            Tarefa nova = new Tarefa(nome, data, status);

            ListaDeTarefas.Add(nova);
        }

        public List<Tarefa> ObterTarefas()
        {
            return ListaDeTarefas;
        }
    }
}
