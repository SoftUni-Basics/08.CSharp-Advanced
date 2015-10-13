/*  Write a program to find the longest word in a text.
*/

using System;
using System.Text.RegularExpressions;

class LongestWordInAText
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = Regex.Split(text, @"\W+");

        string longest = string.Empty;
        foreach (var word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }
        Console.WriteLine(longest);
    }
}
