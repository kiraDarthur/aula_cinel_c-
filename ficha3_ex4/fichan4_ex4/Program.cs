using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fichan4_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,n,divisor;
            n = 21;
            
            for ( i=1; i < n; i++)
            {
                
                if(i % 2 == 0)
                {
                    Console.WriteLine($"São numeros pares {i}");
                }
            }

        }
    }
}
