using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            var myNumber = 0;


            // Create a do-while loop and use the template below:
      
            {
                // Increment num by 1

                // Then add num to the collection - numbers
                    // Hint: reference num inside of the Add method's parentheses
                /*numbers.Add*/

            } // <---- While your variable is less than 100
            do
            {
                myNumber++;

                numbers.Add(myNumber);

            } while (myNumber < 100);


            // Create a while loop
            // <--- While num is less than 200
            while(myNumber < 200)
            {
                // Increment num by 1
                myNumber++;
                // Then add num to the collection numbers
                numbers.Add(myNumber);
                    //HINT: copy how this was done in the do while loop

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers
             foreach(var item in numbers)
            {
                Console.WriteLine($"{numbers}");
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i >= 0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
            }

            //------------End of exercise
        }
    }
}
//------------Exercise One ------------------
//  1  for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"{i}");
//}
//  2  for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"{i}");
//}
//  3 for (int i = 0; i < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//  4 for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//5   for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//6   for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//7   for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//8   for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//9   for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//10   for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//11  for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//12   for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//13   for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//14   for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{i}");
//}
//15 for (int i = 0; < 5; i++) ;
//{
//    Console.WriteLine($"{int}");
//}