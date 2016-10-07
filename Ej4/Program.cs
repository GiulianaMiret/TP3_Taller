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
            out1:
            Console.Clear();
            Console.WriteLine("Qué desea hacer?");
            Console.WriteLine("1: Encriptar");
            Console.WriteLine("2: Desencriptar");
            Console.WriteLine("3: Salir");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    Console.WriteLine("Escriba la palabra que desea Encriptar:");
                    string palabra = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Qué metodo utilizar para Encriptar?");
                    Console.WriteLine("1: AES");
                    Console.WriteLine("2: Cesar");
                    Console.WriteLine("3: Nulo");
                    Console.WriteLine("4: Salir");
                    op = Console.ReadLine();
                    Console.Clear();
                    switch (op)
                    {
                        case "1":
                            palabra = fachada.EncriptarAES(palabra);
                            Console.WriteLine("Desea ver la palabra encriptada? (s/n)");
                            if (Console.ReadLine() == "s")
                            {
                                Console.WriteLine(palabra);
                            }
                            goto out1;
                        case "2":
                            Console.WriteLine("Ingrese el desplazamiento:");
                            int desplaz = Convert.ToInt32(Console.ReadLine());
                            palabra = fachada.EncriptarCesar(palabra, desplaz);
                            Console.WriteLine("Desea ver la palabra encriptada? (s/n)");
                            if (Console.ReadLine() == "s")
                            {
                                Console.WriteLine(palabra);
                            }
                            goto out1;
                        case "3":
                            palabra = fachada.EncriptarNulo(palabra);
                            Console.WriteLine("Desea ver la palabra encriptada? (s/n)");
                            if (Console.ReadLine() == "s")
                            {
                                Console.WriteLine(palabra);
                            }
                            goto out1;
                        default: goto out1;
                    }
                case "2":
                    Console.WriteLine("Escriba la palabra que desea Desencriptar:");
                    palabra = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Qué metodo utilizar para Desencriptar?");
                    Console.WriteLine("1: AES");
                    Console.WriteLine("2: Cesar");
                    Console.WriteLine("3: Nulo");
                    Console.WriteLine("4: Salir");
                    op = Console.ReadLine();
                    switch (op)
                    {
                        case "1":
                            palabra = fachada.DesencriptarAES(palabra);
                            Console.WriteLine("La palabra desencriptada es:");
                            Console.WriteLine(palabra);
                            goto out1;
                        case "2":
                            Console.WriteLine("Ingrese el desplazamiento:");
                            int desplaz = Convert.ToInt32(Console.ReadLine());
                            palabra = fachada.DesencriptarCesar(palabra, desplaz);
                            Console.WriteLine("La palabra desencriptada es:");
                            Console.WriteLine(palabra);
                            goto out1;
                        case "3":
                            palabra = fachada.DesencriptarNulo(palabra);
                            Console.WriteLine("La palabra desencriptada es:");
                            Console.WriteLine(palabra);
                            goto out1;
                        default: goto out1;
                    }
            default: break;
            }
        }
    }
}
