using System;
using System.Collections.Generic;

namespace Generics
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> sehirler = new List<string>();
			sehirler.Add("İzmir");
			sehirler.Add("Antalya");
			sehirler.Add("Antalya");
			sehirler.Add("Antalya");
			sehirler.Add("Antalya");
			Console.WriteLine(sehirler.Count);
			
			MyList<string> sehirler2 = new MyList<string>();
			sehirler2.Add("Bursa");
			sehirler2.Add("Antalya");
			sehirler2.Add("Antalya");
			sehirler2.Add("Antalya");
			sehirler2.Add("Antalya");
			sehirler2.Add("Antalya");
			Console.WriteLine(sehirler2.Count);




		}
	}
	class MyList<T> //Generics class
	{
		T[] _array;
		T[] _tempArray;
		public MyList()
		{
			_array = new T[0];

		}

		public int Count
		{
			get { return _array.Length; }
			
		}

		public void Add(T item)
		{
			_tempArray = _array;
			_array = new T[_array.Length + 1];
			for (int i = 0; i < _tempArray.Length; i++)
			{
				_tempArray[i] = _array[i];

			}
			_array[_array.Length - 1] = item;

		}

	}
}
