using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int num1 = 5, num2, resultado;

            //Preguntamos al usuario el número
            Console.Write("Dame un número para sumarlo: ");
            //Se asigna la variable de tipo string
            cadena = Console.ReadLine();
            num2 = Int32.Parse(cadena);
            //num2 = Convert.ToInt32(cadena);
            //Realizar la suma
            resultado = num1 + num2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();

        }
    }
}
