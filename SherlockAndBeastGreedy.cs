using System;

class SherlockAndBeastGreedy
{
	static string findMaxDigit( string num, int threesDigit, int fivesDigit)
	{
		int 
	}
	
	public static void Main()
	{
		int testCases = Convert.ToInt32(Console.ReadLine());
		
		while(testCases-- > 0)
		{
			string output = "-1";
			numOfDigits = Convert.ToInt32(Console.ReadLine());
			int num = numOfDigits;
			
			while(num > 0)
			{
				if(num%3 == 0  && ((numOfDigits - num) % 5 == 0)
				{
					output = "".Pad(num, '5');
					output.PadRight(numOfDigits - num, '3');
					break;
				}
				if(num % 3 == 0)
					num -= 3;
				else
					num -= (num % 3);
			}
			if(output.Equals("-1"))
			{
				num = 5;
				while(num < numOfDigits)
				{
					if((numOfDigits - num) % 3 == 0)
					{
						output = "".Pad(num, '5');
						output.PadRight(numOfDigits - num, '3');
						break;
					}
					num += 5;
				}
			}
			Console.WriteLine(output);
		}
	}
}
