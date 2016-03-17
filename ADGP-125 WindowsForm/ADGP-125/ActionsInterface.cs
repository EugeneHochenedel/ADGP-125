using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
	public interface ActionsInterface
	{
		int Attack(IStatsInterface Unit);
		int Defend(IStatsInterface Self);
		int Magic(IStatsInterface Current, IStatsInterface Unit);
		bool Flee(IStatsInterface Running);
		bool GameOver(IStatsInterface Dead);
		bool Victory(IStatsInterface UnitCount);
	}
}
