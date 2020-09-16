using System;
using System.IO;

namespace Registro_de_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter Archivo = new StreamWriter (args[0],true);
            string nombre, apellido, cedula;
            int edad;
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine(); 
            Console.Write("Ingrese el apellido: ");
            apellido = Console.ReadLine(); 
            Console.Write("Ingrese la cedula: ");
            cedula = Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            edad = Int32.Parse(Console.ReadLine()); 
            Archivo.WriteLine("{0},{1},{2},{3}",nombre,apellido,cedula,edad);
            Archivo.Close();
            Console.WriteLine("Datos agregados {0},{1},{2},{3}",nombre,apellido,cedula,edad);

        }
     
    }
}
