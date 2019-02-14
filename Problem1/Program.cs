using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ass, pCounter=0; 
            // ass is variable for size of the list and pCounter is counter for counting the prime numbers
            ass = Convert.ToInt32(Console.ReadLine()); 
            // read the variable ass, and to get numbers in any case, it is used the Convert.ToInt

            List<int> primeList = new List<int> { };
            //list for saving the Prime numbers
            for (int j=0; j<ass; j++) // for loop to limit the entering numbers before ass number
            {
                int a, count = 0; // a is variable for testing whether it is prime number or not 
                // count is variable for counting the factors of a(variable)
                a = Convert.ToInt32(Console.ReadLine()); 
                //read the a
                 
                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0) //finding all factors of a
                    {
                        count++; // if it is factor, increment the count variable
                    }
                }
                if (count == 2) 
                    // if the number of factors is equal to 2
                {
                    pCounter++; // increment the pCounter to 1

                    primeList.Add(a); //add this element to List "primeList"
                    
                }
                
            }

            Console.WriteLine(pCounter); // out the number of Prime numbers
            

            for(int i=0; i<primeList.Count; i++)
            {
                Console.Write(primeList[i] + " "); // out all list elements
            }

            /*for (int i=0; i<ass; i++)
            {
                Console.WriteLine(numArr[i]);
            }

            for (int i=0; i<ass; i++)
            {
                int check;
                numArr[i] = check;
                Console.
            }*/




            /*
            // Determine is the given number is Prime or NOT
            int prime,count=0;
            prime = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= prime; i++)
            {
                if (prime % i == 0)
                {
                    count++;
                }
            }
                if (count == 2)
                {
                    Console.WriteLine(prime + " is Prime");
                } else
                {
                    Console.WriteLine(prime + "is not Prime");
                }
                */
                                                    
            


        }
    }
}
