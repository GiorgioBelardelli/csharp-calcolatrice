using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class Calcolatrice
    {

        //Nel seguente codice, per attenermi al testo dell'esercizio ho specificato due funzioni per somma differenza moltiplicazione. Sottolineo peró che lo stesso risultato puó essere pttentuto anche solo
        //lasciando un'unico metodo che prenda in ingresso e ritorni double come tipi di numero. (Almeno credo ahah)

        //SOMMA
        public static int Somma(int a, int b)
        {
            return a + b;
        }

        public static double Somma(double a, double b)
        {
            return a + b;
        }

        //DIFFERENZA
        public static int Differenza(int a, int b)
        {
            return a - b;
        }

        public static double Differenza(double a, double b)
        {
            return a - b;
        }

        // MOLTIPLICAZIONE
        public static int Moltiplicazione(int a, int b)
        {
            return a * b;
        }

        public static double Moltiplicazione(double a, double b)
        {
            return a * b;
        }

        //CALCOLO IL VALORE ASSOLUTO 
        public static int ValoreAssoluto(int a)
        {
            return Math.Abs(a);
        }

        public static double ValoreAssoluto(double a)
        {
            return Math.Abs(a);
        }

        //CALCOLO IL MINIMO
        public static void Minimo(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine($" {a} é minore ");
            }
            else if (a > b)
            {
                Console.WriteLine($" {b} é minore ");
            }
            else
            {
                Console.WriteLine(" i numeri sono uguali ");
            }
        }

        public static void Minimo(double a, double b)
        {
            if (a < b)
            {
                Console.WriteLine($" {a} é minore ");
            }
            else if (a > b)
            {
                Console.WriteLine($" {b} é minore ");
            }
            else
            {
                Console.WriteLine(" i numeri sono uguali ");
            }
        }

        // CALCOLO IL MASSIMO
        public static void Massimo(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine($" {a} é maggiore ");
            }
            else if (a < b)
            {
                Console.WriteLine($" {b} é maggiore ");
            }
            else
            {
                Console.WriteLine(" i numeri sono uguali ");
            }
        }

        public static void Massimo(double a, double b)
        {
            if (a > b)
            {
                Console.WriteLine($" {a} é maggiore ");
            }
            else if (a < b)
            {
                Console.WriteLine($" {b} é maggiore ");
            }
            else
            {
                Console.WriteLine(" i numeri sono uguali ");
            }
        }

        //CALCOLO DEL NUMERO ELEVATO ALLA POTENZA
        public static int Potenza(int numerodaelevare, int esponente)
        {
            if (numerodaelevare == 0 && esponente <= 0)
            {
                return 1;
            }
            else if (esponente == 0)
            {
                return 1;
            }
            else if (esponente == 1)
            {
                return numerodaelevare;
            }
            else
            {
                int potenza = 1;

                for (int i = 0; i < esponente; i++)
                {
                    potenza *= numerodaelevare;
                }

                return potenza;
            }
        }


        //METODI
        public static void CalcolaSomma()
        {
            Console.WriteLine("Inserisci il primo numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = " + Somma(num1, num2));
        }
        public static void CalcolaDifferenza()
        {
            Console.WriteLine("Inserisci il primo numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{num1} - {num2} = " + Differenza(num1, num2));
        }
        public static void CalcolaProdotto()
        {
            Console.WriteLine("Inserisci il primo numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{num1} * {num2} = " + Moltiplicazione(num1, num2));
        }
        public static void CalcolaValoreAssoluto()
        {
            Console.WriteLine("Inserisci un numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Valore assoluto di {num1}: " + ValoreAssoluto(num1));
        }

        public static void RitornaMinimo() 
        {
            Console.WriteLine("Inserisci il primo numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Minimo(num1, num2);
        }
        public static void RitornaMassimo()
        {
            Console.WriteLine("Inserisci il primo numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Massimo(num1, num2);
        }
        public static void CalcolaPotenza() 
        {
            Console.WriteLine("Inserisci la base:");
            int numbase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci l'esponente:");
            int esponente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Potenza di {numbase} alla {esponente}: " + Potenza(numbase, esponente));
            
        }

    }

}

