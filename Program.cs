// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace CSharpFundamentals {
    public enum ShippingMethod {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public class a
    {
        public void Test(int a) {
            Console.WriteLine(a);
        }
    }
    class Program {
        static void Main(string[] args) {
            a obj = new a();
            obj.Test(11);
            
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);    // converting Enum to integers // 

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);  // converting Integers to Enum // 

            Console.WriteLine(method.ToString());  // converting Enum to Strings //

            // getting a string and converting it to a different data type i.e. Enum //
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        }
    }
}
