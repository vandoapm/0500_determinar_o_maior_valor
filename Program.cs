using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0500_determinar_o_maior_valor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Determinar o maoir valor");

            Console.WriteLine();

            Console.Write("Insira o 1º valor: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Insira o 2º valor: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine();

            if (a > b)
            {

                Console.Write(a + " é maior que " + b);

            } 
            else if (a < b)
            {

                Console.Write(b + " é maior que " + a);

            }
            else
            {

                Console.Write(a + " e " + b + " são iguais.");

            }

            Console.ReadLine();
        }
    }
}
