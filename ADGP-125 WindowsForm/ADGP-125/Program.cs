using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Need Current HP and Max HP to be differentiated
//Need Current MP and Max MP to be differentiated
//Need Current State clearly defined
//Need switch statements for fighting
//Clarify game states
//Implement standard deviation
//Create enemies
//Make text for the game output

namespace ADGP_125
{
	static class Program
	{
		enum GameStates
		{
			INIT,
			ACTIONSELECT,
			ENEMYSELECT,
			BATTLEPHASE,
			ENDBATTLE,

		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			FSM FiniteStateMachine = new FSM(GameStates.INIT);
			FiniteStateMachine.AddState(GameStates.INIT);
			FiniteStateMachine.AddState(GameStates.ACTIONSELECT);
			FiniteStateMachine.AddState(GameStates.ENEMYSELECT);
			FiniteStateMachine.AddState(GameStates.BATTLEPHASE);
			FiniteStateMachine.AddState(GameStates.ENDBATTLE);

			FiniteStateMachine.AddTransition(GameStates.INIT, GameStates.ACTIONSELECT);
			FiniteStateMachine.AddTransition(GameStates.ACTIONSELECT, GameStates.ENEMYSELECT);
			FiniteStateMachine.AddTransition(GameStates.ENEMYSELECT, GameStates.BATTLEPHASE);
			FiniteStateMachine.AddTransition(GameStates.BATTLEPHASE, GameStates.ENDBATTLE);
			FiniteStateMachine.AddTransition(GameStates.BATTLEPHASE, GameStates.ACTIONSELECT);
			FiniteStateMachine.AddTransition(GameStates.ENEMYSELECT, GameStates.ACTIONSELECT);
			FiniteStateMachine.AddTransition(GameStates.ACTIONSELECT, GameStates.ENDBATTLE);
			FiniteStateMachine.AddTransition(GameStates.ACTIONSELECT, GameStates.BATTLEPHASE);

			//Player User = new Player(36, 50, 12, 16, 20, true);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
