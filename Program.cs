using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casa
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 10;
            int b = 20;
            Console.WriteLine("La multiplicacion de {0} x {1} es {2}", a, b, (a * b));
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            //condicionales
            if (a > b)
                Console.WriteLine("{0} es mayor", a);

            else
                Console.WriteLine("{0} es mayor", b);
            Console.WriteLine("Hola papa...!!1");
            Console.WriteLine("Pulse la tecla para continuar...");
            Console.ReadKey();
            //BUCLE while
            int j = 10;
            while (j <= 10)
            {
                j++;
                Console.WriteLine("{0}Bienvenidos a GIT ", j);
                Console.ReadKey();
            }
        }
    }
}
