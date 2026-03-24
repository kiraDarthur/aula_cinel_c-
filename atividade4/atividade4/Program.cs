using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nHoras,valorH,salBruto,salFinal,filhoBruto;
            int nFilhos;

            Console.WriteLine("Qual o nome do funcinário?");
            nome = Console.ReadLine();
            Console.WriteLine("Quantas horas trabalhou? ");
            nHoras = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quanto recebe por horas? ");
            valorH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantos filhos tem? ");
            nFilhos = Convert.ToInt16(Console.ReadLine());


            salBruto = nHoras + valorH;
            filhoBruto = 0.03 * salBruto * nFilhos;
            salFinal = salBruto + filhoBruto;

            Console.WriteLine($"O funcionario {nome}, trabalhou {nHoras} horas, " +
                $"recebe {valorH}€ por hora, e tem {nFilhos}, logo aufere {salFinal}!! ");





        }

    }


}
