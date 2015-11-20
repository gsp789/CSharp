/*
Problem Statement

You're given an array of integers. Can you find what fraction of the elements are positive numbers, negative numbers and zeroes? Print the value of the fractions in decimal form with 3 decimal places.

Input Format

The first line contains N: the size of the array.
The next line contains N space-separated integers A1,A2,A3,?,AN.

Output Format

Output the three values each on a different line. The first value shows the fraction of the count of positive numbers to the total numbers, the second shows the fraction of negative numbers, and the third represents the fraction of zeroes. Correct the fraction to 3 decimal places.

Sample Input

6
-4 3 -9 0 4 1         

Sample Output

0.500
0.333
0.167
*/

using System;
class Solution {
    static void Main(String[] args) {
        int num = Convert.ToInt32(Console.ReadLine());
        double positive = 0, negative = 0, zero = 0;
        Array.ForEach(Console.ReadLine().Split(new char[] { ' ' }), 
                      n => { double y = Convert.ToInt32(n) > 0 ? positive++ : 
                            (Convert.ToInt32(n) < 0? negative++: zero++); } );
        Console.WriteLine((positive/num).ToString("#.000"));
        Console.WriteLine((negative/num).ToString("#.000"));
        Console.WriteLine((zero/num).ToString("#.000"));
    }
}