using System;
using System.Collections.Generic;
using Cadastro_De_Tarefas.Model;



namespace Cadastro_De_Tarefas.Controller
{

    /* Criação da classe (classe essa que não é um molde), que realiza as funcionalidades
 da aplicação*/
      internal class TarefaController
    {
        /* Criação da lista que armazena as instâncias criadas a partir do método AdcionarTarefa
        private List<Tarefa> (Sintaxe) 
        ListaDeTarefas (Nome dado a Lita) = new List<Tarefa>(); (, variavel do tipo tarefa,recebe apenas objetos da classe tarefa,stimg,DateTime,sting)*/
        /* List<Tarefa>();Criação na memória de uma lista ainda com dados nulos */

        private List<Tarefa> ListaDeTarefas =  new List<Tarefa>();

        /*Criação da função que adciona a tarefas ao datagrid*/
        /*
        AdcionarTarefa == nome da função
        Tarefa ==  tipo da variável
        nova == nome da variável
        new Tarefa(nome, data, status); == utiliza o molde criado na classe Tarefa*/



        /*ListaDeTarefas.Add(nova);
         ListaDeTarefas é a lista criada que recebe com a função add do c# os objetos recebidos pela variável "nova"
       
        */
        public void AdicionarTarefa(string nome, DateTime data, string status)
        {
            
            Tarefa nova = new Tarefa(nome, data, status);

            ListaDeTarefas.Add(nova);
        }
        /* Função criada para retornar no datagrid os dados recebidos atráves da função AdcionarTarefa*/
         
        public List<Tarefa> ObterTarefas()
        {
            return ListaDeTarefas;
        }
    }
}
