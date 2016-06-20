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
			CHARACTERCREATION,
			ACTIONSELECT,
			ENEMYSELECT,
			BATTLEPHASE,
			ENDBATTLE,
			FILLER,
		}

		FSM StateMachine = new FSM(BattleStates.INIT);

		public Form2()
		{
			InitializeComponent();

			StateMachine.AddState(BattleStates.INIT);
			StateMachine.AddState(BattleStates.CHARACTERCREATION);
			StateMachine.AddState(BattleStates.ACTIONSELECT);
			StateMachine.AddState(BattleStates.ENEMYSELECT);
			StateMachine.AddState(BattleStates.BATTLEPHASE);
			StateMachine.AddState(BattleStates.ENDBATTLE);

			StateMachine.AddTransition(BattleStates.INIT, BattleStates.CHARACTERCREATION);
			StateMachine.AddTransition(BattleStates.CHARACTERCREATION, BattleStates.ACTIONSELECT);
			StateMachine.AddTransition(BattleStates.ACTIONSELECT, BattleStates.ENEMYSELECT);
			StateMachine.AddTransition(BattleStates.ACTIONSELECT, BattleStates.CHARACTERCREATION);
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
			buttonBack.Click += (_Button, _Click) => { StateText_TextChanged(buttonBack, (MouseEventArgs)_Click); };
			Return.Click += (_Button, _Click) => { StateText_TextChanged(Return, (MouseEventArgs)_Click); };
			UserButton.Click += (_Button, _Click) => { StateText_TextChanged(UserButton, (MouseEventArgs)_Click); };
		}

		Unit PlayerStatistics;

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
				PlayerStatistics = new Unit();
				_SaveLoad.Seralization("UserInfo", PlayerStatistics);
			}
		}
		private void buttonLoad_Click(object sender, EventArgs e)
		{
			StateMachine.ChangeState(BattleStates.ACTIONSELECT);
			if (e.GetType() == typeof(MouseEventArgs))
			{
				PlayerStatistics = _SaveLoad.Deserialization("UserInfo");
				_Test1.Add("Name: " + PlayerStatistics.CharacterName);
				_Test1.Add("HP: " + PlayerStatistics.iHealth);
				_Test1.Add("MP: " + PlayerStatistics.iMana);
				_Test1.Add("Strength: " + PlayerStatistics.iStrength);
				_Test1.Add("Defense: " + PlayerStatistics.iDefense);
				_Test1.Add("Intelligence: " + PlayerStatistics.iIntelligence);
				_Test1.Add("Experience: " + PlayerStatistics.iExperience);
				_Test1.Add("Level: " + PlayerStatistics.iLevel);
				PlayerStats.DataSource = _Test1;
			}
			GameStart.Hide();
			InGame.Show();
			TargetSelect.Hide();
		}
		private void Block(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{
				PlayerStatistics.Defend();
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
				if (StateMachine._State.Equals(BattleStates.ENDBATTLE))
				{
					
				}
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
			StateMachine.ChangeState(BattleStates.CHARACTERCREATION);
			InGame.Hide();
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

		private void UserButton_Click(object sender, EventArgs e)
		{
			StateMachine.ChangeState(BattleStates.ACTIONSELECT);
			if (e.GetType() == typeof(MouseEventArgs))
			{
				PlayerStatistics = new Unit();
				PlayerStatistics.CharacterName = NameBox.Text;
				PlayerStatistics.iHealth = (int)HealthPick.Value;
				PlayerStatistics.iMana = (int)ManaPick.Value;
				PlayerStatistics.iStrength = (int)StrengthPick.Value;
				PlayerStatistics.iDefense = (int)DefensePick.Value;
				PlayerStatistics.iIntelligence = (int)IntelligencePick.Value;
				PlayerStatistics.iExperience = (int)ExperiencePick.Value;
				PlayerStatistics.iLevel = (int)LevelPick.Value;
				PlayerStatistics.Alive = true;
				_SaveLoad.Seralization("UserInfo", PlayerStatistics);
				
			}
			InGame.Show();
			GameStart.Hide();
			TargetSelect.Hide();
		}

		private void Return_Click(object sender, EventArgs e)
		{
			StateMachine.ChangeState(BattleStates.CHARACTERCREATION);
			InGame.Hide();
			GameStart.Show();
		}
	}
}