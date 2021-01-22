using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{

	class MyList<T1,T2>
	{
		T1[] ayak;
		T2[] numara;
		T1[] tempkey;
		T2[] tempvalue;

		public MyList()
		{
			ayak = new T1[0];
			numara = new T2[0];
		}
		public void Add(T1 ay,T2 num)
		{
			tempkey = ayak;
			tempvalue = numara;
			ayak = new T1[ayak.Length + 1];
			numara = new T2[numara.Length + 1];
			for (int i = 0; i < tempkey.Length; i++)
			{
				ayak[i] = tempkey[i];
				numara[i] = tempvalue[i];

			}
			ayak[ayak.Length - 1] = ay;
			numara[numara.Length - 1] = num;
			
		}

		
		

		public T1[] ayaks
		{
			get { return ayak; }
			
		}
		public T2[] numa
		{
			get { return numara; }

		}



	}
}
