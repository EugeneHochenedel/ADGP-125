using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
	[Serializable()]
	public class Unit : IStatsInterface, IActionsInterface<Unit>
	{
		private string Identifier;
		private int iHP, iMP, iStr, iDef, iInt, iExp, iLvl;
		bool Life;

		public enum tempEnum
		{
			testEnum1,
			testEnum2,
			testEnum3,
		}

		FSM TempMachineAgain = new FSM(tempEnum.testEnum1);

		//FSM testingMachine;

		public Unit()
		{

		}

		public Unit(string Person, int iLife, int iMag, int iPower, int iArm, int iKnow, int iPoints, int iTier, bool State)
		{
			Identifier = Person;
			iHP = iLife;
			iMP = iMag;
			iStr = iPower;
			iDef = iArm;
			iInt = iKnow;
			iExp = iPoints;
			iLvl = iTier;
			Life = State;
		}

		public string CharacterName
		{
			get
			{
				return Identifier;
			}
			set
			{
				Identifier = value;
			}
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
				return Life;
			}
			set
			{
				Life = value;
			}
		}

		public bool Attack(Unit Selected)
		{
			if (Selected.Defend() == true)
			{
				int iDamage = this.iStr - Selected.iDef;
				int iRemaining = Selected.iHP - iDamage;
				if (iRemaining <= 0)
				{
					iRemaining = 0;
					Selected.iHP = iRemaining;
				}
				else if (iRemaining > 0)
				{
					Selected.iHP = iRemaining;
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
			Console.WriteLine("Def: " + this.iDef);
			return true;
		}
		public bool Magic(Unit Two)
		{
			if (this.iMP > 5)
			{
				int iMagicTest1 = this.iInt * 2;
				int iHPRemaining = Two.iHP - iMagicTest1;
				if(iHPRemaining <= 0)
				{
					iHPRemaining = 0;
					Two.iHP = iHPRemaining;
					if(Two.iHP == 0)
					{
						Two.Alive = false;
					}
				}
				else if(iHPRemaining > 0)
				{
					Two.iHP = iHPRemaining;
					return true;
				}
				return true;
			}
			else if(this.iMP < 5)
			{
				return false;
			}
			return true;
		}

		public bool Flee(Unit LifeSpan, FSM letsTestThis)
		{
			letsTestThis = new FSM(tempEnum.testEnum1);
			if(LifeSpan.Life == true && letsTestThis._State.Equals(tempEnum.testEnum2))
			{
				return true;
			}
			else
			{
				return false;
			}
//			return true;
		}


		public bool GameOver()
		{
			if (this.Life == false)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
