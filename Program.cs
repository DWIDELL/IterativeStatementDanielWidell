using System;

namespace IterativeStatementDanielWidell
{
    class Program
    {
        static void Main(string[] args)
        {
           
          // How would someone program a parameter for integers only while only using one type of iteration?
          // the example used in the iterative video was a do-while, but it seems that this 'for' statement is the most straight-forward
          // is there a way to set a parameter for the user input while using for statements?
          // When I attempt to set the initial value to 2, everything gets messed up.
          // This is where I am stuck, I am prevented from setting a parameter for the numbers input.
          // The convert line prevents non-integer values from being written.


            Console.WriteLine("Please enter an integer value between 2 and 10.");
            int x = Convert.ToInt32(Console.ReadLine());
            int start = 0;
           
            if (x%2 == 1) // for the odd numbers
            {
            for (int i=start; i<x-1; i++) // a response will not be produced for 1
                Console.WriteLine("You entered an odd number");
               
            }
            else // for the even numbers
            {
            for (int i=start; i<x+1; i++) // a response will be produced for 0
                Console.WriteLine("You entered an even number");
                
            }

        }



    }
    }

