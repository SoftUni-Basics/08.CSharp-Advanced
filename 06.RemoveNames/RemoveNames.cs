/*  Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
    The input and output lists are given as words, separated by a space, each list at a separate line.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        List<string> firstList = Console.ReadLine().Split(' ').ToList();
        List<string> secondList = Console.ReadLine().Split(' ').ToList();

        for (int i = 0; i < secondList.Count; i++)
        {
            //firstList.ForEach(x => x == secondList[i]).
            firstList.RemoveAll(names => names == secondList[i]);
        }

        Console.WriteLine(string.Join(" ", firstList));
    }
}
