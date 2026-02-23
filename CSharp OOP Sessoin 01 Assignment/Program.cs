using CSharp_OOP_Sessoin_01_Assignment.Enums;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace CSharp_OOP_Sessoin_01_Assignment
{

	class testAccessModifier
	{
		public int testPublic { get; set; }
		private int testPrivate { get; set; }
	}


	internal class Program
	{
		static void Main(string[] args)
		{

			#region Assignment 01
			#region Part 01 : 

			#region Q1 Explain with code example how class and struct behave differently 

			//// 1-  class behave as reference type data type 
			//StudentClass std01 = new StudentClass();
			//// Create refernce refers to null
			//// allocate required byte at heap
			//// intialize allocated byte with defualt values
			//// assign  address of allocated object to the ref "std01"

			//std01.id = 1;
			//std01.Name = "Ahmed";

			//StudentClass std02 = std01;

			//Console.WriteLine(std01.ToString());
			//Console.WriteLine(std02.ToString());

			//// if any changing happen for std01 will affect std02

			//std01.Name = "Mohamed";

			//Console.WriteLine(std01.ToString());
			//Console.WriteLine(std02.ToString());

			//// Struct behaves as value type used to represents small lightweight data


			//StudnetStruct std03 = new StudnetStruct();
			//// Note new here behave difference. 
			//std03.Name = "Ahmed";
			//std03.id = 1;

			//StudnetStruct std04 = new StudnetStruct();

			//std03 = std04;

			//Console.WriteLine(std03.Name);
			//Console.WriteLine(std03.id);

			//Console.WriteLine(std04.Name);
			//Console.WriteLine(std04.id);


			#endregion

			#region Q2 : Explain the difference between public and private access modifiers with an example. 

			//testAccessModifier t = new testAccessModifier();
			//// Public Access modifier:  Members are accessibale everywhere
			//t.testPublic = 1;

			//// Private Access modifier:  Members are accessibale with in the class only
			//// t.testPrivate = 1; not allowed for its protection level

			#endregion

			#region Q3 : Describe the steps to create and use a class library in Visual    Studio.

			// first we have to create new project of type class library as toolbox wiht utility class 
			// second we have to add the class library refrence to the console app 
			// make sure you are using the name spaces and handling it's protection level

			#endregion

			#region Q4 : What is a class library? Why do we use class libraries?
			// class library is a separate project that contains reusable classes, has no main method
			// and con not run 
			// benifets
			// Reusability - Organization - Maintenance
			#endregion

			#endregion


			#region Part 02: Movie Ticket Booking System

			//Ticket ticket = new Ticket();

			//do
			//{
			//	Console.Write("Enter Movie Name: ");
			//	ticket.MovieName = Console.ReadLine();
			//} while (string.IsNullOrWhiteSpace(ticket.MovieName));

			//bool isParsed;
			//Ticket_Type type;

			//do
			//{
			//	Console.Write("Enter Ticket Type (Standard, VIP, IMAX): ");
			//	isParsed = Enum.TryParse<Ticket_Type>(Console.ReadLine(), true, out type);
			//} while (!isParsed || !Enum.IsDefined(typeof(Ticket_Type), type));
			//ticket.Type = type;

			//string seat;
			//int number;

			//do
			//{
			//	Console.Write("Enter Seat Row (A, B, C, ..., Z): ");
			//	seat = Console.ReadLine()!.ToUpper();
			//} while (seat.Length != 1 || string.IsNullOrWhiteSpace(seat));

			//do
			//{
			//	Console.Write("Enter Seat Number: ");
			//	isParsed = int.TryParse(Console.ReadLine(), out number);
			//} while (!isParsed);

			//ticket.seatLocation = new(seat[0], number);

			//double price;
			//do
			//{
			//	Console.Write("Enter Price: ");
			//	isParsed = double.TryParse(Console.ReadLine(), out price);
			//} while (!isParsed);

			//ticket.Price = price;

			//double discount;
			//do
			//{
			//	Console.Write("Enter Discount Amount: ");
			//	isParsed = double.TryParse(Console.ReadLine(), out discount);
			//} while (!isParsed);

			//ticket.PrintTicket();

			//Console.WriteLine("===== After Discount =====");
			//Console.WriteLine($"Discount Before: {discount}");
			//ticket.ApplyDiscount(ref discount);
			//Console.WriteLine($"Discount After: {discount}");
			//Console.WriteLine($"Movie\t: {ticket.MovieName}");
			//Console.WriteLine($"Type\t: {ticket.Type}");

			#endregion
			#endregion

			#region Assignment02

			#region Part 01 : Theoretical Questions

			#region Q01: Consider the following class BankAcount: 
			// public class BankAcount{
			//		public string owner;
			//      public double Balance;
			//    
			//      public void Withdraw(double amount){
			//			Balance-= amount;
			//      }
			// }

			// a)Identify at least two problems with this design from
			//   an encapsulation perspective.

			// answer: 
			// first problem: that class fields are exposed for whole Project for direct access
			// second problem: no validation before editing the balance field

			//b) Describe how you would fix this class to follow proper encapsulation
			//principles.You do not need to write the full code.

			//answer:
			// first we have to make Owner and Balance fields private member then controlling 
			// accessing them by setters and getters or property
			// second we have to check validation on amount before editing Balance field

			//c) Explain why exposing fields directly(as public) is considered a bad practice
			//in OOP.

			//answer: 
			// there is no control ovet who access the fields and who can't
			// there is no validation on data
			#endregion

			#region Q02
			//What is the difference between a field and a property in C#? Can a 
			//property contain logic? Give an example of a read-only property that
			//returns a calculated value.

			//Asnwer: 
			//field : is a direct data storage has no validation (just variable).
			//property : is a class member not field or method it is look like a field but acts as method or behvior 
			//          has no prameter ,can contains logic apply validation, achive encapsulation.

			//Quesion02 q02 = new Quesion02(60);
			//Console.WriteLine(q02.Grade);
			//Console.WriteLine(q02.isPassed);
			#endregion

			#region Q03
			//Look at the following code and answer the questions below:
			//public class StudentRegister
			//{
			//	private string[] names = new string[5];

			//	public string this[int index]
			//	{
			//		get { return names[index]; }
			//		set { names[index] = value; }
			//	}
			//}

			//a) What is `this[int index]` called? Explain its purpose.

			//answer: it is an indexer lets an object accessed using array syntax[]

			//b) What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer
			//   safer ?

			// answer: this will give outOfRangeException to make it safer we should validate on index in
			//         both set and get

			//c) Can a class have more than one indexer? If yes, give an example of when that would be
			//// useful

			// answer: Yes, by indexer overloading 
			// if you want to access member with index
			// public string this[int idex], public string this[string ISBN]


			#endregion

			#region Q4
			//Q4: Consider the following code and answer the questions below:
			//public class Order
			//{
			//	public static int TotalOrders = 0;
			//	public string Item;

			//	public Order(string item)
			//	{
			//		Item = item;
			//		TotalOrders++;
			//	}
			//}

			// a) What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?

			// answer:
			// TotalOrder is a static field can access it without creating new object
			// and all objects that will initiated from the Order class will share last value of it
			// it different from the 'the' item field that item belongs to every instance and every
			// instance has it's owen item 


			//b) Can a static method inside `Order` access the `Item` field directly? Why or why not?

			//answer: 

			// No, becouse it belong to an instance object and static method used without creatin object.
			#endregion

			#endregion

			#region Part 02 : Practical (Extending the Movie Ticket Booking System)

			//Cinema cinema = new Cinema(3, "Normadi");

			//Console.WriteLine("========== Ticket Booking ==========\n");

			//for (int i = 0; i < 3; i++)
			//{
			//	Console.WriteLine($"\nEnter Data For Ticket {i + 1}");
			//	//ticket = new Ticket();
			//	string name;
			//	do
			//	{
			//		Console.Write("Enter Movie Name: ");
			//		name = Console.ReadLine()!;
			//	} while (string.IsNullOrWhiteSpace(name));

			//	bool isParsed;
			//	Ticket_Type type;

			//	do
			//	{
			//		Console.Write("Enter Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
			//		isParsed = Enum.TryParse<Ticket_Type>(Console.ReadLine(), true, out type);
			//	} while (!isParsed || !Enum.IsDefined(typeof(Ticket_Type), type));
			//	//ticket.Type = type;

			//	string seat;
			//	int number;

			//	do
			//	{
			//		Console.Write("Enter Seat Row (A, B, C, ..., Z): ");
			//		seat = Console.ReadLine()!.ToUpper();
			//	} while (seat.Length != 1 || string.IsNullOrWhiteSpace(seat));

			//	do
			//	{
			//		Console.Write("Enter Seat Number: ");
			//		isParsed = int.TryParse(Console.ReadLine(), out number);
			//	} while (!isParsed);




			//	double price;
			//	do
			//	{
			//		Console.Write("Enter Price: ");
			//		isParsed = double.TryParse(Console.ReadLine(), out price);
			//	} while (!isParsed);

			//	//ticket.Price = price;


			//	cinema[i] = new Ticket(name, type, new(seat[0], number), price);

			//}

			//Console.WriteLine("\n=============== All Tickets ===============\n");

			//for (int i = 0; i < cinema.Count; i++)
			//{

			//	Console.WriteLine(cinema[i]?.ToString());
			//}

			//Console.WriteLine("\n============= Search by Movie =============\n");

			//string movieName;
			//do
			//{
			//	Console.Write("Enter movie name to search: ");
			//	movieName = Console.ReadLine()!;
			//} while (string.IsNullOrWhiteSpace(movieName));

			//for (int i = 0; i < cinema.Count; i++)
			//{
			//	if (cinema[i]?.MovieName?.ToLower() == movieName.ToLower())
			//	{
			//		Console.WriteLine($"Found: {cinema[i]?.ToString()}");
			//	}
			//}

			//Console.WriteLine("\n=======================\n");
			//Console.WriteLine($"Total Ticket Sold: {Ticket.GetTotalTicketsSold()}");
			//Console.WriteLine("\n=======================\n");
			//Console.WriteLine($"Book 1 Refrence: {BookingHelper.GenerateBookingReference()}");
			//Console.WriteLine($"Book 2 Refrence: {BookingHelper.GenerateBookingReference()}");
			//Console.WriteLine("\n=======================\n");
			//Console.WriteLine($"group discount for a group of 5 tickets at 80 EGP: {BookingHelper.CalcGroupDiscount(5, 80)}");

			#endregion


			#endregion


			#region Assignment 03

			#region Part01 Theoretical Questions

			#region Q1

			//a) A University has Departments. If the university is closed, the departments no longer exist
			// answer: Association - Composition.

			//b) A Driver uses a Car.The driver does not own the car.
			// answer: Dependancy

			//c) A Dog is an Animal.
			// answer: Inheritance


			//d) A Team has Players. If the team is deleted, the players still exist.
			// answer: Association - Aggregation

			//e) A method receives a Logger as a parameter and calls it inside the method only.
			// answer: Dependancy.
			#endregion

			#region Q2: Answer the following questions about access modifiers and sealed:

			//a) A parent class has a protected field.Can a child class in a different assembly access it? What about through an object instance from outside?

			// answer: child class canc access it in different assemby

			//b) What is the difference between protected internal and private protected?

			//answer:
			// Protected internal: members are accessible in same assembly and child class in different assembly
			// Private Protected: members are accessible in same class and child classes within the same assembly not outside it

			//c) What does the sealed keyword do when applied to a class? What about when applied to a method?
			// answer: 
			// seald for a class this class can not be inherited 
			// sealed for method this method cannot be overridden

			//d) Can you create an object from a sealed class using new? Why or why not?
			// yes, it allowed but can not inherit from it

			#endregion

			#endregion

			#region Part 02 : Practical (Extending the Movie Ticket Booking System)

			const int Size = 20;
			Cinema cinema = new Cinema(Size, "Sun City");
			cinema.OpenCinema();
			cinema.StatrProjector();

			Ticket standard = new Standardticket("Ay7aga");
			Ticket vip = new VIPTicket(true, 20, "Avengers", Ticket_Type.VIP, new('B', 2), 180);
			Ticket iMax = new IMAXTicket(true, "Dune", Ticket_Type.IMAX, new('C', 3), 200);

			cinema.AddTicket(standard);
			cinema.AddTicket(vip);
			cinema.AddTicket(iMax);

			cinema.PrintAllTickets();

			Console.WriteLine("========== Statistics ==========");
			Console.WriteLine($"Totoal Ticket Created: {Ticket.GetTotalTicketsSold()}");
			Console.WriteLine();
			Console.WriteLine($"Booking Ref 1: {BookingHelper.GenerateBookingReference()}");
			Console.WriteLine($"Booking Ref 2: {BookingHelper.GenerateBookingReference()}");
			#endregion

			#endregion

		}



	}
}
