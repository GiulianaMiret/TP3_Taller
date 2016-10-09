using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            string palabra = " ";
            string opEnc = " ";
            int desplaz = 0;
            int aux = 0;
            Console.Title = "Trabajo Practico N° 3 - Ejercicio 4";
        out1:
            Console.Clear();
            Console.WriteLine("Qué desea hacer? \n\n\t1: Encriptar\n\t2: Desencriptar\n\n\t3: Salir");
            string op = Console.ReadLine();
            Console.Clear();
            switch (op)
            {
                case "1":
                    Console.WriteLine("Escriba la palabra que desea Encriptar:");
                    palabra = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Qué metodo utilizar para Encriptar?\n\n\t1: AES\n\t2: Cesar\n\t3: Nulo\n\n\t4: Salir");
                    opEnc = Console.ReadLine();
                    Console.Clear();
                    switch (opEnc)
                    {
                        case "1":
                            Console.WriteLine("Metodo:\n\tAES\nFrase:\n\t{0} \nFrase encriptada:\n\t{1}", palabra, palabra = fachada.EncriptarAES(palabra));
                            Console.ReadKey();
                            goto out1;
                        case "2":
                            Console.WriteLine("Ingrese el desplazamiento:");
                            desplaz = Convert.ToInt32(Console.ReadLine());
                            aux = 1;
                            Console.WriteLine("Metodo:\n\tCesar\nDesplazamiento:\t{0}\nFrase:\n\t{1}\nFrase encriptada:\n\t{2}", desplaz,palabra, palabra = fachada.EncriptarCesar(palabra, desplaz));
                            Console.ReadKey();
                            goto out1;
                        case "3":
                            Console.WriteLine("Metodo:\n\tNulo\nFrase:\n\t{0} \nFrase encriptada:\n\t{1}", palabra, palabra = fachada.EncriptarNulo(palabra));
                            Console.ReadKey();
                            goto out1;
                        default: goto out1;
                    }
                case "2":
                    if (palabra != " ")
                    {
                        Console.WriteLine("Que desea desencriptar: \n\n\t1: La palabra anterior\n\t2: Una nueva palabra\n\n\t3: Salir");
                        op = Console.ReadLine();
                        if (op == "1")
                        {
                            op = opEnc;
                            goto out2;
                        }
                        if (op == "3") { goto out1; }
                    }
                    Console.WriteLine("Escriba la palabra que desea Desencriptar:");
                    palabra = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Qué metodo utilizar para Desencriptar?\n\n\t1: AES\n\t2: Cesar\n\t3: Nulo\n\n\t4: Salir");
                    op = Console.ReadLine();
                out2:
                    Console.Clear();
                    switch (op)
                    {
                        case "1":
                            Console.WriteLine("Metodo:\n\tAES \nFrase encriptada:\n\t{0}\nFrase desencriptadada: \n\t{1}", palabra, palabra = fachada.DesencriptarAES(palabra));
                            Console.ReadKey();
                            goto out1;
                        case "2":
                            if (aux == 0)
                            {
                                Console.WriteLine("Ingrese el desplazamiento:");
                                desplaz = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("Metodo:\n\tCesar\nDesplazamiento:\t{2}\nFrase encriptada:\n\t{0}\nFrase desencriptada:\n\t{1}", palabra, palabra = fachada.DesencriptarCesar(palabra, desplaz), desplaz);
                            Console.ReadKey();
                            goto out1;
                        case "3":
                            Console.WriteLine("Metodo:\n\tNulo\nFrase encriptada:\n\t{0}\nFrase desencriptada:\n\t{1}", palabra, palabra = fachada.DesencriptarNulo(palabra));
                            Console.ReadKey();
                            goto out1;
                        default: goto out1;
                    }
            default: break;
            }
        }
    }
}
