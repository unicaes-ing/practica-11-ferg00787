using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_11
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            try
            {

                FileStream stream = new FileStream("empleado.dat", FileMode.Open, FileAccess.Read);
                BinaryReader binario = new BinaryReader(stream);
                string nombre = binario.ReadString();
                int tel = binario.ReadInt32();
                string fecha = binario.ReadString();
                double sueldo = binario.ReadDouble();
                stream.Close();
                binario.Close();
                Console.Clear();
                Console.WriteLine("Datos del empleado:");
                Console.WriteLine();
                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Telefono: {0}", tel);
                Console.WriteLine("Fecha de Nacimiento: {0}", fecha);
                Console.WriteLine("Sueldo: {0}", sueldo);
                Console.WriteLine("Presione enter para salir.");
                Console.ReadKey();


            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un problema con el archivo binario.");
            }



        }

    }
}
