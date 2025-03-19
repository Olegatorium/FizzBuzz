using FizzBuzz;

public class Program
{
    public static void Main(string[] args)
    {
        FizzBuzzDetector fizzBuzzDetector = new FizzBuzzDetector();

        string input = "Mary had a!@4 little lamb @ $ ^&* Little lamb, little lamb Mary had a little lamb     It's";

        Console.WriteLine("Input:");
        Console.WriteLine(input + "\n");

        FizzBuzzResult result = fizzBuzzDetector.getOverlappings(input);

        Console.WriteLine("Output:");
        Console.WriteLine(result.Output + "\n");

        Console.WriteLine($"FizzBuzz Count: {result.FizzBuzzCount}");
    }
}