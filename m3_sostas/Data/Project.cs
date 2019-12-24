using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace m3_sostas.Data
{
	public class Project : Base
	{
		public string ProjectNumber { get; set; }

		public Guid CategoryID { get; set; }

	}
}
