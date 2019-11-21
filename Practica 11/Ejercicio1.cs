using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_11
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese los datos del cliente.");
                Console.WriteLine();
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Telefono: ");
                int tel = Convert.ToInt32(Console.ReadLine());
                Console.Write("Fecha de Nacimiento: ");
                string fecha = Console.ReadLine();
                Console.Write("Sueldo: ");
                double sueldo = Convert.ToDouble(Console.ReadLine());
                FileStream stream = new FileStream("empleado.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(nombre);
                binario.Write(tel);
                binario.Write(fecha);
                binario.Write(sueldo);
                stream.Close();
                binario.Close();
                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un problema con el archivo binario.");
            }
            Console.ReadKey();



        }

    }
}
