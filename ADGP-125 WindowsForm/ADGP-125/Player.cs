using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
	class Player : Unit //IStatsInterface, IActionsInterface
	{
	//	private int iHP, iMP, iStr, iDef, iInt;
	//	bool Life;

	//	public Player(int iLife, int iMag, int iPower, int iArm, int iKnow, bool State)
	//	{
	//		iHP = iLife;
	//		iMP = iMag;
	//		iPower = iStr;
	//		iDef = iArm;
	//		iInt = iKnow;
	//		Life = State;
	//	}

	//	public int iHealth
	//	{
	//		get
	//		{
	//			return iHP;
	//		}
	//		set
	//		{
	//			iHP = value;
	//		}
	//	}
	//	public int iMana
	//	{
	//		get
	//		{
	//			return iMP;
	//		}
	//		set
	//		{
	//			iMP = value;
	//		}
	//	}
	//	public int iStrength
	//	{
	//		get
	//		{
	//			return iStr;
	//		}
	//		set
	//		{
	//			iStr = value;
	//		}
	//	}
	//	public int iDefense
	//	{
	//		get
	//		{
	//			return iDef;
	//		}
	//		set
	//		{
	//			iDef = value;
	//		}
	//	}
	//	public int iIntelligence
	//	{
	//		get
	//		{
	//			return iInt;
	//		}
	//		set
	//		{
	//			iInt = value;
	//		}
	//	}
	//	public bool Alive
	//	{
	//		get
	//		{
	//			return Alive;
	//		}
	//		set
	//		{
	//			if (iHP > 0)
	//			{
	//				Life = value;
	//			}
	//			else if (iHP <= 0)
	//			{
	//				Life = value;
	//			}
	//		}
	//	}

		//public int iAttack(IStatsInterface Enemy)
		//{
		//	int iDamage = this.iStrength - Enemy.iDefense;
		//	int iRemainingHP = Enemy.iHealth - iDamage;
		//	Enemy.iHealth = iRemainingHP;



		//	return Enemy.iHealth;
		//}
		//public int iDefend(IStatsInterface Temp)
		//{
		//	int iIncrease = this.iDef * 2;
		//	this.iDefense = iIncrease;
		//	return this.iDefense;
		//}
	}
}
