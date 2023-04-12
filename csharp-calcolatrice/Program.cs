using System.Security.Cryptography.X509Certificates;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Somma
            int result1 = CalcoliHelper.Somma(10, 2);
            double result2 = CalcoliHelper.Somma(10.5, 3.95);
            Console.WriteLine($"Somma interi {result1} || Somma decimali {result2}");

            Console.WriteLine("------");

            // Differenza
            int result3 = CalcoliHelper.Differenza(5, 3);
            double result4 = CalcoliHelper.Differenza(2.2, 7.7);
            Console.WriteLine($"Somma interi {result3} || Somma decimali {result4}");

            Console.WriteLine("------");

            // Moltiplicazione
            int result5 = CalcoliHelper.Moltiplicazione(55, 98);
            double result6 = CalcoliHelper.Moltiplicazione(67.5, 3.4);
            Console.WriteLine($"Moltiplicazione {result5} || Moltiplicazione {result6}");


            Console.WriteLine("------");

            // Valore Assoluto
            int result7 = CalcoliHelper.ValoreAssoluto(-9);
            double result8 = CalcoliHelper.ValoreAssoluto(-4.2);
            Console.WriteLine($"Valore Assoluto intero {result7} || Valore Assoluto decimale {result8}");


            Console.WriteLine("------");

            // Minimo
            int result9 = CalcoliHelper.Minimo(22, 48);
            double result10 = CalcoliHelper.Minimo(26.5, 88.63);
            Console.WriteLine($"Minimo {result9} || Minimo {result10}");


            Console.WriteLine("------");

            // Massimo
            int result11 = CalcoliHelper.Massimo(88, 2);
            double result12 = CalcoliHelper.Massimo(55.5, 2.98);
            Console.WriteLine($"Massimo {result11} || Massimo {result12}");
        }
    }
}