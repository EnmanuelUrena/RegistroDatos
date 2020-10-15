using System;
using System.IO;
using System.Collections.Generic;

namespace Registro_Official
{
    class Program
    {
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

                    System.Console.Write("Ingrese sus nombre: ");
                    nombre = Persona.RegistrarNombre().Trim();
                    System.Console.Write("\nIngrese sus apellido: ");
                    apellido = Persona.RegistrarApellido().Trim();
                    System.Console.Write("\nIngrese su cedula: ");
                    cedula = Persona.RegistrarCedula().Trim();
                    datos = Persona.RegistrarDatos();
                    System.Console.Write("\nIngrese su monto: ");
                    monto = decimal.Parse(Persona.RegistrarMonto().Trim());
                    System.Console.Write("\nIngrese su contraseña: ");
                    password = Persona.RegistrarPassword().Trim();
                    Console.WriteLine("\nDatos ingresados: {0},{1},{2},{3},{4}",cedula,nombre,apellido,datos,monto);
                    Console.WriteLine("Desea Guardar(G), Continuar(C), Salir(S)");
                    Decision = Console.ReadLine().ToUpper();
                     switch(Decision)  
                     {  
                        case "G":
                                try{
                                    Console.Write("Ingrese la contraseña antes digitada para guardar: ");
                                    string password2 = Persona.RegistrarPassword().Trim();
                                    Console.WriteLine();
                                    if (password2 == password)
                                    {
                                      Persona nPersona = new Persona(cedula,nombre,apellido,datos,monto,password);
                                      Persona.GuardarPersona(nPersona,args[0]);                             
                                    } 
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Contraseña incorrecta - Datos no guardados");
                                    }     
                                } catch(Exception e) {
                                    Console.Write(e);
                                }
                                continue;
                            case "C":
                                continue;
                            case "S":
                                break;
                            
                     }
                } while (Decision != "S");
                continue;
                    
                case '2':
                List<Persona> personas = Persona.LeerLista(args[0]);
                System.Console.WriteLine("Cedula,Nombre,Apellido,Edad,Genero,Grado,Civil,Nacionalidad,Monto");
                foreach (var item in personas)
                {
                    Persona.Descodificacion(item.Datos,item);
                    Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}",item.Cedula,item.Nombre,item.Apellido,item.Edad,item.Genero,item.Grado,item.Civil,item.Nacionalidad,item.Monto);
                }
                Console.ReadKey();
                continue;

                case '3':
                List<Persona> personas1 = Persona.LeerLista(args[0]);
                Console.WriteLine("Introduzca la cedula:");
                string bCedula = Persona.RegistrarCedula();
                Persona persona1 = personas1.Find(x => x.Cedula == bCedula);
                while (persona1 == null)
                {
                    System.Console.WriteLine("No se pudo encontrar la persona buscada");
                    Console.WriteLine("Introduzca la cedula nuevamente:");
                    bCedula = Persona.RegistrarCedula();
                    persona1 = personas1.Find(x => x.Cedula == bCedula);
                }
                Console.Clear();
                Persona.Descodificacion(persona1.Datos,persona1);
                Console.WriteLine("Cedula: {0}", persona1.Cedula);
                Console.WriteLine("Nombre: {0}", persona1.Nombre);
                Console.WriteLine("Apellido: {0}", persona1.Apellido);
                Console.WriteLine("Edad: {0}", persona1.Edad);
                Console.WriteLine("Genero: {0}", persona1.Genero);
                Console.WriteLine("Grado: {0}", persona1.Grado);
                Console.WriteLine("Civil: {0}", persona1.Civil);
                Console.WriteLine("Nacionalidad: {0}", persona1.Nacionalidad);
                Console.WriteLine("Monto: {0}", persona1.Monto);
                Console.ReadKey();
                continue;

                case '4':
                List<Persona> personas2 = Persona.LeerLista(args[0]);
                Console.WriteLine("Introduzca la cedula:");
                string eCedula = Persona.RegistrarCedula();
                Persona persona2 = personas2.Find(x => x.Cedula == eCedula);
                while (persona2 == null)
                {
                    System.Console.WriteLine("No se pudo encontrar la persona buscada");
                    Console.WriteLine("Introduzca la cedula nuevamente:");
                    eCedula = Persona.RegistrarCedula();
                    System.Console.WriteLine();
                    persona2 = personas2.Find(x => x.Cedula == eCedula);
                }
                Console.Clear();
                Persona.Descodificacion(persona2.Datos,persona2);
                Console.WriteLine("Cedula: {0}", persona2.Cedula);
                Console.WriteLine("Nombre: {0}", persona2.Nombre);
                Console.WriteLine("Apellido: {0}", persona2.Apellido);
                Console.WriteLine("Edad: {0}", persona2.Edad);
                Console.WriteLine("Genero: {0}", persona2.Genero);
                Console.WriteLine("Grado: {0}", persona2.Grado);
                Console.WriteLine("Civil: {0}", persona2.Civil);
                Console.WriteLine("Nacionalidad: {0}", persona2.Nacionalidad);
                Console.WriteLine("Monto: {0}", persona2.Monto);
                Console.ReadKey();
                string[] nuevosDatos = new string[5];
                Console.WriteLine("Ingresa la nueva cedula: ");
                nuevosDatos[0] = Persona.RegistrarCedula();
                Console.WriteLine("\nIngresa la nueva nombre: ");
                nuevosDatos[1] = Persona.RegistrarNombre();
                Console.WriteLine("\nIngresa la nueva apellido: ");
                nuevosDatos[2] = Persona.RegistrarApellido();
                nuevosDatos[3] = Persona.RegistrarDatos().ToString();
                System.Console.WriteLine("\nIngresa el nuevo monto: ");
                nuevosDatos[4] = Persona.RegistrarMonto().ToString();
                System.Console.WriteLine();
                int index = personas2.IndexOf(persona2);
                personas2[index].Cedula = nuevosDatos[0];
                personas2[index].Nombre = nuevosDatos[1];
                personas2[index].Apellido = nuevosDatos[2];
                personas2[index].Datos = int.Parse(nuevosDatos[3]);
                personas2[index].Monto = decimal.Parse(nuevosDatos[4]);
                Persona.EditarLista(personas2,args[0]);
                System.Console.WriteLine("Registro Modificado");
                Console.ReadKey();
                continue;

                case '5':
                List<Persona> personas3 = Persona.LeerLista(args[0]);
                Console.WriteLine("Introduzca la cedula:");
                string dCedula = Persona.RegistrarCedula();
                Persona persona3 = personas3.Find(x => x.Cedula == dCedula);
                while (persona3 == null)
                {
                    System.Console.WriteLine("No se pudo encontrar la persona buscada");
                    Console.WriteLine("Introduzca la cedula nuevamente:");
                    dCedula = Persona.RegistrarCedula();
                    persona3 = personas3.Find(x => x.Cedula == dCedula);
                }
                Console.Clear();
                Persona.Descodificacion(persona3.Datos,persona3);
                Console.WriteLine("Cedula: {0}", persona3.Cedula);
                Console.WriteLine("Nombre: {0}", persona3.Nombre);
                Console.WriteLine("Apellido: {0}", persona3.Apellido);
                Console.WriteLine("Edad: {0}", persona3.Edad);
                Console.WriteLine("Genero: {0}", persona3.Genero);
                Console.WriteLine("Grado: {0}", persona3.Grado);
                Console.WriteLine("Civil: {0}", persona3.Civil);
                Console.WriteLine("Nacionalidad: {0}", persona3.Nacionalidad);
                Console.WriteLine("Monto: {0}", persona3.Monto);
                System.Console.WriteLine("Presione ENTER para eliminar");
                Console.ReadKey();
                personas3.Remove(persona3);
                Persona.EditarLista(personas3,args[0]);
                System.Console.WriteLine("Registro Eliminado");
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
