
using ActividadTienda.D.Services;
using System;

namespace ActividadTienda.D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Funciones funciones = new Funciones();
                funciones.RealizarCompra();
            }
        }
    }
}
