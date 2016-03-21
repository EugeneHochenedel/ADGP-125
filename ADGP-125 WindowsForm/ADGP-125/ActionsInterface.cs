using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
	public interface IActionsInterface<T>
	{
		int iAttack(T Unit);
		int iDefend(T Self);
		//int iMagic(IStatsInterface Current, IStatsInterface Unit);
		//bool Flee(IStatsInterface Running);
		//bool GameOver(IStatsInterface Dead);
		//bool Victory(IStatsInterface UnitCount);
	}
}
