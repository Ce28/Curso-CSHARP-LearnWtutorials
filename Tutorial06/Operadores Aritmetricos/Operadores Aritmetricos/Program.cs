using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Aritmetricos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores aritmetricos
            /* Operadores basicos aritmetricos
             * + suma 
             * - resta
             * * Multiplicacion
             * / Division
             * % Residuo 
             */
            //int num = 6, num2 = 5;
            //Console.WriteLine("El resultado de la suna es: " + (num + num2));

            double num, pot, resultado;

            Console.WriteLine("Digite el numero que quiere elevar: ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a la potencia que quiere elevar: ");
            pot = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(num, pot);
            Console.WriteLine("El resultado de {0} a la {1} es: {2}", num, pot, resultado);

            Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(49));



            Console.ReadKey();
        }
    }
}
