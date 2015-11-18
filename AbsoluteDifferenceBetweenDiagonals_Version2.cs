/*Problem Statement

You are given a square matrix of size N×N. Can you calculate the absolute difference of the sums across the main diagonal and the secondary diagonal?

Input Format

The first line contains a single integer N. The next N lines contain the rows of N integers describing the matrix.

Output Format

Output a single integer equal to the absolute difference in the sums across the diagonals.

Sample Input

3
11 2 4
4 5 6
10 8 -12

Sample Output

15
*/

using System;
using System.Collections.Generic;
using System.Linq;
class AbsoluteDifferenceBetweenDiagonals_Version2 {
    static void Main(String[] args) {
        int num = Convert.ToInt32(Console.ReadLine());
        int diff = 0;
        for(int index = 0; index < num; index++)
        {
                List<int> list = Console.ReadLine().Split(new char[] { ' ' })
                                                   .Select(str => Convert.ToInt32(str))
                                                   .ToList();
                diff += list[index] - list[list.Count() - index - 1];
        }
        Console.WriteLine(Math.Abs(diff));
    }
}