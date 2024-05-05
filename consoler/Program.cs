// See https://aka.ms/new-console-template for more information
using AljabarLibraries;
using System;

class Program
{
        static void Main(string[] args)
        {
            
            AljabarCalculator calculator = new AljabarCalculator();

        
            
            double[] akar = calculator.AkarPersamaanKuadrat([ 1, -3, -10 ]);
            Console.WriteLine("Akar persamaan kuadrat 1: " + akar[0] + ", "+ akar[1]);

          
            
            double[] hasilKuadrat = calculator.HasilKuadrat([2,-3]);
            Console.WriteLine("Hasil kuadrat persamaan 2: " + hasilKuadrat[0]);
        }
    
}

