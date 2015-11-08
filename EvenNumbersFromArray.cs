using System.Linq;
using System.Collections.Generic;

namespace NumbersCode
{
	class ClassifyNumber
	{
		public int Number;
		public bool IsEven;
	}
	class Numbers
	{
		
		public static IEnumerable<int> DisplayEvenNumbers_Lambda(int[] Numbers)
		{
			return Numbers.Where(Number => Number % 2 == 0);
		}
		
		public static IEnumerable<int> DisplayOddNumbers_Linq(int[] Numbers)
		{
			return from number in Numbers where number % 2 != 0 select number;
		}
		
		public static IEnumerable<ClassifyNumber> ClassifyNumbers_Lambda(int[] Numbers)
		{
			return Numbers.Select(Number => new ClassifyNumber{ Number = Number, IsEven = (Number % 2 == 0)});
		}
		
		public static IEnumerable<ClassifyNumber> CLassifyNumbers_Linq(int[] Numbers)
		{
			return from Number in Numbers select new ClassifyNumber { Number = Number, IsEven = (Number % 2 == 0)});
		}
		
		public static void Main()
		{
			int[] Numbers = { 3, 5, 2, 7, 9, 10, 24, 1, 23, 12, 50, 71, 26, 13, 76, 34};
			var EvenNumbers = DisplayEvenNumbers_Lambda(Numbers);
			System.Console.WriteLine("Display Even Numbers using Lambda:");
			foreach(var EvenNumber in EvenNumbers)
				System.Console.Write(" " + EvenNumber);
			
			var OddNumbers = DisplayOddNumbers_Linq(Numbers);
			System.Console.WriteLine("\nDisplay Odd Numbers using Linq:");
			foreach(var OddNumber in OddNumbers)
				System.Console.Write(" " + OddNumber);
			
			System.Console.WriteLine("\nClassify the given numbers:");
			var ClassifyNumbers = ClassifyNumbers_Linq(Numbers);
			foreach(var CurrentNumber in ClassifyNumbers)
				System.Console.WriteLine(CurrentNumber.Number + " is " + (CurrentNumber.IsEven?"Even":"Odd"));
		}
	}
}