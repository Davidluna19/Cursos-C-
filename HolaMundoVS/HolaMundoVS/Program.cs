using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoVS
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = args[0];
            Console.WriteLine("Hola Mundo!");
            Console.WriteLine(nombre + " hoy es: " + DateTime.Today.Day + " del " + DateTime.Today.Month);
            Console.ReadKey();
        }
    }
}
