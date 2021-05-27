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

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void return_only_buzz_numbers(int inputValue)
        {
            var returnvalue = FizzBuzzImpl.FizzBuzz(inputValue);
            Assert.Equal("Buzz", returnvalue);
        }

        [Fact]
        public void return_number_fifteen_fizzbuzz() {
            var returnvalue = FizzBuzzImpl.FizzBuzz(15);
            Assert.Equal("FizzBuzz", returnvalue);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        public void return_only_fizzbuzz_numbers(int inputValue)
        {
            var returnvalue = FizzBuzzImpl.FizzBuzz(inputValue);
            Assert.Equal("FizzBuzz", returnvalue);
        }
    }
}
