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
		}

		Unit Temp;

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
			}
		}

		private void AttackSelect(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				StateMachine.ChangeState(BattleStates.ENEMYSELECT);
				if (StateMachine._State.Equals(BattleStates.ENEMYSELECT))
				{
					buttonDefend.Hide();
					buttonMagic.Hide();
					buttonFlee.Hide();
					buttonAttack.Hide();
					buttonBack.Show();
					Enemy1.Show();
					Enemy2.Show();
					Enemy3.Show();
					Enemy4.Show();
				}
			}
		}
		private void SaveStates(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				Temp = new Unit(Named.Text, (int)HealthPoints.Value, (int)MagicPoints.Value, (int)Power.Value, (int)Armour.Value, (int)Wisdom.Value, (int)Experience.Value, (int)Levels.Value, true);
				_SaveLoad.Seralization("UserInfo", Temp);
			}
		}
		private void buttonLoad_Click(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				Temp = _SaveLoad.Deserialization("UserInfo");
				Named.Text = Temp.CharacterName;
				HealthPoints.Value = Temp.iHealth;
				MagicPoints.Value = Temp.iMana;
				Power.Value = Temp.iStrength;
				Armour.Value = Temp.iDefense;
				Wisdom.Value = Temp.iIntelligence;
				Experience.Value = Temp.iExperience;
				Levels.Value = Temp.iLevel;
				//Temp.Alive = true;
			}
		}
		private void Block(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				//StateMachine.ChangeState(BattleStates.BATTLEPHASE);
			}
		}
		private void MagicSelect(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				StateMachine.ChangeState(BattleStates.ENEMYSELECT);
				if (StateMachine._State.Equals(BattleStates.ENEMYSELECT))
				{
					Enemy1.Show();
					Enemy2.Show();
					Enemy3.Show();
					Enemy4.Show();
					buttonDefend.Hide();
					buttonAttack.Hide();
					buttonFlee.Hide();
					buttonMagic.Hide();
					buttonBack.Show();
				}
			}
		}
		private void EscapeBattle(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{

			}
		}
		private void Previous(object sender, EventArgs e)
		{
			if(e.GetType() == typeof(MouseEventArgs))
			{
				StateMachine.ChangeState(BattleStates.ACTIONSELECT);
				if (StateMachine._State.Equals(BattleStates.ACTIONSELECT))
				{
					buttonBack.Hide();
					buttonMagic.Show();
					buttonDefend.Show();
					buttonAttack.Show();
					buttonFlee.Show();
					Enemy1.Hide();
					Enemy2.Hide();
					Enemy3.Hide();
					Enemy4.Hide();
				}
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			StateMachine.ChangeState(BattleStates.ACTIONSELECT);
		}
	}
}
