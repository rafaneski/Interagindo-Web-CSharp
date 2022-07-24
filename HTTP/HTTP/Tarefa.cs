using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
    internal class Tarefa
    {
        //Baseando-se em: 
        //"userId": 1,
        //"id": 1,
        //"title": "delectus aut autem",
        //"completed": false

        //Deve ter o mesmo tipo e nome:
        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine("");
            Console.WriteLine($"User id: {userId}");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Finalizou?: {completed}");
            Console.WriteLine("");
            Console.WriteLine("========================");
        }
    }
}
