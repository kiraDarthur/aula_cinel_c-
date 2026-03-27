using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeseis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperatura;

            Console.WriteLine("Qual a temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());

            if (temperatura < 15)
            {
                Console.WriteLine("Está frio");
            }
            else
            {
                Console.WriteLine("Está quente");
            }
        
        }
    }
}
