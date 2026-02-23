using CSharp_OOP_Sessoin_01_Assignment.Enums;
using CSharp_OOP_Sessoin_01_Assignment.Sturcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment
{
	internal class Standardticket : Ticket
	{
		public string SeatNumber { get; set; }

		public Standardticket(string seatNubmer):base() 
		{
			SeatNumber = seatNubmer;
		}
		public override string ToString()
		{
			return $"{base.ToString()}| Seat Number: {SeatNumber}";
		}
	}
}
