using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menu de opções
            string opcao;
            int num1,num2,soma, subtrair;
            do
            {
                Console.WriteLine("1-Somar\n2-Subtrair\n0-Sair");
                Console.WriteLine("Escolha uma opção: ");
                opcao = Console.ReadLine();
                //Console.Clear();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Indique 1 número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique 1 número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        soma = num1 + num2;
                        Console.WriteLine($"Soma de {num1} + {num2} = {soma}");
                        break;
                    
                    case "2":
                        Console.WriteLine("Indique 1 número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique 1 número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        subtrair = num1 - num2;
                        Console.WriteLine($"Subtração de {num1} - {num2} = {subtrair}");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }

            } while (opcao != "0");
            
        }
    }
}
