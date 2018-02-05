using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//.NET 4+
using System.Threading.Tasks;

namespace TiposdeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desde 0 a 255.
            byte variable = 230;
            Console.WriteLine("El valor de la variable es " + variable);

            //Entera -2147,483,648 al 2147,483,647
            int varialeEntera = 1291893021;
            Console.WriteLine("El valor de la variable es " + varialeEntera);

            //Double 
            double varialeDouble = 343.23;
            Console.WriteLine("El valor de la variable es " + varialeDouble);

            //Booleano
            bool varialeBooleano = true;
            Console.WriteLine("El valor de la variable es " + varialeBooleano);

            //Characteres
            char varialeChar = 'C';
            Console.WriteLine("El valor de la variable es " + varialeChar);

            //String
            String varialeString = "una cadena";
            Console.WriteLine("El valor de la variable es " + varialeString);

            //Dynamic
            dynamic variableDynamica = "Es una cadena";
            Console.WriteLine("El valor de la variable es " + variableDynamica);



            Console.ReadKey();
        }
    }
}
