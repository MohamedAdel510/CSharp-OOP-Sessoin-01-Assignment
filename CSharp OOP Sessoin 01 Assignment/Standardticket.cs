using CSharp_OOP_Sessoin_01_Assignment.Enums;
using CSharp_OOP_Sessoin_01_Assignment.Sturcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment
{
	internal class Standardticket : Ticket, IPrintable, ICloneable
	{
		public string SeatNumber { get; set; }

		public Standardticket(string seatNubmer, string MovieName, Ticket_Type Type, SeatLocation seatLocation, double Price, bool status)
			:base(MovieName, Type, seatLocation, Price, status) 
		{
			SeatNumber = seatNubmer;
		}

		public override string ToString()
		{
			return $"{base.ToString()}| Seat Number: {SeatNumber}";
		}

		#region Assignment 04
		public override string PrintTicket()
		{
			return $"{base.PrintTicket()}| Seat Number: {SeatNumber}";
		}

		#region Assignment 05
		public  string Print()
		{
			return $"{base.PrintTicket()}| Seat Number: {SeatNumber} | Booked: {StatusOutPut}";
		}

		public object Clone()
		{
			return new Standardticket(SeatNumber, MovieName, Type, seatLocation, Price, Status);
		}
		#endregion
		#endregion
	}
}
