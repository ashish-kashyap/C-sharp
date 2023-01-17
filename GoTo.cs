using System;

namespace CSharpFundamentals
{
    class GoTo
    {
        static void Main(string[] args)
        {
            repeat:
                Console.WriteLine("Enter a number less than 10: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if(number >= 10) {
                    goto repeat;
                }

                Console.WriteLine(number + " is less than 10");
                Console.ReadLine();
        }
    }
}