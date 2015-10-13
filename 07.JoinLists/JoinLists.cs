/*  Write a program that takes as input two lists of integers and joins them. 
    The result should hold all numbers from the first list, and all numbers from the second list, 
 * without repeating numbers, and arranged in increasing order. 
    The input and output lists are given as integers, separated by a space, each list at a separate line.  */

using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        SortedSet<int> output = new SortedSet<int>();

        AddValuesToSortedSet(firstList, output); 
        AddValuesToSortedSet(secondList, output);

        Console.WriteLine(string.Join(" ", output));
    }

    private static void AddValuesToSortedSet(List<int> list, SortedSet<int> output)
    {
        int length = list.Count;
        for (int i = 0; i < length; i++)
        {
            output.Add(list[i]);
        }
    }
}
