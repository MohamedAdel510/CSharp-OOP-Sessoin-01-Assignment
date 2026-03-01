using CSharp_OOP_Sessoin_01_Assignment.Enums;
using CSharp_OOP_Sessoin_01_Assignment.Sturcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment
{
	internal class VIPTicket:Ticket, IPrintable, ICloneable
	{
		public bool LongAccess { get; set; }
		public decimal ServiceFee {  get; set; }

		public VIPTicket(bool longAccess, decimal serviceFee, string MovieName, Ticket_Type Type, SeatLocation seatLocation, double Price, bool status) 
			: base(MovieName, Type, seatLocation, Price, status)
		{
			LongAccess = longAccess;
			ServiceFee = serviceFee;
		}

		public override string ToString()
		{
			return $"{base.ToString()} | LongAcess: {LongAccess} | Service Fee: {ServiceFee}";
		}

		#region Assignment 04
		public override string PrintTicket()
		{
			return $"{base.PrintTicket()} | LongAcess: {LongAccess} | Service Fee: {ServiceFee}";
		}

		#region Assignment 05
		public  string Print()
		{
			return $"{base.PrintTicket()} | LongAcess: {LongAccess} | Service Fee: {ServiceFee} | Booked: {StatusOutPut}";
		}

		public object Clone()
		{
			return new VIPTicket(LongAccess, ServiceFee, MovieName, Type, seatLocation, Price, Status);
		}
		#endregion
		#endregion
	}
}
