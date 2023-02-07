/*
 * Author:      Christian Amith
 * Course:      COMP-003A-L01
 * Purpose:     Code for 4th week assignment
 */
using System.Reflection.Metadata;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string border = "*************************************************";

            // for loop Section
            Console.WriteLine(border);
            Console.WriteLine("for Loop Section\nOutput a right triangle based on user input");
            Console.WriteLine(border);
            Console.Write("Enter a positive whole number: ");

            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";

            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }

            // foreach Section
            Console.WriteLine("\n\n" + border);
            Console.WriteLine("foreach Section\nOutput all of the friends in an array");
            Console.WriteLine(border);

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
            foreach (string friend in friends)
                Console.WriteLine(friend);

            // do-while Section
            Console.WriteLine("\n\n" + border);
            Console.WriteLine("do-while Section\nOutput 0-50 by 5s");
            Console.WriteLine(border);

            int counter = 0;

            do
            {
                Console.WriteLine(counter);
                counter = counter + 5;
            }
            while(counter <= 50);

            // while Section
            Console.WriteLine("\n\n" + border);
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine(border);

            int counter2 = 1;
            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0 & counter2 % 5 == 0)
                    Console.WriteLine("FooBar");
                else if (counter2 % 5 == 0)
                    Console.WriteLine("Bar");
                else if (counter2 % 2 == 0)
                    Console.WriteLine("Foo");
                else Console.WriteLine(counter2);
                counter2++;
            }
        }
    }
}