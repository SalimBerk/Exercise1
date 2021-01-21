using System;

namespace Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			//Add();
			//Add();
			//Add();
			//Add();
			//var result=Add2(10);
			//ref içerde değişikliğe uğratıyor.
			//değerin methotda değişebilecegini düşünüyorsan ref kullanırsın.
			//refde bir değeri set etmek gerekiyor.otda gerek yok
			//outda methodun içinde bir kere set edilmiş olması gerek.
			//params int[] numbers
			int number1 = 35;
			int number2 = 100;
			var result2 = Add3(ref number1, number2);
			Console.WriteLine(result2);
			Console.WriteLine(number1);
			Console.ReadLine();
		}
		
		static void Add()
		{
			Console.WriteLine("Added!");

		}
		//void islem yap kayıt yap demek.
		static int Add2(int number1,int number2=30)
		{
			var result = number1 + number2;
			return result;
		}
		static int Add3(ref int number1,int number2)
		{
			number1 = 90;
			return number1+number2;
		}
	}
}
