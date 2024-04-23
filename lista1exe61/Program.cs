using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exe61
{
    internal class Program
    {
        private static string mediaGeometrica;

        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o segundo valor:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A média geométrica de " + valor1 + " e " + valor2 + " é: " + mediaGeometrica);

            double media = Math.Sqrt(valor1 * valor2);
        }
    }
}
