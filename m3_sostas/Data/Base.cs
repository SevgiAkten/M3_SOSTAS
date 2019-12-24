using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace m3_sostas.Data
{
	public class Base
	{
		public Guid ID { get; set; }
		public string Description { get; set; } 
		public DateTime CreatedDate { get; set; }
		public DateTime ModfiedDate { get; set; }

	}
}
