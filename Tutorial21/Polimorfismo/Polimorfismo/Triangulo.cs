using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Triangulo : Rectangulo
    {
        public void Area(int Base, int Altura)  //Metodo Heredado aplicando el polimorfismo
        {
            Console.WriteLine("El area del triangulo es: " + ((Base * Altura) / 2));
        }
    }
}
