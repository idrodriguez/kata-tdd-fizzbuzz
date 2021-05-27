using System;

namespace FizzBuzz_Impl
{
    public class FizzBuzzImpl
    {
        public static string FizzBuzz(int input) {
            // fake it, obvious implementation, triangulation
            if (input % 3 == 0)
                return "Fizz";
            
            if (input == 5)
                return "Buzz";
                
            return input.ToString();
        }
    }
}
