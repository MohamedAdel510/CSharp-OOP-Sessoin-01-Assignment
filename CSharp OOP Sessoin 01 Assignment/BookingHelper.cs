using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment
{
	internal class BookingHelper
	{
		private static int counter = 0;
		public static double CalcGroupDiscount(int numberOfTicket, double pricePerTicket)
		{
			if (numberOfTicket >= 5)
				return numberOfTicket * pricePerTicket * 0.9;
			return numberOfTicket * pricePerTicket;
		}

		public static string GenerateBookingReference()
		{
			counter++;
			return $"BK-{counter}";
		}

		public static void PrintAllPrintabelTicket(IPrintable[] tickets)
		{
			Console.WriteLine("========== All Tickets ==========");
			for (int i = 0; i < tickets.Length; i++)
			{
				Console.WriteLine(tickets[i].Print());
			}
		}
	}
}
