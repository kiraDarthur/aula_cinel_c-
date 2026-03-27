using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadetres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variavel
            int modulo;

            Console.WriteLine("Escreva um numero");
            modulo = Convert.ToInt32(Console.ReadLine());

            if (modulo % 2 == 0)
            {
                Console.WriteLine("Número par");
            }
        }
    }
}
