/*  Write a program to find the longest area of equal elements in array of strings. 
    You first should read an integer n and n strings (each at a separate line), 
    then find and print the longest sequence of equal elements (first its length, then its elements). 
    If multiple sequences have the same maximal length, print the leftmost of them.
*/

using System;
using System.Collections.Generic;

class LongestArea
{
    static void Main()
    {
        Console.Write("Enter count of elements: ");
        int count = int.Parse(Console.ReadLine());
        
        List<string> elements = new List<string>();
        for (int i = 0; i < count; i++)
        {
            Console.Write("No{0}: ", (i + 1));
            elements.Add(Console.ReadLine());
        }

        int longestIndex = 0;
        int longSequence = 0;
        for (int i = 0; i < elements.Count; )
        {
            int counter = 0;
            while ((elements[counter + i] == elements[i]))
            {
                counter++;
                if (counter + i >= elements.Count)
                {
                    break;
                }
            }
            if (counter > longSequence)
            {

                longSequence = counter;
                longestIndex = i;
            }
            i += counter;
        }

        Console.WriteLine();
        Console.WriteLine(longSequence);
        for (int i = longestIndex; i < (longestIndex + longSequence); i++)
        {
            Console.WriteLine(elements[i]);
        }
    }
}
