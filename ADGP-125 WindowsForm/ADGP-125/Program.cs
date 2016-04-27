using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
		public static string SaveDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/TempFolder/GameFiles/ADGP125PersonalFolder";
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			CreateApplicationDirecty();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form2());
		}
		static void CreateApplicationDirecty()
		{
			if(!Directory.Exists(SaveDataDirectory))
			{
				Directory.CreateDirectory(SaveDataDirectory);
			}
		}
	}
}
