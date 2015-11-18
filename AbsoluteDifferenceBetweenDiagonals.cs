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

using System.Collections.Generic;
using System.Linq;
using System;

class AbsoluteDifferenceBetweenDiagonals {
    static void Main(String[] args) {
        int num = Convert.ToInt32(Console.ReadLine());
        List<List<int>> lists = new List<List<int>>();
        Array.ForEach(Enumerable.Range(0,num).ToArray(), i => lists.Add(new List<int>(Console.ReadLine()
                                                                   .Split(new char[] {' '})
                                                                   .ToList()
                                                                   .Select(str => Convert.ToInt32(str)))));
        int length = lists[0].Count - 1;
        int result = Enumerable.Range(0, lists.Count)
                                .ToArray()
                                .Aggregate(0, (sum, index) => sum + lists[index][index] - lists[index][length-index]);
        Console.WriteLine(Math.Abs(result));
                    
    }
}