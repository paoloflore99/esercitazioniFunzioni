﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;

namespace esercitazioniFunzioni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                //Scrivi una funzione che data una stringa in ingresso restituisca il numero di vocali di cui è composta
                int a(string c)
                {
                    int f = 0;
                    string r = "aeiou";
                    for (int i = 0; i < c.Length; i++)
                    {
                        if (r.Contains(c[i]))
                        {
                            f= f + 1;
                            
                        }
                    }
                    return f;
                }

               int numerovocali =  a("23a");
                Console.Write(numerovocali);
            }
            {
                void s()
                {
                    Console.Write("( ");

                }
                void acc(ref int[] e)
                {
                    s();
                    for (int i = 0; i < e.Length; i++)
                    {
                        e[i] = i;
                        Console.Write(e[i]);
                    }
                    Console.Write(" ) ");
                }
                int[] t = { 1, 2, 3 , 4, 5, 6,6,7, 8,9,6,4};
                acc(ref t);
            }
            {
                int nome(int a, int b)
                {
                    int risultato = a + b;

                    return risultato;
                }
                int c = nome(10, 20);
                Console.WriteLine(c);
            }
            {
                //chiedo di inserire 6 volte un valore , se il valore e disparo lo inserisco nell'array
                //se il valore e pari lascio 0 
                int b = 6;
                int[] a = new int[b];
                int t ;
                for (int i = 0; i < b; i++)
                {
                    Console.WriteLine("inserisci un valore");
                    t = Convert.ToInt32(Console.ReadLine());
                    if (t % 2 == 1)
                    {
                        a[i] = t; 
                    }
                }
                for (int i = 0;i < b; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
            {
                //creo un array di nomi e vedo se ce il nome inserito 
                string[] s = { "paolo", "flore", "anna", "franco" };
                Console.WriteLine("inserisci un nome ");
                string r;
                int i;
                r = Console.ReadLine();
                for ( i = 0; i < s.Length; i++)
                { 
                    if (s[i] == r)
                    {
                        Console.WriteLine($"puoi entrare {r}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("non puoi entrare ");
                        break;

                    }
                }

            }
            {
                //chiedo di di mettere un numero se pari stampo il numereo , se dispari stampo quello sucessivo
                int p;
                Console.Write("inserisci numero ");
                p = Convert.ToInt32(Console.ReadLine());
                if (p % 2 == 1 )
                {
                    Console.WriteLine($"il numero {p} adesso e {p + 1} ");
                }
                else
                {
                    Console.WriteLine($"il numero{p} inserito e pari ");
                }
            }

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
