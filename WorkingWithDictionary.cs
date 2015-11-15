using System;
using System.Collections.Generic;

public class WorkingWithDictionary
{
    public static void AddOrUpdateToDictionary(Dictionary<int, string> Obj, int key, string value)
    {
		if(Obj.ContainsKey(2))
			Obj[key] = value;
		else
			Obj.Add(key, value);
    }

	public static void PrintDictionary(Dictionary<int, string> Obj)
    {
		foreach(var pair in Obj)
			Console.WriteLine(pair.Key + " : " + pair.Value);
    }

	public static void Main()
	{
		Dictionary<int, string> TestObj = new Dictionary<int, string>();
		try {
			//Add a key with value
			TestObj.Add( 3, "Praveen");
			//The below line throws an exception saying "An item with same key has already been added"
			//TestObj.Add(3, "Prakash");
			//Update the value in the key 3
            TestObj[3] = "Prakash";

            AddOrUpdateToDictionary(TestObj, 2, "Pratap");
			AddOrUpdateToDictionary(TestObj, 2, "Pramod");
			AddOrUpdateToDictionary(TestObj, 1, "Preetham");

			PrintDictionary(TestObj);
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		
	}
}
