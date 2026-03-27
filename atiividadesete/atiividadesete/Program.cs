using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atiividadesete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;

            Console.WriteLine("Escreva a senha");
            senha = Convert.ToInt32(Console.ReadLine());

            if (senha == 1234)
            {
                Console.WriteLine("Acesso Permitido");
            }
            else
            {

                Console.WriteLine("Acesso Negado");
            }
        
        }
    }
}
