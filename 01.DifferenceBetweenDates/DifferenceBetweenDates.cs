/*  Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.
*/

using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        string format = "d.MM.yyyy";
        DateTime[] dates = new DateTime[2];

        for (int i = 0; i < dates.Length; i++)
        {
            string input = Console.ReadLine();
            dates[i] = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
        }

        int daysDifference = (dates[1] - dates[0]).Days;
        Console.WriteLine("Days difference:  {0}", daysDifference);
    }
}
