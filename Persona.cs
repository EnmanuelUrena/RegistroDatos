using System;
using System.IO;
using System.Collections.Generic;

namespace Registro_Official
{
    class Persona
    {
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Cedula {get; set;}
        public int Edad {get; set;}
        public int Datos {get; set;}
        public decimal Monto {get; set;}
        public string Genero {get; set;}
        public string Grado {get; set;}
        public string Civil {get; set;}
        public string Nacionalidad {get; set;}
        public string Password {get; set;}

        public Persona( in string cedula, in string nombre, in string apellido, in int datos, in decimal monto, in string password)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Datos = datos;
            Monto = monto;
            Password = password;
        }
        public Persona()
        {
            
        }
        public static void GuardarPersona(Persona persona,string args)
        {
            using(StreamWriter file = new StreamWriter(args, true))
            {
                file.WriteLine( persona.Cedula + "," + persona.Nombre + "," + persona.Apellido + "," + persona.Datos + "," + persona.Monto + "," + persona.Password);
            }
            Console.WriteLine("Datos Guardados, presione cualquier tecla para continuar"); 
            Console.ReadKey();
            Console.Clear();
        }

        public static List<Persona> LeerLista(string args)
        {
            List<Persona> personas = new List<Persona>();
            using(StreamReader lectura = new StreamReader(args))
            {
                string texto = lectura.ReadToEnd();
                string[] lineas = texto.Split("\r\n");
                for (int i = 1; i < lineas.Length - 1; i++)
                {
                    string[] cadena = lineas[i].Split(",");
                    Persona persona = new Persona(cadena[0],cadena[1],cadena[2],int.Parse(cadena[3]),decimal.Parse(cadena[4]),cadena[5]);
                    personas.Add(persona);
                }
                
            }
            return personas;
        }
        public static void EditarLista(List<Persona> personas, string args)
        {
            using(StreamWriter escritura = new StreamWriter(args))
            {
                escritura.WriteLine("Cedula,Nombre,Apellido,Datos,Monto,Password");
            }
            foreach (var item in personas)
            {
                GuardarPersona(item,args);
            }
        }
        public static string RegistrarNombre()
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
        public static string RegistrarApellido()
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
        public static string RegistrarEdad()
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
        public static string RegistrarCedula()
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
        public static string RegistrarMonto()
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
        public static string RegistrarPassword()
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
       public static string RegistrarBinario()
        {
            List<char> character = new List<char>();
            char x; 
            for (int i = 0;;)
            {
               x = Console.ReadKey(true).KeyChar;
               if (x >= 49 && x <= 50)
               {
                   if(i == 0)
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
        public static int RegistrarGenero()
        {
            int genero, binario = 0;
            genero = int.Parse(RegistrarBinario());
            switch (genero)
            {
                case 1:
                    binario = 0b0000; //Hombre
                    break;
                case 2:
                    binario = 0b0001;   //Mujer
                    break;
                
            }
            return binario;
        }
        public static int RegistrarGrado()
        {
            int grado, binario = 0;
            grado = int.Parse(RegistrarBinario());
            switch (grado)
            {
                case 1:
                    binario = 0b0000; // Est
                    break;
                case 2:
                    binario = 0b0010; // Grad
                    break;
                
            }
            return binario;
        }
        public static int RegistrarCivil()
        {
            int civil, binario = 0;
            civil = int.Parse(RegistrarBinario());
            switch (civil)
            {
                case 1:
                    binario = 0b0000; // Soltero
                    break;
                case 2:
                    binario = 0b0100; // Casado
                    break;
                
            }
            return binario;
        }
        public static int RegistrarNacionalidad()
        {
            int nac, binario = 0;
            nac = int.Parse(RegistrarBinario());
            switch (nac)
            {
                case 1:
                    binario = 0b0000; // Dominicano
                    break;
                case 2:
                    binario = 0b1000; // Extranjero
                    break;
                
            }
            return binario;
        }
        public static int RegistrarDatos()
        {
            int datos, edad, genero, grado, civil, nacionalidad;
            System.Console.Write("\nIngrese su edad:");
            edad = int.Parse(RegistrarEdad());
            System.Console.Write("\nIngrese su genero (1) Hombre / (2) Mujer:");
            genero = RegistrarGenero();
            System.Console.Write("\nIngrese su genero (1) Estudiante / (2) Graduado:");
            grado = RegistrarGrado();
            System.Console.Write("\nIngrese su genero (1) Soltero / (2) Casado:");
            civil = RegistrarCivil();
            System.Console.Write("\nIngrese su genero (1) Dominicano / (2) Extranjero:");
            nacionalidad = RegistrarNacionalidad();
            datos = edad;
            datos = datos << 4;
            datos += genero | grado | civil | nacionalidad;
            return datos;
        }
        public static void Descodificacion(int datos, Persona persona)
        {
            if((datos & 0b0001) == 0b0001)
            {
                persona.Genero = "Mujer";
            }
            else
            {
                persona.Genero = "Hombre";
            }
            if((datos & 0b0010) == 0b0010)
            {
                persona.Grado = "Graduado/a";
            }
            else
            {
                persona.Grado = "Estudiante";
            }
            if((datos & 0b0100) == 0b0100)
            {
                persona.Civil = "Casado/a";
            }
            else
            {
                persona.Civil = "Soltero/a";
            }
            if((datos & 0b1000) == 0b1000)
            {
                persona.Nacionalidad = "Extranjero/a";
            }
            else
            {
                persona.Nacionalidad = "Dominicano/a";
            }
            persona.Edad = datos >> 4;
        }
    }
}
                
