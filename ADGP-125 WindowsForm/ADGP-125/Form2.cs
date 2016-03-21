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
		public enum BattleStates
		{
			INIT,
			ACTIONSELECT,
			ENEMYSELECT,
			BATTLEPHASE,
			ENDBATTLE,

		}
	

		FSM StateMachine = new FSM(BattleStates.INIT);
		public Unit Temp = new Unit();
		public List<Unit> CharacterThings = new List<Unit>();
		public string PlayerName;
		public string Enemy1;
		public string Enemy2;
		public string Enemy3;

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
				if (StateMachine.Check(BattleStates.ENEMYSELECT))
				{
					Console.WriteLine("More experimenting");
				}
			}
		}

		private void SaveStates(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{

			}
		}

		private void Block(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{

			}
		}

		private void MagicSelect(object sender, EventArgs e)
		{
			if (e.GetType() == typeof(MouseEventArgs))
			{

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
