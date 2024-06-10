using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    internal class RecursiveAndIteration
    {
        public int  RecursiveOdd(int n)
        {
            if(n== 1)
            {
                return 1;
            }
            return(RecursiveOdd(n - 1) + 2);
        }
        public int RecursiveEven(int n)
        { 
            if (n == 1)
            {
                return 2; 
            }
            return RecursiveEven(n - 1) + 2; 
        }
        public int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n; 
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public int IterativeOdd(int n)
        {
            int result = 1;
            for (int i = 0; i < n - 1; i++)
            {
                result += 2;
            }
            return result;
        }
        public int IterativeEven(int n)
        {
            int result = 0;
            for (int i = 0; i < n - 1; i++)
            {
                result += 2;
            }
            return result;
        }
        public int IterativeFibonacci(int n)
        {
            if (n <= 0) 
                return 0; 
            if (n == 1) 
                return 1;

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

    }
}
