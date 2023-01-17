using System;

namespace CSharpFundamentals
{
    class Switch
    {
        static void Main(string[] args)
        {
            char grade = 'A';
            Console.WriteLine("Your performance is: ");
            switch(grade)
            {
                case 'A': 
                        Console.WriteLine("Outstanding result!");
                        break;

                case 'B':
                        Console.WriteLine("Excellent Result!");
                        break;

                case 'C':
                        Console.WriteLine("Good Result!");
                        break;

                case 'D':
                        Console.WriteLine("Satisfying result!");
                        break;

                case 'E':
                        Console.WriteLine("Poor result!");
                        break;

                default:
                        Console.WriteLine("You did not pass for exam");
                        break;

            }
        }
    }
}