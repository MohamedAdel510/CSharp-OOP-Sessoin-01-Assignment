using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Sessoin_01_Assignment
{
	internal class StudentClass
	{
		public int id { get; set; }

		public string? Name{ get; set; }

		public override string ToString()
		{
			return $"Name: {Name}, Id: {id}";
		}
	}
}
