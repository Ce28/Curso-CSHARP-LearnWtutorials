using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Ventana ven = new Ventana();        //Se declara una intancia de la clase Ventana.
            ven.Cerrar();                       //Se llama el metodo Cerrar del objeto creado.

            Console.ReadKey();
        }
    }

    class Ventana
    {
        //Atributos
        //public        Es accedido al crear un objeto de la clase.
        //private       Solo es accedido desde dentro de la clase.
        //static        No importa el lugar este se podra acceder.
        //protected     Solo las instancias pueden tener acceso a este.
        private int ancho = 15, altura = 20;
        private string color = "Rojo";

        //Metodos
        public void Cerrar()
        {
            Console.WriteLine("La ventana se cerro...");
        }

        private void Minimizar()
        {
            Console.WriteLine("La ventana se minimizo...");
        }

        public void Maximizar()
        {
            Console.WriteLine("La ventana se maximizo...");
        }
    }
}
