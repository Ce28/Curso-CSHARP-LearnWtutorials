using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio, total;
            int cantidad;
                        
            //try ..... catch
            try
            {
                Console.WriteLine("Cantidad: ");
                cantidad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Precio: ");
                precio = Convert.ToDouble(Console.ReadLine());

                total = cantidad * precio;

                Console.WriteLine("El total es: $" + total);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
