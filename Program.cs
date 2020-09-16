using System;
using System.IO;

namespace Registro_de_Datos_v1
{
    class Program
    {
        static void Main(string[] args) 
        {
            string nombre, apellido, cedula;
            int edad;
            string Decision;
            char caso, caso1;
            bool rep = true;
            do
            {
            Console.Clear();
            rep = true;
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("         [1] - Guardar Datos            ");
            System.Console.WriteLine("     [2] - Mostrar todos los datos      ");
            System.Console.WriteLine("       [3] - Buscar por cedula          ");
            System.Console.WriteLine("----------------------------------------");
            caso = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (caso)
            {
                case '1':
                    StreamWriter Archivo = new StreamWriter (args[0]);
                 do
                 {
                
                    do
                    {
                        
                        System.Console.WriteLine("Ingrese sus nombres: ");
                        nombre = Console.ReadLine();
                        System.Console.WriteLine("Ingrese sus apellidos: ");
                        apellido = Console.ReadLine();
                        System.Console.WriteLine("Ingrese su cedula: ");
                        cedula = Console.ReadLine();
                        System.Console.WriteLine("Ingrese su edad: ");
                        edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Datos ingresados: {0},{1},{2},{3}",cedula,nombre,apellido,edad);
                        Console.WriteLine("Desea Guardar(G), Continuar(C), Salir(S)");
                        Decision = Console.ReadLine().ToUpper();
                        if (Decision == "G")
                        {
                            Archivo.WriteLine("{0},{1},{2},{3}",cedula,nombre,apellido,edad);
                        }
                    
                     } while (Decision == "C");
                    } while (Decision == "G");
                    Archivo.Close();
                    Console.ReadKey();
                break;

                case '2':
                StreamReader Archivo1 = new StreamReader (args[0]);
                Console.WriteLine(Archivo1.ReadToEnd());
                Console.ReadKey();
                break;

                case '3':
                StreamReader Archivo2 = new StreamReader (args[0]);
                string cadena, cedula1;
                bool encontrado = false;
                string[] campos = new string[4];
                char[] separador = {','};

                try
                {
                    System.Console.Write("Introduzca la cedula: ");
                    cedula1 = Console.ReadLine();
                    cadena = Archivo2.ReadLine();
                    while (cadena != null && encontrado == false)
                    {
                        campos = cadena.Split(separador);
                        if (campos[0].Trim().Equals(cedula1))
                        {
                            System.Console.WriteLine("Cedula: {0}",campos[0]);
                            System.Console.WriteLine("Nombres: {0}",campos[1]);
                            System.Console.WriteLine("Apellidos: {0}",campos[2]);
                            System.Console.WriteLine("Edad: {0}",campos[3]);
                            encontrado = true;
                        }
                        else
                        {
                            cadena = Archivo2.ReadLine();
                        }
                        

                    }
                    
                    if(encontrado == false)
                        {
                            System.Console.WriteLine("La cedula {0} no se encontró en el archivo", cedula1);
                        }
                    
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e);
                }
                Console.ReadKey();
                break; 
                
                default: 
                System.Console.WriteLine("Usted no ha ingresado el numero correcto");
                System.Console.WriteLine("Desea Repetir el programa o cerrarlo?");
                System.Console.WriteLine("Presione S para repetir o cualquier otra tecla para cerrar");
                caso1 = Console.ReadKey().KeyChar;
                if (caso1.ToString().ToUpper() == "S")
                {
                    rep = false;
                }
                break;
            }
        }
        while (rep == false);
            
            
        }
    }
}
