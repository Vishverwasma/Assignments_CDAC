using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20
{
    internal class Program
    {
        static void FibonnacciSeries(int n)
        {
            int first = 0, sec = 1;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"{first}");
                int nextTerm = first + sec;
                first = sec;
                sec = nextTerm;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This Progran Is To Find Fibonnacci Series : ");
            int n;
            Console.WriteLine("Enter A Number of terms : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci Series : ");
            FibonnacciSeries(n);
        }
    }
}
