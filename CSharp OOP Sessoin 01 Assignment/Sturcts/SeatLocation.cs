using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment.Sturcts
{
	internal struct SeatLocation
	{
		public char Seat { get; set; }
		public int Number { get; set; }

		public SeatLocation(char seat, int number)
		{
			Seat = seat;
			Number = number;
		}

		public override string ToString()
		{
			return $"{Seat}{Number}";
		}

		
	}
}
