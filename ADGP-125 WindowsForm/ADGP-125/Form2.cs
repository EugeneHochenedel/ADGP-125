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

		public List<string> _Test1 = new List<string>();

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

			buttonAttack.Click += (_Button, _Click) => { StateText_TextChanged(buttonAttack, (MouseEventArgs)_Click); };
			buttonMagic.Click += (_Button, _Click) => { StateText_TextChanged(buttonMagic, (MouseEventArgs)_Click); };
			buttonDefend.Click += (_Button, _Click) => { StateText_TextChanged(buttonDefend, (MouseEventArgs)_Click); };
			buttonFlee.Click += (_Button, _Click) => { StateText_TextChanged(buttonFlee, (MouseEventArgs)_Click); };
		}

		public Unit Temp = new Unit("A Name", 50, 23, 15, 5, 11, 50, 1, true);

		private void BattleInfo_TextChanged(object sender, EventArgs e)
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
					UserActionSelect.Hide();
					TargetSelect.Show();
				}
			}
		}
		private void SaveStates(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				_SaveLoad.Seralization("UserInfo", Temp);
			}
		}
		private void buttonLoad_Click(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				Temp = _SaveLoad.Deserialization("UserInfo");
				_Test1.Add("Name: " + Temp.CharacterName);
				_Test1.Add("HP: " + Temp.iHealth);
				_Test1.Add("MP: " + Temp.iMana);
				_Test1.Add("Strength: " + Temp.iStrength);
				_Test1.Add("Defense: " + Temp.iDefense);
				_Test1.Add("Intelligence: " + Temp.iIntelligence);
				_Test1.Add("Experience: " + Temp.iExperience);
				_Test1.Add("Level: " + Temp.iLevel);
				PlayerStats.DataSource = _Test1;
			}
		}
		private void Block(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				Temp.Defend();
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
					UserActionSelect.Hide();
					TargetSelect.Show();
				}
			}
		}
		private void EscapeBattle(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				StateMachine.ChangeState(BattleStates.ENDBATTLE);

			}
		}
		private void Previous(object sender, EventArgs e)
		{
			if(e.GetType() == typeof(MouseEventArgs))
			{
				StateMachine.ChangeState(BattleStates.ACTIONSELECT);
				if (StateMachine._State.Equals(BattleStates.ACTIONSELECT))
				{
					UserActionSelect.Show();
					TargetSelect.Hide();
				}
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			StateMachine.ChangeState(BattleStates.ACTIONSELECT);
			TargetSelect.Hide();
		}

		private void StateText_TextChanged(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				List<Button> Names = new List<Button>();
				Button Test1 = (Button)sender;
				
				Names.Add(Test1);


				foreach (Button b in Names)
				{
					StateText.Clear();
					StateText.Text += StateMachine._State;
				}
			}
		}
	}
}
