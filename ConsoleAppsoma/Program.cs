using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppsoma
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite o primeiro numero");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 * n2;

            Console.WriteLine("O resultado é:" + resultado);

            Console.ReadLine();







        }
    }
}
