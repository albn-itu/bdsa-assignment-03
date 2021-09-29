using Xunit;
using System;
using System.Linq;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void test_given_nonreversed_string_reverse_string()
        {
            var given = "jeg er glad i dag!";
            var expected = "!gad i dalg re gej";
            
            Func<string,string> ReverseString = (input) => new string(input.Reverse().ToArray());
            var actual = ReverseString(given);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void given_two_decimals_return_product(){

            var input1 = 5.5;
            var input2 = 6.6;
            var expected = 36.3;

            Func<double, double, double> product = (x, y) => x*y;

            var actual = product(input1, input2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_given_whole_number_and_string_return_true_if_numerically_equal()
        {
            var inputString = "      00042       ";
            var inputNumber = 42;

            var expected = true;

            Func<int, string, bool> numericallyEqual = (number, text) => int.Parse(text.Trim()) == number;

            var actual = numericallyEqual(inputNumber, inputString);

            Assert.Equal(expected,actual);
        }
          
    }
}
