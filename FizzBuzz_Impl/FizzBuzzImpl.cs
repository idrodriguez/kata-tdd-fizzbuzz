using System;

namespace FizzBuzz_Impl
{
    public class FizzBuzzImpl
    {
        public static string FizzBuzz(int input) {
            // fake it, obvious implementation, triangulation

            if (input % 15 == 0)
                return "FizzBuzz";

            if (input % 3 == 0)
                return "Fizz";

            if (input % 5 == 0)
                return "Buzz";

            return input.ToString();
        }
    }
}
