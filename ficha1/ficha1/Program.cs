using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qt;
            double valor;
            Console.Write("Quanto cafêS você quer?");
            qt = Convert.ToInt32(Console.ReadLine());
            valor = qt + 0.85;

            Console.WriteLine("O valor a pagar e " + valor + " e são " + qt + " cafés");
            Console.WriteLine("O valor a pagar e {0} e são {1} cafés", valor,qt );
            Console.WriteLine($"O valor a pagar e {valor}");
        }
    }
}
