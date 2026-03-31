using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Estrutura utilizada quando não sabemos o fim do ciclo

            // while(condiçao){}

            int  num, i=0,soma =0;
            double media;

            Console.Write("Introduza um valor:  ");
            num = Convert.ToInt32(Console.ReadLine());
            soma = num;

            while (num != 0)
            {
                Console.WriteLine("Estou dentro do cicl0");
                Console.Write("Introduza um valor:  ");
                num = Convert.ToInt32(Console.ReadLine());
                soma = soma + num;
                i++;
            }
           
            media = soma/i-1; 
            Console.WriteLine("Estou fora do ciclo");

        }

    }
}
