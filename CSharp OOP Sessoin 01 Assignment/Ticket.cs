using CSharp_OOP_Sessoin_01_Assignment.Enums;
using CSharp_OOP_Sessoin_01_Assignment.Sturcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment
{
	internal class Ticket
	{
		public string? MovieName { get; set; }
		public Ticket_Type Type { get; set; }
		public SeatLocation seatLocation { get; set; }
		public double Price { get; set; }
		
		// Constructor
		public Ticket(string MovieName, Ticket_Type Type, SeatLocation seatLocation, double Price)
		{
			this.MovieName = MovieName;
			this.Type = Type;
			this.seatLocation = seatLocation;
			this.Price = Price;
		}
		public Ticket(string Name) : this(Name, Ticket_Type.Standard, new SeatLocation('A', 1) , 50)
		{
			this.MovieName = Name;
		}

		public Ticket(): this("Inception")
		{

		}

		// Method
		public double CalcTotal(double taxPercent)
		{
			double total = Price + (Price * taxPercent / 100);
			return total;
		}

		public void ApplyDiscount(ref double discount)
		{
			if(discount > 0 && discount <= Price)
			{
				Price -= discount;
				discount = 0;
			}
		}

		public void PrintTicket()
		{
			Console.WriteLine("\n===== Ticket Info =====");
			Console.WriteLine($"Movie\t: {MovieName}");
			Console.WriteLine($"Type \t: {Type}");
			Console.WriteLine($"Seat \t: {seatLocation.ToString()}");
			Console.WriteLine($"Price\t: {Price}");
			Console.WriteLine($"Total (14% tax) : {CalcTotal(14)}");
		}
	}
}
