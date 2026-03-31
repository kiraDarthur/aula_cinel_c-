using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fichan3_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i,mult;

            Console.Write("Escreva numero inteiro");
            n = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i < 11; i++)
            {
                mult = n * i;
                Console.WriteLine($"{n} * {i} = {mult}");
            }

            

            
        }

    }
}
