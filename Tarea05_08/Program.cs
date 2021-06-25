using System;

namespace Tarea05_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int longitud = 10;
            int[] vector = new int[longitud];

            for (int i= 0; i< longitud; i++)
            {
                vector[i] = i;
            }
            Console.Write("Valores del vector de longitud {0}: ", longitud);
            for (int i =0; i<longitud; i++)
            {
                Console.Write("{0}, ", vector[i]);
            }

            Console.ReadKey();
        }
    }
}
