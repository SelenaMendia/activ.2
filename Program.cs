using System;

namespace activ._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CantDias=7;
            //int [] arregloNumeros = new int [CantDias];
            string[] dias = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};

            for (int i = CantDias-1; i >= 0; i--)
            {
                Console.WriteLine("En el elemento {0} es el dia {1}",i,dias[i]);
            }

            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
