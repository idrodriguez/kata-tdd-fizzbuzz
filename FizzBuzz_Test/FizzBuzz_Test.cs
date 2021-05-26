using System;
using FizzBuzz_Impl;
using Xunit;

namespace FizzBuzz_Test
{
    public class FizzBuzz_Test
    {
        [Fact]
        public void return_number_one()
        {
            var returnvalue = FizzBuzzImpl.FizzBuzz(1);
            Assert.Equal("1", returnvalue);
        }

        [Fact]
        public void return_number_two() {
            var returnvalue = FizzBuzzImpl.FizzBuzz(2);
            Assert.Equal("2", returnvalue);
        }
    }
}
