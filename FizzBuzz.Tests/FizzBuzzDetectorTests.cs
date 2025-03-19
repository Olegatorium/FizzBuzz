using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    public class FizzBuzzDetectorTests
    {
        [Fact]
        public void GetOverlappings_InputWithFizzBuzzPattern_ReturnsCorrectOutput()
        {
            // Arrange
            var detector = new FizzBuzzDetector();
            string input = "Mary had a!@4 little lamb @ $ ^&* Little lamb, little lamb Mary had a little lamb     It's";

            // Act
            var result = detector.getOverlappings(input);

            // Assert
            Assert.Equal("Mary had Fizz little Buzz @ $ ^&* Fizz lamb, little Fizz Buzz had Fizz little lamb     FizzBuzz", result.Output);
            Assert.Equal(7, result.FizzBuzzCount);
        }

        [Fact]
        public void GetOverlappings_EmptyInput_ReturnsEmptyOutput()
        {
            // Arrange
            var detector = new FizzBuzzDetector();
            string input = "";

            // Act
            var result = detector.getOverlappings(input);

            // Assert
            Assert.Equal("", result.Output);
            Assert.Equal(0, result.FizzBuzzCount);
        }

        [Fact]
        public void GetOverlappings_InputWithOnlyNonAlphanumericCharacters_ReturnsUnchanged()
        {
            // Arrange
            var detector = new FizzBuzzDetector();
            string input = "@$% ^& )) :' !!!";

            // Act
            var result = detector.getOverlappings(input);

            // Assert
            Assert.Equal("@$% ^& )) :' !!!", result.Output);
            Assert.Equal(0, result.FizzBuzzCount);
        }

        [Fact]
        public void GetOverlappings_InputWithMultipleSpaces_PreservesSpaces()
        {
            // Arrange
            var detector = new FizzBuzzDetector();
            string input = "Dog    Cat   PlaNe   Laptop  Warsaw";

            // Act
            var result = detector.getOverlappings(input);

            // Assert
            Assert.Equal("Dog    Cat   Fizz   Laptop  Buzz", result.Output);
            Assert.Equal(2, result.FizzBuzzCount);
        }

        [Fact]
        public void GetOverlappings_LongText_CorrectlyHandlesFizzBuzz()
        {
            // Arrange
            var detector = new FizzBuzzDetector();
            string input = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25";

            // Act
            var result = detector.getOverlappings(input);

            // Assert
            Assert.Equal("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz", result.Output);
            Assert.Equal(12, result.FizzBuzzCount);
        }

        [Fact]
        public void GetOverlappings_InputWithMixedNumbersAndWords_HandlesCorrectly()
        {
            // Arrange
            var detector = new FizzBuzzDetector();
            string input = "one 2 three 4 five six 7 eight 9 ten";

            // Act
            var result = detector.getOverlappings(input);

            // Assert
            Assert.Equal("one 2 Fizz 4 Buzz Fizz 7 eight Fizz Buzz", result.Output);
            Assert.Equal(5, result.FizzBuzzCount);
        }
    }
}
