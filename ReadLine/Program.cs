﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            //Preguntamos el nombre del usuario
            Console.WriteLine("Cómo te llamas: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola" + nombre + "Quieres ver el menu?");
            Console.ReadKey();


        }
    }
}
