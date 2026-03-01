using CSharp_OOP_Sessoin_01_Assignment.Enums;
using CSharp_OOP_Sessoin_01_Assignment.Sturcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment
{
	internal class IMAXTicket : Ticket, IPrintable, ICloneable
	{
		public bool  Is3D { get; set; }
		private string Is_3D_Output => Is3D ? "Yes" : "NO";

		public IMAXTicket(bool is3D, string MovieName, Ticket_Type Type, SeatLocation seatLocation, double Price,bool status) :
			base(MovieName, Type, seatLocation, Price, status)
		{
			Is3D = is3D;
		}

		public override string ToString()
		{
			return $"{base.ToString()}| IMax 3D: {Is_3D_Output}";
		}

		#region Assignment 04
		public override string PrintTicket()
		{
			return $"{base.PrintTicket()} | IMax 3D: {Is_3D_Output}";
		}

		#region Assignment 05
		public  string Print()
		{
			return $"{base.PrintTicket()} | IMax 3D: {Is_3D_Output} | Booked: {StatusOutPut}";
		}

		public object Clone()
		{
			return new IMAXTicket(Is3D, MovieName, Type, seatLocation, Price, Status);
		}
		#endregion
		#endregion
	}
}
