namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            Console.WriteLine($"{number} is odd: {number.IsOdd()}");
            number = 4;
            Console.WriteLine($"{number} is odd: {number.IsOdd()}");
            int number2 = 8;
            Console.WriteLine($"{number2} is even: {number2.IsEven()}");
            number2 = 5;
            Console.WriteLine($"{number2} is even: {number2.IsEven()}");
            int number3 = 11;
            Console.WriteLine($"{number3} is prime: {number3.IsPrime()}");
            number3 = 12;
            Console.WriteLine($"{number3} is prime: {number3.IsPrime()}");
            string text = "Hello World!";
            Console.WriteLine($"Number of vowels in '{text}': {text.CountVowels()}");
            text = "Programming is fun!";
            Console.WriteLine($"Number of vowels in '{text}': {text.CountVowels()}");
            string text2 = "Hello World!";
            Console.WriteLine($"Number of consonants in '{text2}': {text2.CountConsonants()}");

            text2 = "Programming is fun!";
            Console.WriteLine($"Number of consonants in '{text2}': {text2.CountConsonants()}");
        }
    }
}
public static class IntegerExtensions
{
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }
}
public static class IntegerExtensions2
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}
public static class IntegerExtensions3
{
    public static bool IsPrime(this int number)
    {
        if (number <= 1) return false;
        if (number <= 3) return true;

        if (number % 2 == 0 || number % 3 == 0) return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0) return false;
        }

        return true;
    }
}
public static class StringExtensions
{
    public static int CountVowels(this string input)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        return input.Count(c => vowels.Contains(c));
    }
}
public static class StringExtensions
{
    public static int CountConsonants(this string input)
    {
        char[] consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".ToCharArray();
        return input.Count(c => consonants.Contains(c));
    }