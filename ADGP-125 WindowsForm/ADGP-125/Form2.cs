using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADGP_125
{
	public partial class Form2 : Form
	{

		XML_Stuff<Unit> _SaveLoad = new XML_Stuff<Unit>();

		public enum BattleStates
		{
			INIT,
			ACTIONSELECT,
			ENEMYSELECT,
			BATTLEPHASE,
			ENDBATTLE,
		}
		


		FSM StateMachine = new FSM(BattleStates.INIT);
		//public Unit Temp = new Unit();
		//public List<Unit> CharacterThings = new List<Unit>();
		//public string PlayerName;
		//public string Enemy1;
		//public string Enemy2;
		//public string Enemy3;

		public Form2()
		{
			InitializeComponent();
			
			StateMachine.AddState(BattleStates.INIT);
			StateMachine.AddState(BattleStates.ACTIONSELECT);
			StateMachine.AddState(BattleStates.ENEMYSELECT);
			StateMachine.AddState(BattleStates.BATTLEPHASE);
			StateMachine.AddState(BattleStates.ENDBATTLE);

			StateMachine.AddTransition(BattleStates.INIT, BattleStates.ACTIONSELECT);
			StateMachine.AddTransition(BattleStates.ACTIONSELECT, BattleStates.ENEMYSELECT);
			StateMachine.AddTransition(BattleStates.ENEMYSELECT, BattleStates.BATTLEPHASE);
			StateMachine.AddTransition(BattleStates.BATTLEPHASE, BattleStates.ENDBATTLE);
			StateMachine.AddTransition(BattleStates.BATTLEPHASE, BattleStates.ACTIONSELECT);
			StateMachine.AddTransition(BattleStates.ENEMYSELECT, BattleStates.ACTIONSELECT);
			StateMachine.AddTransition(BattleStates.ACTIONSELECT, BattleStates.ENDBATTLE);
			StateMachine.AddTransition(BattleStates.ACTIONSELECT, BattleStates.BATTLEPHASE);

			StateMachine.ChangeState(BattleStates.ACTIONSELECT);
		}

		Unit Temp;

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			if (StateMachine._State.Equals(BattleStates.ACTIONSELECT))
			{
				if (e.GetType() == typeof(MouseEventArgs))
				{

				}
			}

		}

		private void AttackSelect(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				StateMachine.ChangeState(BattleStates.ENEMYSELECT);
			}
		}

		private void SaveStates(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				Temp = new Unit(Named.Text, (int)Health2.Value, (int)Mana.Value/*, (int)Strength.Value*/, (int)Armour.Value, (int)Wisdom.Value, (int)Experience.Value, (int)Levels.Value, true);
				_SaveLoad.Seralization("UserInfo", Temp);
			}
		}
		private void buttonLoad_Click(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{

				Temp = _SaveLoad.Deserialization("UserInfo");
				Named.Text = Temp.Identifier;
				Health2.Value = Temp.iHealth;
				Mana.Value = Temp.iMana;
				//Strength.Value = Temp.iStrength;
				Armour.Value = Temp.iDefense;
				Wisdom.Value = Temp.iIntelligence;
				Experience.Value = Temp.iExperience;
				Levels.Value = Temp.iLevel;
				Temp.Alive = true;
			}
		}
		private void Block(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				StateMachine.ChangeState(BattleStates.BATTLEPHASE);
			}
		}

		private void MagicSelect(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				StateMachine.ChangeState(BattleStates.ENEMYSELECT);
			}
		}

		private void EscapeBattle(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{

			}
		}
	}
}
