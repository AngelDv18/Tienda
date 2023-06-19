using ActividadTienda.D.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadTienda.D.Services
{
    internal class Funciones
    {
        public string RealizarCompra()
        {
            try
            {
                Cliente cliente = new Cliente();
                Console.WriteLine("Ingrese el nombre:");
                cliente.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido:");
                cliente.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese la edad:");
                cliente.Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el teléfono:");
                cliente.Telefono = Console.ReadLine();
                Console.WriteLine("Ingrese el correo:");
                cliente.Correo = Console.ReadLine();
                Console.Clear();
                double totalCompra = 0;

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Ingrese el precio del artículo " + i + ":");
                    double precio = double.Parse(Console.ReadLine());
                    totalCompra += precio;
                }
                Console.WriteLine("\nTotal de compra: " + totalCompra);

                if (totalCompra > 10000)
                {
                    Console.WriteLine("\nTiene de 3 a 6 meses sin intereses");
                }
                else if (totalCompra > 8000)
                {
                    Console.WriteLine("\nTiene 3 meses sin intereses");
                }
                else if (totalCompra > 5000)
                {
                    Console.WriteLine("\n¡Felicidades! Tiene un descuento del 10% en su compra: " + (totalCompra * 0.10));
                }
                Console.WriteLine("\nDatos ingresados:");
                Console.WriteLine("\nNombre: " + cliente.Nombre);
                Console.WriteLine("Apellido: " + cliente.Apellido);
                Console.WriteLine("Edad: " + cliente.Edad);
                Console.WriteLine("Teléfono: " + cliente.Telefono);
                Console.WriteLine("Correo: " + cliente.Correo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
            }
            return RealizarCompra();
        }
    }
}
