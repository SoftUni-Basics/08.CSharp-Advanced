/*  Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence. 
    In other words, you should remove a minimal number of numbers from the starting sequence, so that the resulting sequence is non-decreasing. 
    In case of several longest non-decreasing sequences, print the leftmost of them. 
    The input and output should consist of a single line, holding integer numbers separated by a space.     
*/

using System;
using System.Linq;
using System.Collections.Generic;

class LongestSubsequence
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> equalSequence = new List<int>();
        equalSequence = CheckingEquals(numbers);

        List<int> risingSequence = new List<int>();
        risingSequence = CheckingForRising(numbers);

        if (risingSequence.Count > equalSequence.Count)
        {
            PrintLongerSequence(risingSequence);
        }
        else
        {
            PrintLongerSequence(equalSequence);
        }
    }

    static List<int> CheckingEquals(List<int> numbers)
    {
        List<int> temp = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            temp.Add(numbers[i]);
        }

        List<int> longestSequ = new List<int>();
        while (temp.Count > 0)
        {
            List<int> currentSequ = new List<int>();
            for (int col = 0; col < temp.Count; col++)
            {
                if (temp[0] == temp[col])
                {
                    currentSequ.Add(temp[col]);
                }
            }
            temp.RemoveAll(i => i == currentSequ[0]);
            if (currentSequ.Count > longestSequ.Count)
            {
                longestSequ = currentSequ;
            }
        }
        return longestSequ;
    }

    static List<int> CheckingForRising(List<int> numbers)
    {
        List<int> temp = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            temp.Add(numbers[i]);
        }

        List<int> longestSequ = new List<int>();
        while (temp.Count > 0)
        {
            List<int> currentSequ = new List<int>();
            int lastBig = int.MinValue;

            for (int col = 0; col < temp.Count; )
            {
                if (temp[col] > lastBig)
                {
                    lastBig = temp[col];
                    currentSequ.Add(temp[col]);
                    temp.Remove(lastBig);
                }
                else
                {
                    col++;
                }
            }

            if (currentSequ.Count > longestSequ.Count)
            {
                longestSequ = currentSequ;
            }
        }
        return longestSequ;
    }

    static void PrintLongerSequence(List<int> risingSequence)
    {
        foreach (var number in risingSequence)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}
