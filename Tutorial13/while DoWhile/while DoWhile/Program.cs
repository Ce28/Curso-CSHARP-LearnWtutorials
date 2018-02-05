using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //while.
            //bool encender = true;
            //while (encender)
            //{
            //    Console.WriteLine("Hola a todos");  //Bucle infinito
            //}


            //DoWhile.
            bool encender = false;
            do
            {
                Console.WriteLine("Hola a todos");  //Bucle infinito
            } while (encender);

            Console.ReadKey();
        }
    }
}
