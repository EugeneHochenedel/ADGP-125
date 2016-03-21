﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
	public class Unit : IStatsInterface, IActionsInterface<Unit>
	{
		public string Identifier;
		private int iHP, iMP, iStr, iDef, iInt, iExp, iLvl;
		bool Life;

		public Unit()
		{

		}

		public Unit(int iLife, int iMag, int iPower, int iArm, int iKnow, int iPoints, int iTier, bool State)
		{
			iHP = iLife;
			iMP = iMag;
			iPower = iStr;
			iDef = iArm;
			iInt = iKnow;
			iExp = iPoints;
			iLvl = iTier;
			Life = State;
		}

		public int iHealth
		{
			get
			{
				return iHP;
			}
			set
			{
				iHP = value;
			}
		}
		public int iMana
		{
			get
			{
				return iMP;
			}
			set
			{
				iMP = value;
			}
		}
		public int iStrength
		{
			get
			{
				return iStr;
			}
			set
			{
				iStr = value;
			}
		}
		public int iDefense
		{
			get
			{
				return iDef;
			}
			set
			{
				iDef = value;
			}
		}
		public int iIntelligence
		{
			get
			{
				return iInt;
			}
			set
			{
				iInt = value;
			}
		}
		public int iExperience
		{
			get
			{
				return iExp;
			}
			set
			{
				iExp = value;
			}
		}
		public int iLevel
		{
			get
			{
				return iLvl;
			}
			set
			{
				iLvl = value;
			}
		}
		public bool Alive
		{
			get
			{
				return Alive;
			}
			set
			{
				if (iHP > 0)
				{
					Life = value;
				}
				else if (iHP <= 0)
				{
					Life = value;
				}
			}
		}

		public bool Attack(Unit Selected)
		{
			if(Selected.Defend() == true)
			{
				int iDamage = this.iStr - Selected.iDef;
				int iRemaining = Selected.iHP - iDamage;
				if(iRemaining <= 0)
				{
					iRemaining = 0;
					Selected.iHP = iRemaining;
					return true;
				}
				else if(iRemaining > 0)
				{
					Selected.iHP = iRemaining;
					return true;
				}
				return true;
			}
			else
			{
				return false;
			}
			
		}
		public bool Defend()
		{
			int iIncrease = this.iDef * 2;
			this.iDef = iIncrease;
			return true;
		}

		public bool Magic(Unit One, Unit Two)
		{

			return true;
		}
	}
}
