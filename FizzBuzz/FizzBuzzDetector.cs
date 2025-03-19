using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzDetector
    {
        public FizzBuzzResult getOverlappings(string input) 
        {
            int fizzCount = 0, buzzCount = 0, fizzBuzzCount = 0;

            string[] words = input.Split(' ');

            int wordCount = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].Any(c => char.IsLetterOrDigit(c)))
                {
                    continue;
                }

                wordCount++;
                bool isFizz = wordCount % 3 == 0;
                bool isBuzz = wordCount % 5 == 0;

                if (isFizz && isBuzz)
                {
                    words[i] = "FizzBuzz";
                    fizzBuzzCount++;
                }
                else if (isFizz)
                {
                    words[i] = "Fizz";
                    fizzCount++;
                }
                else if (isBuzz) 
                {
                    words[i] = "Buzz";
                    buzzCount++;
                }
            }

            return new FizzBuzzResult
            {
                Output = string.Join(" ", words),
                FizzBuzzCount = fizzBuzzCount + fizzCount + buzzCount
            };
        }
    }
}
