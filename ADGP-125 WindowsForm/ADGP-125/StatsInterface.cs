using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
	public interface IStatsInterface
	{
		int iHealth { get; set; }
		int iMana { get; set; }
		//int iStrength { get; set; }
		int iDefense { get; set; }
		int iIntelligence { get; set; }
		int iExperience { get; set; }
		int iLevel { get; set; }
		bool Alive { get; set; }
	}
}
