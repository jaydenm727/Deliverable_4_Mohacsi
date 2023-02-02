/*
Name: Jayden Mohacsi
Date: 02/02/2023
Description: Print the first 25 numbers in the fibonacci sequence
*/
namespace Deliverable_4_Mohacsi
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] even = new int[25];
            int[] odd = new int[25];
            int[] fibonacci = new int[25];
            
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < 25; i++)
            {
                even[i] = 2 * i;
                odd[i] = 2 * i + 1;
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }
            
            for(int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine("Fibonacci number ("+i+") = " + fibonacci[i]);   
            }
        }
    }
}
