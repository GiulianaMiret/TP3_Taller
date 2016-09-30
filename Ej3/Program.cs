using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
			Fachada fachada = new Fachada();
			Console.Clear();
			Console.WriteLine("Seleccione opcion: ");
			Console.WriteLine("\t1. Solicitar prestamo");

			char opcion = Console.ReadKey(true).KeyChar;

			Console.Clear();

			switch (opcion)
			{
				case '1':
					{
						Console.Write("Ingrese ID de Cliente: ");
						int idCliente = Convert.ToInt32(Console.ReadLine());
						while (fachada.existeCliente(idCliente))
						{
							Console.WriteLine("El cliente no es valido. Intente de nuevo.");
							Console.Write("Ingrese ID de Cliente: ");
							idCliente = Convert.ToInt32(Console.ReadLine());
						}
						Console.Write("Ingrese monto a solicitar: ");
						double monto = Convert.ToDouble(Console.ReadLine());

						Console.Write("Ingrese cuotas a solicitar: ");
						int cuotas = Convert.ToInt32(Console.ReadLine());

						if (fachada.SolicitudPrestamo(idCliente, monto, cuotas){
							Console.WriteLine("Se ha aceptado su solicitud de prestamo.");
						}
						else {
							Console.WriteLine("Se ha rechazado su solicitud de prestamo.");
							Console.WriteLine("Las causas pueden ser las siguientes: ");
							Console.WriteLine("\t- Tener entre 18 y 75 años de edad");
							Console.WriteLine("\t- Tener al menos 6 meses de antiguedad laboral");
							Console.WriteLine("\t- Tener un sueldo minimo de $5000");
							Console.WriteLine("Además, según su tipo de cuenta: ");
							Console.WriteLine("\t- Puede solicitar hasta $" + fachada.getMaximoMonto(idCliente));
							Console.WriteLine("\t- Puede solicitar hasta " + fachada.getMaximasCuotas(idCliente) +" cuotas");
						}
						break;
					}
				default:
					{
						Main(args);
						break;
					}
			}
        }
    }
}
