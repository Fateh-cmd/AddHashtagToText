using System;

class Program
{
    static string AddHashtagToText()
    {

        Console.Write($"Please enter some text: ");
        string text = Console.ReadLine();

        // Prefix the text entered with #
        string result = $"#{text}";

        return result;
    }

    static void Main()
    {
        string hashtagText = AddHashtagToText();
        Console.WriteLine($"{hashtagText}");
    }
}
