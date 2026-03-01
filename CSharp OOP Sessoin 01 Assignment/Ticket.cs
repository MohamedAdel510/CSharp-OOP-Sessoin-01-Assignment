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
		//public string? MovieName { get; set; }
		private string? _movieName;
		public Ticket_Type Type { get; set; }
		public SeatLocation seatLocation { get; set; }
		private double _price;

		public int TicketId { get; private set; }
		protected bool Status { get; set; }
		protected string StatusOutPut => Status ? "Yes" : "No";


		// Assignment 02 Task2 
		#region Assignment 02
		public string? MovieName
		{
			get
			{
				return _movieName;
			}
			set
			{
				if(!string.IsNullOrWhiteSpace(value))
					_movieName = value;
			}
		}

		public double Price
		{
			get { return _price; }
			set
			{
				if(value >  0)
					_price = value;
			}
		}

		public double PriceAfterTax => _price * 0.86;
		
		private static int ticketCounter = 0;


		#endregion

		public Ticket(string MovieName, Ticket_Type Type, SeatLocation seatLocation, double Price, bool status)
		{
			this.MovieName = MovieName;
			this.Type = Type;
			this.seatLocation = seatLocation;
			this.Price = Price;
			ticketCounter++;
			TicketId = ticketCounter;
			Status = status;
		}
		public Ticket(string Name) : this(Name, Ticket_Type.Standard, new SeatLocation('A', 1) , 50, true)
		{
			MovieName = Name;		
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




		//Assignment 02
		public static int GetTotalTicketsSold()
		{
			return ticketCounter;
		}


		#region Assignment 04
		public virtual string PrintTicket()
		{
			return $"Ticket #{TicketId} | {MovieName} | {Type} | {MovieName} | Price: {Price} EGP| After Tax: {CalcTotal(14)} EGP";
		}

		public void SetPrice(double price)
		{
			Price = price;
		}
		public void SetPrice(double basePrice, double multiplier) 
		{
			Price = basePrice * multiplier;
		}
		#endregion

		public override string ToString()
		{
			return $"Ticket #{TicketId} | {MovieName} | {Type} | {MovieName} | Seat: {seatLocation.ToString()} | Price: {Price} EGP| After Tax: {CalcTotal(14)} EGP";
		}

		#region Assignment 05

		public void BookingTicket()
		{
			if(Status != true)
				Status = true;
		} 
		public void CanceleTicket()
		{
			if(Status != false)
				Status = false;
		}

		#endregion
	}
}
