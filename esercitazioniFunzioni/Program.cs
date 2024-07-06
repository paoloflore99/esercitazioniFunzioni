using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace esercitazioniFunzioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //calcolare la somma e la media dei numeri fra 2 e 10 
                int a = 8;
                int[] b = new int[a];
                int somma = 0;
                for (int i = 2 ; i <= b.Length + 1; i++)
                {
                    b[i - 2] = i ;
                }
                for (int i = 0; i < b.Length; i++)
                {
                    somma += b[i] ;
                    Console.WriteLine(b[i]);
                }
                Console.WriteLine($"la somma dei e {somma}");
                int media = somma / a;
                Console.WriteLine($"la media e {media}");
            }

            {
                //chiedere 10 volte un numero e fare la somma dei numeri 
                int[] y = new int[10];
                int m = 0;
                for (int i = 1; i < y.Length; i++)
                {
                    Console.Write("inseririsci un numero ");
                    y[i] = Convert.ToInt32(Console.ReadLine());
                    m += y[i];
                }
                Console.WriteLine($"{m}"); 
            }

            {
                //lutente iserisce 2 numeri e stampo il maggiore 
                int a, b;
                Console.Write("inseririsci il primo numero ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("inseririsci il secondo numero ");
                b = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine($"i numeri sono uguali");
                }
                else
                {
                    int maggiore = a > b ? a : b;
                    Console.WriteLine($"il maggiore e {maggiore}");
                }
            }
        }
    }
}
