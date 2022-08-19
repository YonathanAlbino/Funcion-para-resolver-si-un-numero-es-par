using System;

namespace ejercicio2_Maxi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares. */

            int n, cont = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un valor:");
                n = int.Parse(Console.ReadLine());
                if(par(n) == true)
                cont++;
            }
            Console.WriteLine(cont);
        }

        static bool par(int a){
            if(a % 2 == 0)
                return true;
            else
                return false;

            
        }
    }
}
