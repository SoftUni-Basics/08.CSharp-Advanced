/*  Write a program that extracts and prints all URLs from given text. URL can be in only two formats
        http://, www
*/

using System;
using System.Text.RegularExpressions;

class ExtractURLsFromText
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        string http = "http://", www = "www";
        Console.WriteLine();
        
        for (int i = 0; i < words.Length; i++)
        {
            bool a = words[i].ToString().StartsWith(www);
            bool b = words[i].ToString().StartsWith(http);

            if (a || b)
            {
                Console.WriteLine(words[i].TrimEnd('.',' ', ',', '!', '?'));
            }
        }
        Console.WriteLine();
    }
}

/*
The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.
 */