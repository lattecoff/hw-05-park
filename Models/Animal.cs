using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models
{
	abstract public class Animal
	{
		internal string name = "";
		internal uint age = 0;
		internal uint size = 0;

		/*public Animal(string name, uint age)
		{
			this.name = name;
			this.age = age;

			this.size = default;
		}*/

		public Animal(string name, uint age, uint size)
		{
			this.name = name;
			this.age = age;
			this.size = size;
		}

		public virtual void Eat()
		{
			this.size += (this.size *10) / 100;	
		}
	}
}
