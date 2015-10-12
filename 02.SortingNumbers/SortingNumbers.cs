/*  Write a program that reads a number 'n' and a sequence of 'n' integers, sorts them and prints them.
*/

using System;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Enter count of numbers:  ");
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("No{0}:  ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Array.Sort(numbers);
        Console.WriteLine("Sorted numbers:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}
