using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAsignacion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte edad = 20;

            //Se puede aser de esta manera o usando operadores de asignacion
            //edad = Convert.ToByte(edad + 10);
            //Operadores de asignacion      =, +=, -=, *=, /=
            edad += 10;

            Console.WriteLine("Tu edad es : " + edad);

            Console.ReadKey();
        }
    }
}
