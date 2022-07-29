// Dictionary for equipment type

using System;
using System.Linq;
using System.Collections.Generic;
 
public class Equipment
{
	public static void Main()
	{
		List<string> list = new List<string>() { ""Flatbed", "Trailer", "Refridgerated", "Sprinter Van", "Hot Shot", "Tanker", "Power Only" };

		Dictionary<string, int> dict = list.ToDictionary(x => x, x => 0);

		Console.WriteLine(String.Join(", ", dict));
	}
}
