using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	sealed internal class Domestication : Animal
	{
		public Domestication(string name, uint age, uint size) : base(name, age, size)
		{

		}

		public override void Eat()
		{
			base.size += (base.size * 10) / 100;
			Console.WriteLine($"{base.name} Поела. Итого размер: {base.size}");
		}
	}
}
