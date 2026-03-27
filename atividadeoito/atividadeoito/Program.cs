using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeoito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo;

            Console.WriteLine("Digite seu saldo");
            saldo = Convert.ToDouble(Console.ReadLine());

            if (saldo >= 0) 
            {
                Console.WriteLine("Saldo Positivo");   
            }
            else
            {
                Console.WriteLine("Saldo Negativo");
            }

        }
    }
}
