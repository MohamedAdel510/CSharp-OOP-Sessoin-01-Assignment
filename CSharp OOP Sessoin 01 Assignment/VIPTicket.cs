using CSharp_OOP_Sessoin_01_Assignment.Enums;
using CSharp_OOP_Sessoin_01_Assignment.Sturcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment
{
	internal class VIPTicket:Ticket
	{
		public bool LongAccess { get; set; }
		public decimal ServiceFee {  get; set; }

		public VIPTicket(bool longAccess, decimal serviceFee, string MovieName, Ticket_Type Type, SeatLocation seatLocation, double Price) 
			: base(MovieName, Type, seatLocation, Price)
		{
			LongAccess = longAccess;
			ServiceFee = serviceFee;
		}

		public override string ToString()
		{
			return $"{base.ToString()} | LongAcess: {LongAccess} | Service Fee: {ServiceFee}";
		}
	}
}
