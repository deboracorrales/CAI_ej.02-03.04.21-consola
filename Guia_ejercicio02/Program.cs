using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_ejercicio02
//Ej 02: Solicite el ingreso de un texto cualquiera y lo presente nuevamente al usuario.
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Ingrese una frase.");
            texto = Console.ReadLine();
            Console.WriteLine("Usted ingreso: " + texto);
            
            Console.ReadKey();
            //est es una prueba
        }
    }
}
