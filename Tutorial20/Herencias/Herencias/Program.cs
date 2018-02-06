using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseHija Heren = new ClaseHija();  //Crea un objeto de la ClaseHija que hereda de la ClasePadre.
            Heren.Saludar();                    //Se puede utilizar los metodos heredados.
            Heren.Despedirse();                 //Igual aqui.

            Console.ReadKey();
        }
    }
}
