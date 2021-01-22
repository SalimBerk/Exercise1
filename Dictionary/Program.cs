using System;
using System.Collections.Generic;

namespace Dictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<string, int> ayakkabi = new MyList<string, int>();
			ayakkabi.Add("Puma", 34);
			ayakkabi.Add("Adidas", 45);
			ayakkabi.Add("Nike", 46);
			Console.WriteLine("*****************************AYAKKABI MARKASI**************************");
			foreach (var yaz in ayakkabi.ayaks)
			{
				Console.WriteLine(yaz);

			}
			Console.WriteLine("*****************************AYAKKABI NUMARASI**************************");
			foreach (var yaz1 in ayakkabi.numa)
			{
				Console.WriteLine(yaz1);

			}

			Console.ReadKey();
		}
	}
}
