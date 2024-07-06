using System;

class Program
{
    public static void Main(string[] args)
    {
        // Example 1: Parsing an integer
        string numStr1 = "123";
        int num1 = int.Parse(numStr1);
        Console.WriteLine("Parsed integer value: {0}", num1);

        // Example 2: Parsing a double
        string numStr2 = "456.78";
        double num2 = double.Parse(numStr2);
        Console.WriteLine("Parsed double value: {0}", num2);

        // Example 3: Parsing an invalid input (handled by default behavior of Parse)
        string invalidStr = "abc";
        int invalidNum = int.Parse(invalidStr); // This line will throw a FormatException
        Console.WriteLine("Parsed value of invalid input: {0}", invalidNum);
    }
}
