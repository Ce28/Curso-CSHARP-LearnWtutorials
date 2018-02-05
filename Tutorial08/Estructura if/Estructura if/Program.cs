using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estructura if,else y anidada.
            byte juan = 19, pedro = 19;

            if (juan > pedro)
            {
                Console.WriteLine("Juan es mayor que pedro");
            }
            else if (juan < pedro)
            {
                Console.WriteLine("Juan es menor que pedro");
            }
            else
            {
                Console.WriteLine("Juan y pedro tienen la misma edad");
            }




            Console.ReadKey();
        }
    }
}
