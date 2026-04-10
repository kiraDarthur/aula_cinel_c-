using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max, num,min,cont;

            Console.WriteLine("Insira um valor:");
            num = Convert.ToInt32(Console.ReadLine());
            min = num;
            max = num;
            do
            {

                Console.WriteLine("Insira m valor:");
                num = Convert.ToInt32(Console.ReadLine());
                if(num > max)
                {
                    max = num;
                }
                if (num < max)
                {
                    min = num;
                }
                
            }while(num != 0);
            Console.WriteLine($"maximo: {max}");
            Console.WriteLine($"minimo: {min}");  
        
        
        }
    }
}
