
/* Author: Maria del Carmen Perez-Soto de Paiva
 * Date: 2/2/2023
 * Description: Create a C# console application that computes 
 * the first 25 numbers of the Fibonacci sequence in a 
 * specific formula.
 */
using System; 

namespace Deliverable_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determining array size 
            int elements = 25;

            // Creating array and first elements of the array
            int[] fibonacci = new int[elements];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            // Creating a loop to execute the Fibonacci sequence and sintax
            for (int i=0; i < elements; i++)
            {
                if (i>= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
            } 
         }
    }
}