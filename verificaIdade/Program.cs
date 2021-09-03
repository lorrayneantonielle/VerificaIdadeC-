using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade =int.Parse(Console.ReadLine());

          

            if (idade >= 1 && idade <= 11)
            {
                Console.WriteLine("Criança.");
            }else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Adolescente.");
            }else if (idade >= 19 && idade <= 64)
            {
                Console.WriteLine("Adulto.");
            }else
            {
                Console.WriteLine("Idoso.");
            }

            Console.ReadLine();
        }
    }
}
