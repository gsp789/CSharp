/* 
Problem Statement
Your teacher has given you the task of drawing a staircase structure. Being an expert programmer, you decided to make a program to draw it for you instead. Given the required height, can you print a staircase as shown in the example?

Input
You are given an integer N depicting the height of the staircase.

Output
Print a staircase of height N that consists of # symbols and spaces. For example for N=6, here's a staircase of that height:

     #
    ##
   ###
  ####
 #####
######

Note: The last line has 0 spaces before it. 
*/

using System;
using System.Collections.Generic;
using System.IO;
class BuildTriangle {
    static void Main(String[] args) {
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= num; i++)
        {
                for(int j = 0; j < num - i; j++)
                    Console.Write(" ");
                for(int k = num - i; k < num; k++)
                    Console.Write("#");
                Console.WriteLine();
        }
    }
}

/*Another way using Linq(Not so effective)

using System;
using System.Collections.Generic;
using System.Linq;
class BuildTriangle {
    static void Main(String[] args) {
        int num = Convert.ToInt32(Console.ReadLine());
        for(int index = 1; index <= num; index++)
        {
            Enumerable.Range(index, num - index).ToList().ForEach(n => Console.Write(" "));
            Enumerable.Range(num, index).ToList().ForEach(n => Console.Write("#"));
            Console.WriteLine();
        }
    }
}

*/