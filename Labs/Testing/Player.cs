using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
	class Player
	{
		public string name;
		public int count;

		public Player(int i){
			name = $"Player {i.ToString()}";
		}
	}
}
