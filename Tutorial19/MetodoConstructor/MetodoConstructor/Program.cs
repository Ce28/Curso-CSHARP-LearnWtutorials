using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ventana ven = new Ventana();        //Se crea un objeto.
            ven.Mostrar();                      //Se llama un metodo del objeto creado.

            Console.ReadKey();
        }
    }

    class Ventana
    {
        //Atributos.
        private int ancho, altura;
        private string color;

        //Constructor.
        public Ventana()
        {
            ancho = 15;
            altura = 20;
            color = "Rojo";
        }

        //Metodos.
        public void Mostrar()
        {
            Console.WriteLine("La dimencion de la ventana es: {0} x {1} y su color es: {2}", ancho, altura, color);
        }

        ~Ventana()      //Metodo destructor, no es necesario.
        {
            System.Diagnostics.Trace.WriteLine("Se destruyeron los recursos");
        }
    }
}
