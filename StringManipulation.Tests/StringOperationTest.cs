using Humanizer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulation.Tests
{

    public class StringOperationTest
    {


        [Fact]
        public void ConcatenateStrings()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.ConcatenateStrings("Hello", "Platzi");

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello Platzi", result);
        }

        [Fact]
        public void IsPalindrome_True()
        {
            var strOperations = new StringOperations();

            var result = strOperations.IsPalindrome("oro");

            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            var strOperations = new StringOperations();

            var result = strOperations.IsPalindrome("Hello");

            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace()
        {
            var strOperations = new StringOperations();

            var result = strOperations.RemoveWhitespace("Hello I am Randy");

            Assert.Equal("HelloIamRandy", result);
        }

        [Fact]
        public void QuantintyInWords()
        {
            var strOperations = new StringOperations();

            var result = strOperations.QuantintyInWords("dog", 2);

            Assert.StartsWith("dos", result);
            Assert.Contains("dog", result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            var strOperations = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>(() => strOperations.GetStringLength(null));
        }

        [Fact]
        public void GetStringLength()
        {
            var strOperations = new StringOperations();

            var result = strOperations.GetStringLength("Platzi");

            Assert.Equal(6, result);
        }

        [Fact]
        public void TruncateString_Exception()
        {
            var strOperations = new StringOperations();

            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => strOperations.TruncateString("This is Platzi", 0));
        }

        [Theory]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("XX", 21)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            var strOperations = new StringOperations();

            var result = strOperations.FromRomanToNumber(romanNumber);

            Assert.Equal(expected, result);
        }
    }
}
