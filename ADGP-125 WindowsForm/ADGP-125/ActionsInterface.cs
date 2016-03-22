using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
	public interface IActionsInterface<T>
	{
		bool Attack();
		bool Defend();
		//bool Magic(T Target, T Player);
		//bool Flee(IStatsInterface Running);
		//bool GameOver(IStatsInterface Dead);
		//bool Victory(IStatsInterface UnitCount);
	}
}
