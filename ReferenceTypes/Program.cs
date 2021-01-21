using System;

namespace ReferenceTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			// value type: int,float,boolean,decimal
			// reference type: arrays,class,interface
			//stack : değer tip , heap: referance tip

			Person person1 = new Person();
			Person person2 = new Person();
			person1.FirstName = "salim";
			person2 = person1;
			person1.FirstName = "ahmet";
			Console.WriteLine(person2.FirstName);
			Customer customer = new Customer();
			customer.FirstName = "Eda";
			customer.CreditCardNumber = 234555;
			Employe employe = new Employe();
			employe.FirstName = "Fatih Eymen";

			Person person3 = customer;
			Console.WriteLine(person3.FirstName);
			Console.WriteLine(((Customer)person3).CreditCardNumber);

			PersonManager personManager = new PersonManager();
			personManager.Add(employe);
		}

	}

}
// classlarda inheritens olur.
class Person
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public int LastName { get; set; }

}
class Customer:Person
{
	public int CreditCardNumber { get; set; }

}
class Employe:Person
{
	public int EmployeNumber { get; set; }

}
class PersonManager
{
	public void Add(Person person)
	{
		Console.WriteLine(person.FirstName);
	}
}