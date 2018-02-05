using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores relacionales.
            /*  > Mayor que
             *  < Menor que
             *  >= Mayor o igual que
             *  <= Menor o igual que
             *  == es igual
             *  != es diferente
             */

            //Operadores logicos.
            /*  && and
             *  || or
             *  !  not
             *  == es igual
             *  != es diferente
             */ 

            double peso;
            byte edad;

            Console.WriteLine("Digita tu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digita tu edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Clear();

            if (peso < 100 && edad >= 15)
            {
                Console.WriteLine("Tu peso es normal");
            }

            Console.ReadKey();
        }
    }
}
