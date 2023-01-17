

namespace CSharpFundamentals
{
    class IfElse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the age: "); 
           int age = Convert.ToInt32(Console.ReadLine());
          
        
            if(age >= 23)
            {
                Console.WriteLine("One is said to be Adult");
            }
            else if(age >= 12)
            {
                Console.WriteLine("One is said to be teenager");
            }
            else if(age < 0)
            {
                Console.WriteLine("Invalid age");
            }
            else {
                Console.WriteLine("One is said to be child");
            }

        }
    }
}
