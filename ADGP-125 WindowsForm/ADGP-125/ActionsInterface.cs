using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
	public interface IActionsInterface<T>
	{
		bool Attack(T tTarget);
		bool Defend();
		bool Magic(T Target);
		//bool Flee(T Running, T Additional);
		bool GameOver();
		//bool Victory(IStatsInterface UnitCount);
	}
}
