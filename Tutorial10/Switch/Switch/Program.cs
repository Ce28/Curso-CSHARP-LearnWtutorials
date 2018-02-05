using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch
            byte dia;

            Console.WriteLine("Dame un dia:");
            dia = Convert.ToByte(Console.ReadLine());
            
            switch(dia)
            {
                case 1:
                    Console.WriteLine("Haz eligido el lunes");
                    break;
                case 2:
                    Console.WriteLine("Haz eligido el martes");
                    break;
                case 3:
                    Console.WriteLine("Haz eligido el miercoles");
                    break;
                case 4:
                    Console.WriteLine("Haz eligido el jueves");
                    break;
                case 5:
                    Console.WriteLine("Haz eligido el viernes");
                    break;
                case 6:
                    Console.WriteLine("Haz eligido el sabado");
                    break;
                case 7:
                    Console.WriteLine("Haz eligido el dominfo");
                    break;
                default:
                    Console.WriteLine("No es un dia");
                    break;
            }

            Console.ReadKey();
        }
    }
}
