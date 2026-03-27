using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Escreva o numero Inteiro");
            numero = Convert.ToInt32(Console.ReadLine());


            if (numero > 0)
            {
                Console.WriteLine("Número Positivo");
            }
        }
    }
}
