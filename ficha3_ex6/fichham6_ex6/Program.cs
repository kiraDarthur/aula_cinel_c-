using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fichham6_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Escreva um numro inteiro: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 100 )
            {
                Console.WriteLine("Escreva um numro inteiro: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
