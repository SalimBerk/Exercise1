using System;
using System.Collections.Generic;

namespace MyDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> Ayak = new Dictionary<string, int>();
			Ayak.Add("Nike", 30);
			Ayak.Add("Adidas", 45);
			Ayak.Add("Puma", 46);
			foreach(var An in Ayak)
			{
				Console.WriteLine(An);
			}
		}
	}
	class Dictionary<T1,T2>
	{
		T1[]=ayak;
		T2[]=numara;
		public Dictionary()
		{

		}

	}
}
