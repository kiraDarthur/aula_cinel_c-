using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fichan3_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i,soma;
            Console.WriteLine("Escreva o Número Inteiro");
            n = Convert.ToInt32(Console.ReadLine());

            soma = 0;
            for (i = 1 ;i <= n; i++) 
            {
                soma = i + soma;
            }
            Console.WriteLine($"A soma de {n} é igual a {soma}");

        }
    }
}
