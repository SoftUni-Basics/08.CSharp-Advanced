/*  Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns.
*/

using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("Enter rows of the matrix = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter columns of the matrix = ");
        int cols = int.Parse(Console.ReadLine());
        
        for (int r = 0; r < rows; r++)
        {
            char ch = (char)(97 + r);
            for (int c = 0; c < cols; c++)
            {
                Console.Write("{0}{1}{0} ", ch, (char)(ch + c));
            }
            Console.WriteLine();
        }
    }
}
