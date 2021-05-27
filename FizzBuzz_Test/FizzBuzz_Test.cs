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

        [Fact]
        public void return_number_four() {
            var returnvalue = FizzBuzzImpl.FizzBuzz(4);
            Assert.Equal("4", returnvalue);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void return_only_fizz_numbers(int inputValue)
        {
            var returnvalue = FizzBuzzImpl.FizzBuzz(inputValue);
            Assert.Equal("Fizz", returnvalue);
        }

        [Fact]
        public void return_number_five_buzz() {
            var returnvalue = FizzBuzzImpl.FizzBuzz(5);
            Assert.Equal("Buzz", returnvalue);
        }
    }
}
