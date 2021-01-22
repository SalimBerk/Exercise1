using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
	class MyDictionary<T1,T2>
	{
		T1[] keys;
		T2[] values;
		public MyDictionary()
		{
			keys = new T1[0];
			values = new T2[0];

		}
		public void Add(T1 key,T2 value)
		{
			T1[] TempKey = keys;
			T2[] TempValue = values;
			keys = new T1[keys.Length + 1];
			values = new T2[values.Length + 1];
			for (int i = 0; i < TempKey.Length; i++)
			{
				keys[i] = TempKey[i];
				values[i] = TempValue[i];

			}
			keys[keys.Length - 1] = key;
			values[keys.Length - 1] = value;

		}
		

		public int key
		{
			get { return key; }
			
		}
		public int value
		{
			get { return value; }

		}

	}

}
