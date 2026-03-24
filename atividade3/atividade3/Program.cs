using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1,nota2,nota3, media;
            

            Console.WriteLine("Por favor insira a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor insira a primeira nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor insira a primeira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            
            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A média das notas, {nota1:F2},{nota2:F2},{nota3:F2} é: {media:F2}");
        }
    }
}
