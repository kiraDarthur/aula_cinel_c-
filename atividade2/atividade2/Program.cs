using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, apelido;
            Console.WriteLine("Qual seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual seu apelido? ");
            apelido = Console.ReadLine();
            Console.WriteLine($"Bem vindo {nome} {apelido}");
             

        }
    }
}
