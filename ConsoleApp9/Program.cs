using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {  
            NumeroPerfectoWhile();
        }
        static void NumeroPerfecto()
        {
            int numero, suma = 0;
            Console.WriteLine("ingrese numero:");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma = suma + i;
                }
            }

            if (suma == 0)
            {
                Console.WriteLine("numero perfecto");
            }
            else
            {
                Console.WriteLine("numero no es perfecto");

            }
        }
        static void NumeroPerfectoWhile()
        {
            int numero, suma = 0, div;

            Console.WriteLine("ingresa un numero; ");
            numero = int.Parse(Console.ReadLine());
            div = numero;
            while (div> 0)
            {
                if(numero%div==0)
                {
                    suma = suma + div;
                }
                div--;
            }
            Console.WriteLine("suma: "+ suma);


        }
    }
}
