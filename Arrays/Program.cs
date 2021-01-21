using System;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] students = new string[3]; // string[] students={1,3,4,5}; olabillir.
			students[0] = "Salim";
			students[1] = "Ahmet";
			students[2] = "Defne";
			foreach (string student in students)
			{
				Console.WriteLine(student);

			}
		}
	}
}
