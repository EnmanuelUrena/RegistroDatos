using System;
using System.IO;
using System.Collections.Generic;

namespace Registro_de_Datos_v1
{
    class Program
    {
        static string RegistrarNombre()
        {
            List<char> character = new List<char>();
            char x;  
            for (int i = 0;;)
            {
               x = Console.ReadKey(true).KeyChar;
               if (x >= 65 && x <= 122)
               {
                  character.Add(x);
                    i++;
                  Console.Write(x);
               }
               if (x == 13)
               {
                   break;
               }
               if (x == 8 && i >= 1)
               {
                   if (character.Count != 0)
                   {
                     Console.Write("\b \b");
                     character.RemoveAt(character.Count - 1);  
                   }
               }
            }
            return new string(character.ToArray());
        }
        static string RegistrarApellido()
        {
            List<char> character = new List<char>();
            char x; 
            for (int i = 0;;)
            {
               x = Console.ReadKey(true).KeyChar;
               if (x >= 65 && x <= 122)
               {
                  character.Add(x);
                    i++;
                  Console.Write(x);
               }
               if (x == 13)
               {
                   break;
               }
               if (x == 8 && i >= 1)
               {
                   if (character.Count != 0)
                   {
                     Console.Write("\b \b");
                     character.RemoveAt(character.Count - 1);  
                   }
               }
            }
            return new string(character.ToArray());
        }
        static string RegistrarEdad()
        {
            List<char> character = new List<char>();
            char x; 
            for (int i = 0;;)
            {
               x = Console.ReadKey(true).KeyChar;
               if (x >= 48 && x <= 57)
               {
                  character.Add(x);
                    i++;
                  Console.Write(x);
               }
               if (x == 13)
               {
                   break;
               }
               if (x == 8 && i >= 1)
               {
                   if (character.Count != 0)
                   {
                     Console.Write("\b \b");
                     character.RemoveAt(character.Count - 1);  
                   }
               }
            }
            return new string(character.ToArray());
        }
        static string RegistrarCedula()
        {
            List<char> character = new List<char>();
            char x; 
            for (int i = 0;;)
            {
               x = Console.ReadKey(true).KeyChar;
               if ((x >= 48 && x <= 57) || (x == 45))
               {
                  character.Add(x);
                    i++;
                  Console.Write(x);
               }
               if (x == 13)
               {
                   break;
               }
               if (x == 8 && i >= 1)
               {
                   if (character.Count != 0)
                   {
                     Console.Write("\b \b");
                     character.RemoveAt(character.Count - 1);  
                   }
               }
            }
            return new string(character.ToArray());
        }
        static string RegistrarMonto()
        {
            List<char> character = new List<char>();
            char x;
            for (int i = 0;;)
            {
               x = Console.ReadKey(true).KeyChar;
               if ((x >= 48 && x <= 57) || (x == 46))
               {
                  character.Add(x);
                    i++;
                  Console.Write(x);
               }
               if (x == 13)
               {
                   break;
               }
               if (x == 8 && i >= 1)
               {
                  if (character.Count != 0)
                   {
                     Console.Write("\b \b");
                     character.RemoveAt(character.Count - 1);  
                   }
               }
               
            }
            return new string(character.ToArray());
        }
        static string RegistrarPassword()
        {
            List<char> character = new List<char>();
            char x; 
            for (int i = 0;;)
            {
               x = Console.ReadKey(true).KeyChar;
               if (x >= 48 && x <= 128)
               {
                  character.Add(x);
                    i++;
                  Console.Write("*");
               }
               if (x == 13)
               {
                   break;
               }
               if (x == 8 && i >= 1)
               {
                   if (character.Count != 0)
                   {
                     Console.Write("\b \b");
                     character.RemoveAt(character.Count - 1);  
                   }
               }
            }
            return new string(character.ToArray());
        }
        static string RegistrarBinario()
        {
            List<char> character = new List<char>();
            char x; 
            for (int i = 0;;)
            {
               x = Console.ReadKey(true).KeyChar;
               if (x >= 49 && x <= 50)
               {
                   if (i == 0)
                   {
                    character.Add(x);
                    i++;
                    Console.Write(x);
                   }
               }
               if (x == 13)
               {
                   break;
               }
               if (x == 8 && i >= 1)
               {
                   if (character.Count != 0)
                   {
                     Console.Write("\b \b");
                     character.RemoveAt(character.Count - 1);
                     i--;  
                   }
               }
            }
            return new string(character.ToArray());
        }
        static int RegistrarGenero()
        {
            int binario = 0;
            int genero = int.Parse(RegistrarBinario());
            switch (genero)
            {
                case 1:
                    binario = 0b0000;
                    break;
                case 2:
                    binario = 0b0001;
                    break;
            }
            return binario;
        }
        static int RegistrarGrado()
        {
            int binario = 0;
            int genero = int.Parse(RegistrarBinario());
            switch (genero)
            {
                case 1:
                    binario = 0b0000;
                    break;
                case 2:
                    binario = 0b0010;
                    break;
            }
            return binario;
        }
        static int RegistrarCivil()
        {
            int binario = 0;
            int genero = int.Parse(RegistrarBinario());
            switch (genero)
            {
                case 1:
                    binario = 0b0000;
                    break;
                case 2:
                    binario = 0b0100;
                    break;
            }
            return binario;
        }
        static int RegistrarNacionalidad()
        {
            int binario = 0;
            int genero = int.Parse(RegistrarBinario());
            switch (genero)
            {
                case 1:
                    binario = 0b0000;
                    break;
                case 2:
                    binario = 0b1000;
                    break;
            }
            return binario;
        }
        static int RegistrarDatos()
        {
            int edad,genero,grado,civil,nacionalidad,datos = 0;
            System.Console.Write("\nIngrese su edad: ");
            edad = Int32.Parse(RegistrarEdad());
            System.Console.Write("\nIngrese su genero (1) Hombre, (2) Mujer: ");
            genero = RegistrarGenero();
            System.Console.Write("\nIngrese su grado (1) Estudiante, (2) Graduado: ");
            grado = RegistrarGrado();
            System.Console.Write("\nIngrese su grado (1) Soltero, (2) Casado: ");
            civil = RegistrarCivil();
            System.Console.Write("\nIngrese su grado (1) Dominicano, (2) Extranjero: ");
            nacionalidad = RegistrarNacionalidad();
            datos = edad;
            datos = datos << 4;
            datos += genero | grado | civil | nacionalidad;
            return datos;
        }
        static void Descodificacion(int datos)
        {
           string Genero = null , Civil = null, Grado = null, Nacionalidad = null;
           if ((datos & 0b0001) == 0b0001)
           {
                Genero = "Mujer";
           }
           else
           {
               Genero = "Hombre";
           }
           if ((datos & 0b0010) == 0b0010)
           {
                Grado = "Graduado/a";
           }
           else
           {
                Grado = "Estudiante";
           }
            if ((datos & 0b0100) == 0b0100)
           {
                Civil = "Casado/a";
           }
           else
           {
                Civil = "Soltero/a";
           }
           if ((datos & 0b1000) == 0b1000)
           {
                Nacionalidad = "Extranjero/a";
           }
           else
           {
                Nacionalidad = "Dominicano/a";
           }
           datos = datos >> 4;
           System.Console.WriteLine("Edad: {0}, Genero: {1}, Grado: {2}, Civil: {3}, Nacionalidad: {4}",datos,Genero,Grado,Civil,Nacionalidad);
        }
        static void Main(string[] args) 
        {
            string nombre, apellido, cedula, password;
            int datos;
            decimal monto;
            string Decision;
            char caso, caso1;
            bool rep = true;
            
            if(!File.Exists(args[0]))
            {
                string header = "Cedula,Nombre,Apellido,Datos,Monto,Password";
                File.WriteAllText(args[0], header + Environment.NewLine);
            }
            do
            {
            Console.Clear();
            rep = true;
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("         [1] - Guardar Datos            ");
            System.Console.WriteLine("     [2] - Mostrar todos los datos      ");
            System.Console.WriteLine("       [3] - Buscar por cedula          ");
            System.Console.WriteLine("         [4] - Editar datos             ");
            System.Console.WriteLine("         [5] - Eliminar datos           ");
            System.Console.WriteLine("             [6] - Salir                ");
            System.Console.WriteLine("----------------------------------------");
            caso = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (caso)
            {
                case '1':
                do
                {
                    System.Console.Write("Ingrese sus nombres: ");
                    nombre = RegistrarNombre().Trim();
                    System.Console.Write("\nIngrese sus apellidos: ");
                    apellido = RegistrarApellido().Trim();
                    System.Console.Write("\nIngrese su cedula: ");
                    cedula = RegistrarCedula().Trim();
                    datos = RegistrarDatos();           
                    System.Console.Write("\nIngrese su Monto: ");
                    monto = decimal.Parse(RegistrarMonto().Trim());
                    System.Console.Write("\nIngrese su Password: ");
                    password = RegistrarPassword().Trim();
                    Console.WriteLine("\nDatos ingresados: {0},{1},{2},{3},{4}",cedula,nombre,apellido,datos,monto);
                    Console.WriteLine("Desea Guardar(G), Continuar(C), Salir(S)");
                    Decision = Console.ReadLine().ToUpper();
                     switch(Decision)  
                     {  
                        case "G":
                        try
                        {   
                            System.Console.Write("Ingrese la contraseña antes digitada para guardar:");
                            string Password2 = RegistrarPassword().Trim();
                            System.Console.WriteLine();
                            if (Password2 == password)
                            {
                               using(StreamWriter file = new StreamWriter(args[0],true))
                                {
                                    file.WriteLine(cedula + "," + nombre + "," + apellido + "," + datos + "," + monto + "," + password);
                                } 
                                System.Console.WriteLine("Datos Guardados, pulse cualquier tecla para continuar");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                System.Console.WriteLine("Contraseña Incorrecta - Datos no guardados");
                            }
                        }
                        catch (System.Exception e)
                        {
                           System.Console.WriteLine(e);
                        }
                            continue;
                        case "C":
                            Console.Clear();
                            continue;
                        case "S":
                            break;
                            
                     }
                } while (Decision != "S");
                continue;
                    
                case '2':
                using(StreamReader Archivo1 = new StreamReader (args[0],true))
                {
                    Console.WriteLine(Archivo1.ReadToEnd());
                    Console.ReadKey();
                }
                
                continue;

                case '3':
                
                string cadena, cedula1;
                bool encontrado = false;
                string[] campos = new string[4];
                char[] separador = {','};

                try
                {
                    using(StreamReader Archivo2 = new StreamReader (args[0],true))
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
                            Descodificacion(int.Parse(campos[3]));
                            System.Console.WriteLine("Monto: {0}",campos[4]);
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
                    
                    
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e);
                }
                Console.ReadKey();
                continue;

                case '4':
                string cadena1, cedula2;
                bool encontrado1 = false;
                string[] campos1 = new string[4];
                string[] nuevosDatos = new string[5];
                char[] separador1 = {','};

                try
                {
                    using(StreamReader Archivo3 = new StreamReader(args[0],true))
                    {
                    using(StreamWriter file1 = File.CreateText("temp.csv"))
                    {
                    System.Console.Write("Introduzca la cedula: ");
                    cedula2 = Console.ReadLine();
                    cadena1 = Archivo3.ReadLine();
                    while (cadena1 != null)
                    {
                        campos1 = cadena1.Split(separador1);
                        if (campos1[0].Trim().Equals(cedula2))
                        {
                            System.Console.WriteLine();
                            System.Console.WriteLine("Registro encontrado con estos datos:");
                            System.Console.WriteLine();
                            System.Console.WriteLine("-------------------------------------");
                            System.Console.WriteLine("       Cedula: {0}",campos1[0]);
                            System.Console.WriteLine("       Nombres: {0}",campos1[1]);
                            System.Console.WriteLine("       Apellidos: {0}",campos1[2]);
                            Descodificacion(int.Parse(campos1[3]));
                            System.Console.WriteLine("       Monto: {0}",campos1[4]);
                            System.Console.WriteLine("-------------------------------------");
                            encontrado1 = true;
                            System.Console.Write("\nIngresa la nueva cedula: ");
                            nuevosDatos[0] = RegistrarCedula();
                            System.Console.Write("\nIngresa el nuevo nombre: ");
                            nuevosDatos[1] = RegistrarNombre();
                            System.Console.Write("\nIngresa el nuevo apellido: ");
                            nuevosDatos[2] = RegistrarApellido();
                            System.Console.Write("\nIngresa los nuevos datos: ");
                            nuevosDatos[3] = RegistrarDatos().ToString();
                            System.Console.Write("\nIngresa el nuevo monto: ");
                            nuevosDatos[4] = RegistrarMonto();
           
                            file1.WriteLine(nuevosDatos[0] + "," + nuevosDatos[1] + "," + nuevosDatos[2] + "," + nuevosDatos[3] + "," + nuevosDatos[4] + "," + campos1[5]);

                            Console.Clear();
                            System.Console.WriteLine("Su registro ha sido modificado");
                            Console.ReadKey();
                        }
                        else
                        {
                            file1.WriteLine(cadena1);
                        }
                        cadena1 = Archivo3.ReadLine();
                    }
                        if(encontrado1 == false)
                        {
                            System.Console.WriteLine("La cedula {0} no se encontró en el archivo", cedula2);
                            Console.ReadKey();
                        }
                    }
                    
                    
                    }      
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e);
                }
                File.Delete(args[0]);
                File.Move("temp.csv",args[0]);
                continue;

                case '5':
                
                
                string cadena2, cedula3;
                bool encontrado2 = false;
                string[] campos2 = new string[4];
                char[] separador2 = {','};

                try
                {
                    using(StreamReader Archivo4 = new StreamReader (args[0],true))
                    {
                        using(StreamWriter File2 = File.CreateText("temp.csv"))
                        {
                            System.Console.Write("Introduzca la cedula: ");
                            cedula3 = Console.ReadLine();
                            cadena2 = Archivo4.ReadLine();
                            while (cadena2 != null)
                            {
                                campos2 = cadena2.Split(separador2);
                                if (campos2[0].Trim().Equals(cedula3))
                                {
                                    encontrado2 = true;
                                }
                                else
                                {
                                    File2.WriteLine(cadena2);
                                }
                                cadena2 = Archivo4.ReadLine();

                            }

                        if(encontrado2 == false)
                        {
                            System.Console.WriteLine("La cedula {0} no se encontró en el archivo", cedula3);
                        }
                        else
                        {
                            System.Console.WriteLine("Registro eliminado");
                        }
                    }  
                    
                }
                    
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e);
                }
                File.Delete(args[0]);
                File.Move("temp.csv",args[0]);
                Console.ReadKey();
                continue;

                case '6':
                rep = false;
                break;
                
                default: 
                System.Console.WriteLine("Usted no ha ingresado el numero correcto");
                System.Console.WriteLine("Desea Repetir el programa o cerrarlo?");
                System.Console.WriteLine("Presione S para repetir o cualquier otra tecla para cerrar");
                caso1 = Console.ReadKey().KeyChar;
                if (caso1.ToString().ToUpper() != "S")
                {
                    rep = false;
                }
                Console.Clear();
                break;
            }
        }
        while (rep == true);
            
            
        }
    }
}
