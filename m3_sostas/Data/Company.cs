using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace m3_sostas.Data
{
	public class Company : Base
	{
		public string CompanyName { get; set; }
		public string PhoneNumber { get; set; }
		public string Mail { get; set; }
		public string Adress { get; set; } 
		public Guid SectorID { get; set; }

	}
}
