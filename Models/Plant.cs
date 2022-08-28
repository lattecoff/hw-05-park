using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models
{
	internal class Plant
	{
		string name = "";
		uint size = 0;

		Plant(string name, uint size)
		{
			this.name = name;
			this.size = size;
		}
	}
}
