using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_NumeroNFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int []valoresPrueba = new int[] { 0,1,2,3,4,5,6,7, 15, 25, 55};

            foreach (int n in valoresPrueba)            
                Console.WriteLine("valor:{0} --> {1}, recursivo: {2}", n, CalcularNFibonacci(n), CalcularNFibonacciRecursivo(n));
                
            Console.ReadLine();
        }
        
        public static int CalcularNFibonacci(int n)
        {            
            if (n > 1)
            {
                int fn = 0, f1 = 1, auxiliar = 0;
                for (int i = 1; i <= n; i++)
                {
                    auxiliar = f1 + fn;
                    fn = f1;
                    f1 = auxiliar;
                }
                return fn;
            }            
            return n;
        }

        public static int CalcularNFibonacciRecursivo(int n)
        {
            if (n > 1)
                return CalcularNFibonacci(n-1) + CalcularNFibonacci(n-2);
            return n;
        }
    }
}
