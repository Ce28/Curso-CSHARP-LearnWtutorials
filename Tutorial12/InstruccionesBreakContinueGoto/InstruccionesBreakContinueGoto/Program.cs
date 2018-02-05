using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InstruccionesBreakContinueGoto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Break.
            //for (int id = 0; id <= 10 ; id++)
            //{
            //    Thread.Sleep(800);
            //    Console.WriteLine(id);
            //    if (id == 5)
            //    {
            //        break;      //Se utiliza para salir de la estructura repetitiva.
            //    }
            //}


            //Continue.
            //for (int id = 0; id <= 10; id++)
            //{
            //    Thread.Sleep(800);
            //    if (id == 8)
            //    {
            //        Console.WriteLine();
            //        continue;   //Se utiliza para realizar un salto en la estructura repetitiva.
            //    }
            //    Console.WriteLine(id);
            //}


            //Goto.
            for (int id = 0; id <= 10; id++)
            {
                Thread.Sleep(800);
                if (id == 4)
                {
                    goto liquidacion;   //Envia a una parte directa de codigo y termina la ejecucion de la estructura repetitiva.
                }
                Console.WriteLine(id);
            }

        liquidacion:
            Console.WriteLine("Se envio al departamento de contabilidad");

            Console.ReadKey();
        }
    }
}
