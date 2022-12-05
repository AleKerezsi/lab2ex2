using System;

namespace lab2ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 
		Scrieti un program care va afisa factorialul unui numar n, n fiind citit de la tastatura
		*/
		
		Console.WriteLine("Introduceti n= ");
		int n ;
		n = int.Parse(Console.ReadLine());
		
		int factorial = 1;
		
		for(int i=1;i<n;i++)
		{
			factorial = factorial * i;
		}
		
		Console.WriteLine("Factorialul lui " + n + " este " + factorial);
        }
    }
}
