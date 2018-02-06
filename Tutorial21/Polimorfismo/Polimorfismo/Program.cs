using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect = new Rectangulo();
            rect.Area(34,56);
            Triangulo tria = new Triangulo();
            tria.Area(34,56);

            Console.ReadKey();
        }
    }
}
