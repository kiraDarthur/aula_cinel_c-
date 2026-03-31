using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha3_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i,soma;
            Console.WriteLine("digite um numero inteiro: ");
            n = Convert.ToInt32(Console.ReadLine());
            soma = 0;
            for (i=1;i < n ;i++)
            {
                if (i % 2 == 0)
                {
                    soma = i + soma;
                }
            }
            Console.WriteLine($"valor da soma é {soma}");
        }

    }
}
