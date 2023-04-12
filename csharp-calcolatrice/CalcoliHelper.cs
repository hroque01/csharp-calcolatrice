using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal class CalcoliHelper
    {
        // Somma di due numeri interi
        public static int Somma(int x, int y)
        {
            return x + y;
        }


        // Somma di due numeri double
        public static double Somma(double x, double y)
        {
            return x + y;
        }

        //Differenza tra due numeri interi
        public static int Differenza(int x, int y)
        {
            return x - y;
        }

        //Differenza tra due numeri double
        public static double Differenza(double x, double y)
        {
            return x - y;
        }

        //Moltiplicazione di due numeri interi
        public static int Moltiplicazione( int x, int y)
        {
            return x * y;
        }
        public static double Moltiplicazione(double x, double y)
        {
            return x * y;
        }

        // Valore assoluto di un numero intero
        public static int ValoreAssoluto(int x)
        {
            return Math.Abs(x);
        }

        //Valore assoluto di un numero double
        public static double ValoreAssoluto(double x)
        {
            return Math.Abs(x);
        }

        //Minimo tra due numeri interi
        public static int Minimo (int x, int y)
        {
            if (x < y)
            {
                return x;

            } 
            else
            {

                return y;

            }
        }

        //Minimo tra due numeri double
        public static double Minimo(double x, double y)
        {
            if (x < y)
            {
                return x;

            }
            else
            {

                return y;

            }
        }

        //Massimo tra due numeri interi
        public static int Massimo(int x, int y)
        {
            if (x > y)
            {
                return x;

            }
            else
            {

                return y;

            }
        }
        //Massimo tra due numeri double
        public static double Massimo(double x, double y)
        {
            if (x > y)
            {
                return x;

            }
            else
            {

                return y;

            }
        }

    }
}
