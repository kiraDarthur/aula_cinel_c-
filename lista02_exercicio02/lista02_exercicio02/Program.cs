using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lista02_exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estrutura reoetitiva com inicio e fim certo
            // for(inicio do cliclo;fim do ciclo; incremento(algo que permite o ciclo avançar))

            int i, num,soma,n;
            double media;
            
            soma = 0;

            Console.WriteLine("Quantos números quer ler?");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++ )
            {
                Console.WriteLine($"Introduza o {i}º valor: ");
                num = Convert.ToInt32(Console.ReadLine());
                soma = soma + num;
                
                               
            }
            media = soma / (i-1);
            Console.WriteLine($"O resultaod da soma é {soma}");
            
            Console.WriteLine($"A média ds números é: {media}");
        }

    }
}
