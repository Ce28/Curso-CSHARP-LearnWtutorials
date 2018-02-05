using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclosfor
{
    class Program
    {
        static void Main(string[] args)
        {
            //For simple.
            //for (int x = 1; x <= 5; x++)
            //{
            //    Console.WriteLine(x);
            //}

            //char letra;
            //for (letra = 'a'; letra <= 'z'; letra++ )
            //{
            //    Console.WriteLine(letra);
            //}

            //For anidado.
            //for (int x = 0; x <= 5; x++)
            //{
            //    for (int y = 0; y <= 5; y++)
            //    {
            //        Console.WriteLine("Hola a todos");
            //    }
            //    Console.WriteLine();
            //}

            //Foreach
            string nombre = "CursoDeCSHARP";

            foreach (char item in nombre)
            {
                Console.Write(" " + item + "");
            }


            Console.ReadKey();
        }
    }
}
