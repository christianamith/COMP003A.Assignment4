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

            // FOR LOOP SECTION

            Console.WriteLine("*************************************************");
            Console.WriteLine("for Loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("*************************************************");

            Console.Write("Enter a positive whole number: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";

            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }
        }
    }
}