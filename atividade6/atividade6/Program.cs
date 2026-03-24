using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distPercorida,tempoGasto,velocidade,conversaoDist,conversaTempo,velocidadeMedia;
            

            Console.WriteLine("Qual a distância percorrida (km)?");
            distPercorida = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual foi o tempo gasto(m)?");
            tempoGasto = Convert.ToDouble(Console.ReadLine());


            conversaoDist = distPercorida * 1000;
            conversaTempo = tempoGasto * 60;

            velocidadeMedia = conversaoDist / conversaTempo;

            Console.WriteLine($"A velocidade média é {velocidadeMedia:F2}m/s");






             
        }
    }
}
