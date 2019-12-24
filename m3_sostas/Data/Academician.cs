using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace m3_sostas.Data
{
	public class Academician : Base
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string University { get; set; }
		public string Faculty { get; set; }
		public string Department { get; set; } 
	}
}
