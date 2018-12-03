using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Crear OBJETO libro
            LibroValoraciones libro = new LibroValoraciones();
            
           /// Asignar Valoraciones
            libro.AgregarValoracion(2.5f);
            libro.AgregarValoracion(3.4f);
            libro.AgregarValoracion(1.3f);
            libro.AgregarValoracion(4.6f);
            libro.AgregarValoracion(2.7f);

            CalcularValoraciones publicar = libro.PublicarValoraciones();
            Console.WriteLine("CALCULO DE VALORACIONES");
            Console.WriteLine("=======================");
            Console.WriteLine("Promedio: " + publicar.promedioValoraciones);
            Console.WriteLine("Maximo: " + publicar.valoracionMax);
            Console.WriteLine("Minimo: " + publicar.valoracionMin);
            Console.ReadKey();
        }
    }
}
