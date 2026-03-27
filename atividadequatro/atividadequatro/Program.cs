using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace atividadequatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;
            
            Console.WriteLine("Escreva a nota de 0 a 20");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 10)
            {
                Console.WriteLine("Aprovado");
            }

        }
    }
}
