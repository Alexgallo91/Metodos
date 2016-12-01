using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            imprimirSaludo("Abraham");
            Console.ReadKey();

            int a = 10;
            int b = 120;

            Console.WriteLine(suma(a, b));
            Console.ReadKey();
        }

        static public void imprimirSaludo(String nombre)
        {
            Console.WriteLine("Hola {0}", nombre);
        }

        public static int suma(int a, int b)
        {
            return a + b;
        }
    }
}
