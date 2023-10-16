using System;
using System.IO;

namespace Ficheros
{
    class Program
    {

        static void escribirFichero(string[] alumnos, string nombre_fichero)
        {
            System.IO.StreamWriter fichero = new System.IO.StreamWriter(nombre_fichero);

            for (int i = 0; i < alumnos.Length; i++)
            {
                fichero.WriteLine(alumnos[i]);
            }
            fichero.Close();
            Console.WriteLine("alumnos registrados");

        }

        static void leerFichero(string nombre_fichero)
        {
            string registro;

            if (File.Exists(nombre_fichero))
            {
                registro = File.ReadAllText(nombre_fichero);

                Console.WriteLine(registro);
            }
        }

        static void copiaImagen(string nombre_fichero, string nombre_fichero_copia)
        {
            FileStream ficheroOrigen = new FileStream(nombre_fichero, 
                FileMode.Open, FileAccess.Read);

            byte[] buffer = new byte[ficheroOrigen.Length];

            ficheroOrigen.Read(buffer, 0, buffer.Length);

            for (int i = 1000; i < 2000; i++)
            {
                buffer[i] = 0;
            }

            FileStream ficheroDestino = new FileStream(nombre_fichero_copia, 
                FileMode.Create, FileAccess.Write);

            ficheroDestino.Write(buffer, 0, buffer.Length);

            ficheroOrigen.Close();
            ficheroDestino.Close();

            Console.WriteLine("Fichero y copiado correctamente");

        }

        static void leerFichero2(string nombre_fichero)
        {
            FileStream ficheroCopiado = new FileStream(nombre_fichero,
                FileMode.Open, FileAccess.Read);

            byte[] buffer = new byte[ficheroCopiado.Length];

            ficheroCopiado.Read(buffer, 0, buffer.Length);

            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
            }

            ficheroCopiado.Close();

        }

        static void Main(string[] args)
        {
            /* StreamWriter fichero = new StreamWriter("Ejemplo.txt");
             fichero.WriteLine("Hola como estas");
             fichero.WriteLine("Nos vemos mas tarde");
             fichero.Close();*/


            //--------------------------VT-11---------------------------------

            /* String[] alumnos = new string[5];

             Console.WriteLine("Dime el nombre del alumno");

             for (int i = 0; i < alumnos.Length; i++)
             {
                 Console.WriteLine("Dime el amlumno "+(i+1));
                 alumnos[i] = Console.ReadLine();

             }

             Console.WriteLine("Introduce el nombre del fichero");
             String nombre_fichero = Console.ReadLine();

             Console.WriteLine("\n");

             String ruta = @"C:\Users\sonia\source\repos\Ficheros\";

             nombre_fichero = ruta + nombre_fichero + ".txt";

             Console.WriteLine(nombre_fichero);

             Console.WriteLine("PULSA INTRO PARA CONTINUAR");
             Console.ReadKey();

             escribirFichero(alumnos, nombre_fichero);
             leerFichero(nombre_fichero);*/

            //----------------------------VT-12--------------------------------------

            string ilerna_imagen = @"C:\Users\sonia\source\repos\Ficheros\riu.png";
            string ilerna_imagne_copia = @"C:\Users\sonia\source\repos\Ficheros\riu_copia.png ";

            Console.WriteLine("Esta empezando el programa a copiar la imagen");

            copiaImagen(ilerna_imagen, ilerna_imagne_copia);
            leerFichero2(ilerna_imagen);

            Console.WriteLine("---------------------------------------------------------------------------------------");

            leerFichero2(ilerna_imagne_copia);


        }
    }
}
