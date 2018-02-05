using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un archivo------------------------------------
            //TextWriter archivo;         //Variable de tipo archivo.
            //archivo = new StreamWriter("archivo.txt");  //Se crea una instancia (objeto) de ella.
            //string mensaje;                 //Se inicializa una variable que guardara la linea.
            //mensaje = Console.ReadLine();   //Se guarda la linea.
            //archivo.WriteLine(mensaje);     //Escribe en el archivo.
            //archivo.Close();                //Se cierra y guarda el archivo
            //Console.Clear();                //Se limpia la pantalla de comando.
            //Console.WriteLine("Se ha guardado el archivo...");


            //Leer el archivo-------------------------------------
            //TextReader LeerArchivo;         //Variable de tipo archivo.
            //LeerArchivo = new StreamReader("archivo.txt");  //Se crea una instancia (objeto) de ella.
            ////Console.WriteLine(LeerArchivo.ReadLine());  //Imprime la lectura que se realizo del archivo, solo la primera linea.
            //Console.WriteLine(LeerArchivo.ReadToEnd());  //Imprime la lectura que se realizo del archivo todo el archivo..
            //LeerArchivo.Close();            //Se cierra y guarda el archivo.


            //Agregar texto nuevo al archivo----------------------
            StreamWriter archivo = File.AppendText("archivo.txt");
            string mensaje;
            mensaje = Console.ReadLine();
            archivo.WriteLine(mensaje);
            archivo.Close();

            Console.ReadKey();
        }
    }
}
