using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Follow the instructions provided in each comment below to complete the exercise.
            // Use the example given to guide your implementation.

            //Create a List called "numbers" - DONE!
            List<int> numbers = new List<int>();  //DO NOT ERASE THIS! You will use this in the exercise.
            
            //-----START HERE------------------------------------------

            int num = 0; // Initialize num to 0

            //TODO - Create a variable of type int and name it "num"
            //TODO - Initialize the variable with a value of 0.

            //TODO - Create a do-while loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop:
            // a) Increment "num" by 1
            // b) Then add "num" to the collection "numbers"
            //    Hint: Use "numbers.Add(num);" to add the current value of "num" to the list.

            {
                do
                {
                    num++; // Increment Num by 1

                    numbers.Add(num); // Add the current value of num to the list.

                } while (num <= 100); // Continue the loop while num is less than or equal to 100
                numbers.Add(num);
            } 
            //TODO - Continue the loop while "num" is less than 100
            

            //TODO - Create a while loop using the existing brackets as a template.
            //TODO - Continue the loop while "num" is less than 200
            // The existing brackets are placeholders for your loop code.
            // Inside this loop:
            // a) Increment "num" by 1
            // b) Then add "num" to the collection "numbers"
            //    Hint: You can copy how this was done in the do-while loop

            {
                while (num < 200)
                    num++; // Increment num by 1
                    numbers.Add(num); // Add the current value of num to the list.
                console.writeline(Increase);
            }
            


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            //TODO - Create a foreach loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop, print each number in "numbers".
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number); // Print each number in the list
                }
            }
             


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            //TODO - Create a for loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // This loop will print the numbers in reverse order - from 200 to 1.

            // a) In your initializer, set the value of "i" to 199
            // b) In your conditional, ensure that the loop continues as long as "i" is:
            //    - Less than or equal to the number of items in "numbers" (use "numbers.Count")
            //    - Greater than or equal to 0
            // c) Decrement "i" by 1 in each iteration

            {
               for (int i = 199; i >= 0; i--) // Start from 199 and go down to 0
                    Console.WriteLine(numbers[i]);
            }

            //------------End of exercise

        }
    }
}
