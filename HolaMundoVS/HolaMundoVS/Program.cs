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
            Console.WriteLine("Hoy es: " + DateTime.Today.Day + " del " + DateTime.Today.Month);
            Console.WriteLine("Hola Mundo!");
            Console.ReadKey();
        }
    }
}
