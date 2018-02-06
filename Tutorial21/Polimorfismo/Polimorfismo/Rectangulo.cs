using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Rectangulo
    {
        public void Area(int Base, int Altura)  //Metodo Original
        {
            Console.WriteLine("El area del rectangulo es:" + (Base * Altura));
        }
    }
}
