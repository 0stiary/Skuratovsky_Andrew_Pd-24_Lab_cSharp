using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_1
{

	class Park
	{
		
		public void RoolCoaster(Visitor visitor){
			visitor.american = true;
		}

		public void ShootTir(Visitor visitor)
		{
			visitor.fired = true;
		}

		public void Fear(Visitor visitor)
		{
			visitor.fear_room = true;
		}

		public void Mirror(Visitor visitor)
		{
			visitor.mirror_room = true;
		}

		public void Ckushatcb(Visitor visitor)
		{
			visitor.popcorn = true;
		}

		public void Devil(Visitor visitor)
		{
			visitor.ferris_wheel = true;
		}
	}
}
