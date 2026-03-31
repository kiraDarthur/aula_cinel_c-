using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estrutura reptitiva que testa a condição final. O bloco é execultado semppre uma vez

            int op;

            do
            {
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multipicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                op = Convert.ToInt32(Console.ReadLine());






            } while (op != 0);


        }
    }
}
