using CSharp_OOP_Sessoin_01_Assignment.Enums;
using CSharp_OOP_Sessoin_01_Assignment.Sturcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment
{
	internal class IMAXTicket : Ticket
	{
		public bool  Is3D { get; set; }
		private string Is_3D_Output => Is3D ? "Yes" : "NO";

		public IMAXTicket(bool is3D, string MovieName, Ticket_Type Type, SeatLocation seatLocation, double Price) :
			base(MovieName, Type, seatLocation, Price)
		{
			Is3D = is3D;
		}

		public override string ToString()
		{
			return $"{base.ToString()}| IMax 3D: {Is_3D_Output}";
		}
	}
}
