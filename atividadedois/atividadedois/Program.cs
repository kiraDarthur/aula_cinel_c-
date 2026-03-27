using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadedois
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variavel
            int idade;

            Console.Write("Escreva a  sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 18){
                Console.WriteLine("Maior de idade");
            }
        }
    }
}
