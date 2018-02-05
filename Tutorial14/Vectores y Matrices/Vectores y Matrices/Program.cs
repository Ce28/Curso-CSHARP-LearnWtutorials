using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_y_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vectores o Arreglos unidimencionales.
            //int[] numero;

            //numero = new int[5];
            //numero[0] = 5;
            //numero[1] = 6;
            //numero[2] = 7;
            //numero[3] = 10;
            //numero[4] = 17;

            //foreach (int item in numero)
            //{
            //    Console.WriteLine(item);
            //}


            //Matrices o Arreglos bidimencionales.
            int[,] numero;

            numero = new int[3, 3]; //Filas Columnas

            for (int fila = 0; fila < 3; fila++)    
            {
                for (int col = 0; col < 3; col++)                           //Llenado de datos
                {
                    Console.WriteLine("Dame un numero: ");
                    numero[fila, col] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)                           //Impresion de esos datos
                {
                    Console.Write(" " + numero[fila, col]);
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
