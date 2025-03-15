using System;
using System.Text;
using System.Linq;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        // Task 1
        string str1 = "Hello World";
        string insertStr = "Beautiful ";
        Console.WriteLine("Enter a desired position: ");
        int position = Int32.Parse(Console.ReadLine());
        string result1 = str1.Insert(position, insertStr);
        Console.WriteLine("Result: " + result1);
        //Task 2
        string str2 = "racecar";
        bool isPalindrome = str2.SequenceEqual(str2.Reverse());
        Console.WriteLine("Is it a palindrome: " + (isPalindrome ? "Yes" : "No"));
        // Task 3
        Console.WriteLine("Enter a word/text: ");
        string text = Console.ReadLine();
        int totalChars = text.Count(char.IsLetter);
        int upperCount = text.Count(char.IsUpper);
        int lowerCount = text.Count(char.IsLower);
        Console.WriteLine("Uppercase: " + (upperCount * 100.0 / totalChars) + "% , Lowercase: " + (lowerCount * 100.0 / totalChars) + "%");
        //Task 4
        string[] words = { "hello", "world", "example", "test", "coding" ,"a", "bb", "ccc", "dddd", "fffff"};
        Console.WriteLine("Enter a desired length: ");
        int targetLength = Int32.Parse(Console.ReadLine());
        var result4 = words.Select(w => w.Length == targetLength ? w.Substring(0, w.Length - 3) + "$$$" : w);
        Console.WriteLine("Result: " + string.Join(", ", result4));
        //Task 6
        string str6 = "  Hello    world   from  C#  ";
        string result6 = string.Join("*", str6.Split(' ', StringSplitOptions.RemoveEmptyEntries));
        Console.WriteLine("Result: " + result6);
        //Task 7
        StringBuilder sb = new StringBuilder();
        string input;
        while (true)
        {
            input = Console.ReadLine();
            if (input.EndsWith("."))
            {
                sb.Append(input);
                break;
            }
            sb.Append(input + ", ");
        }
        Console.WriteLine("Result: " + sb.ToString());
    }
}

