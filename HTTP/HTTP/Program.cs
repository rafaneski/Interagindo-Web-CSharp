using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
using System.Net;
using Newtonsoft.Json;

namespace HTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reqlist();
            ReqUnica();
            Console.ReadLine();
        }

        static void ReqList() //Requisicao em lista
        {
            //Requisicao
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/");
            requisicao.Method = "GET";

            using (var resposta = requisicao.GetResponse())
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object dados = leitor.ReadToEnd();

                //Console.WriteLine(dados.ToString());
                List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(dados.ToString());

                foreach (Tarefa tarefa in tarefas)
                {
                    tarefa.Exibir();
                }

                stream.Close();
                resposta.Close();
            }
        }

        static void ReqUnica() //Requisicao unica
        {
            //Requisicao
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/5"); //Passe o id especifico que vc quer
            requisicao.Method = "GET";

            using (var resposta = requisicao.GetResponse())
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object dados = leitor.ReadToEnd();

                //Console.WriteLine(dados.ToString());
                Tarefa tarefa = JsonConvert.DeserializeObject<Tarefa>(dados.ToString());

                tarefa.Exibir();

                stream.Close();
                resposta.Close();
            }
        }
    }
}
