using System;

namespace Constructor
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer customer1 = new Customer { Id = 1, FirstName = "Salim", LastName = "Uzun", City = "İstanbul" };
			Console.WriteLine(customer1.Id);
			
			Customer customer2 = new Customer(2,"Berk","Uzun","Antalya");
			Console.WriteLine(customer2.FirstName+":"+customer2.LastName+ ":" + customer2.City+ ":" + customer2.Id);
			
			
		}
	}
	class Customer
	{
		public Customer()
		{
		
				
		}
		//default constructor
		public Customer(int id,string firstName,string lastName,string city)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			City = city;
		}
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string City { get; set; }
	}
}
