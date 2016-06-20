namespace ADGP_125
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonAttack = new System.Windows.Forms.Button();
			this.buttonDefend = new System.Windows.Forms.Button();
			this.buttonMagic = new System.Windows.Forms.Button();
			this.buttonFlee = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.PlayerStats = new System.Windows.Forms.ListBox();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.Enemy1 = new System.Windows.Forms.Button();
			this.Enemy2 = new System.Windows.Forms.Button();
			this.Enemy3 = new System.Windows.Forms.Button();
			this.Enemy4 = new System.Windows.Forms.Button();
			this.StateText = new System.Windows.Forms.TextBox();
			this.UserActionSelect = new System.Windows.Forms.GroupBox();
			this.TargetSelect = new System.Windows.Forms.GroupBox();
			this.SaveAndLoad = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.HealthPick = new System.Windows.Forms.NumericUpDown();
			this.ManaPick = new System.Windows.Forms.NumericUpDown();
			this.StrengthPick = new System.Windows.Forms.NumericUpDown();
			this.DefensePick = new System.Windows.Forms.NumericUpDown();
			this.IntelligencePick = new System.Windows.Forms.NumericUpDown();
			this.ExperiencePick = new System.Windows.Forms.NumericUpDown();
			this.LevelPick = new System.Windows.Forms.NumericUpDown();
			this.UserButton = new System.Windows.Forms.Button();
			this.GameStart = new System.Windows.Forms.GroupBox();
			this.InGame = new System.Windows.Forms.GroupBox();
			this.Return = new System.Windows.Forms.Button();
			this.UserActionSelect.SuspendLayout();
			this.TargetSelect.SuspendLayout();
			this.SaveAndLoad.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HealthPick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ManaPick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StrengthPick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DefensePick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IntelligencePick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ExperiencePick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LevelPick)).BeginInit();
			this.GameStart.SuspendLayout();
			this.InGame.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAttack
			// 
			this.buttonAttack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAttack.Location = new System.Drawing.Point(10, 20);
			this.buttonAttack.Name = "buttonAttack";
			this.buttonAttack.Size = new System.Drawing.Size(80, 35);
			this.buttonAttack.TabIndex = 1;
			this.buttonAttack.Text = "Attack";
			this.buttonAttack.UseVisualStyleBackColor = true;
			this.buttonAttack.Click += new System.EventHandler(this.AttackSelect);
			// 
			// buttonDefend
			// 
			this.buttonDefend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDefend.Location = new System.Drawing.Point(10, 70);
			this.buttonDefend.Name = "buttonDefend";
			this.buttonDefend.Size = new System.Drawing.Size(80, 35);
			this.buttonDefend.TabIndex = 2;
			this.buttonDefend.Text = "Defend";
			this.buttonDefend.UseVisualStyleBackColor = true;
			this.buttonDefend.Click += new System.EventHandler(this.Block);
			// 
			// buttonMagic
			// 
			this.buttonMagic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMagic.Location = new System.Drawing.Point(145, 20);
			this.buttonMagic.Name = "buttonMagic";
			this.buttonMagic.Size = new System.Drawing.Size(80, 35);
			this.buttonMagic.TabIndex = 3;
			this.buttonMagic.Text = "Magic";
			this.buttonMagic.UseVisualStyleBackColor = true;
			this.buttonMagic.Click += new System.EventHandler(this.MagicSelect);
			// 
			// buttonFlee
			// 
			this.buttonFlee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonFlee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonFlee.Location = new System.Drawing.Point(145, 70);
			this.buttonFlee.Name = "buttonFlee";
			this.buttonFlee.Size = new System.Drawing.Size(80, 35);
			this.buttonFlee.TabIndex = 4;
			this.buttonFlee.Text = "Flee";
			this.buttonFlee.UseVisualStyleBackColor = true;
			this.buttonFlee.Click += new System.EventHandler(this.EscapeBattle);
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.Location = new System.Drawing.Point(10, 20);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(80, 35);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.SaveStates);
			// 
			// PlayerStats
			// 
			this.PlayerStats.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerStats.FormattingEnabled = true;
			this.PlayerStats.ItemHeight = 19;
			this.PlayerStats.Items.AddRange(new object[] {
            "Name",
            "HP",
            "MP",
            "Strength",
            "Defense",
            "Intelligence",
            "Experience",
            "Level"});
			this.PlayerStats.Location = new System.Drawing.Point(81, 19);
			this.PlayerStats.Name = "PlayerStats";
			this.PlayerStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.PlayerStats.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.PlayerStats.Size = new System.Drawing.Size(350, 194);
			this.PlayerStats.TabIndex = 5;
			// 
			// buttonLoad
			// 
			this.buttonLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLoad.Location = new System.Drawing.Point(145, 20);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(80, 35);
			this.buttonLoad.TabIndex = 24;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBack.Location = new System.Drawing.Point(10, 120);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(80, 35);
			this.buttonBack.TabIndex = 25;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.Previous);
			// 
			// Enemy1
			// 
			this.Enemy1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Enemy1.Location = new System.Drawing.Point(10, 20);
			this.Enemy1.Name = "Enemy1";
			this.Enemy1.Size = new System.Drawing.Size(80, 35);
			this.Enemy1.TabIndex = 29;
			this.Enemy1.Text = "Enemy1";
			this.Enemy1.UseVisualStyleBackColor = true;
			// 
			// Enemy2
			// 
			this.Enemy2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Enemy2.Location = new System.Drawing.Point(145, 20);
			this.Enemy2.Name = "Enemy2";
			this.Enemy2.Size = new System.Drawing.Size(80, 35);
			this.Enemy2.TabIndex = 30;
			this.Enemy2.Text = "Enemy2";
			this.Enemy2.UseVisualStyleBackColor = true;
			// 
			// Enemy3
			// 
			this.Enemy3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Enemy3.Location = new System.Drawing.Point(10, 70);
			this.Enemy3.Name = "Enemy3";
			this.Enemy3.Size = new System.Drawing.Size(80, 35);
			this.Enemy3.TabIndex = 31;
			this.Enemy3.Text = "Enemy3";
			this.Enemy3.UseVisualStyleBackColor = true;
			// 
			// Enemy4
			// 
			this.Enemy4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Enemy4.Location = new System.Drawing.Point(145, 70);
			this.Enemy4.Name = "Enemy4";
			this.Enemy4.Size = new System.Drawing.Size(80, 35);
			this.Enemy4.TabIndex = 32;
			this.Enemy4.Text = "Enemy4";
			this.Enemy4.UseVisualStyleBackColor = true;
			// 
			// StateText
			// 
			this.StateText.Location = new System.Drawing.Point(673, 423);
			this.StateText.Multiline = true;
			this.StateText.Name = "StateText";
			this.StateText.Size = new System.Drawing.Size(192, 61);
			this.StateText.TabIndex = 33;
			this.StateText.TextChanged += new System.EventHandler(this.StateText_TextChanged);
			// 
			// UserActionSelect
			// 
			this.UserActionSelect.Controls.Add(this.buttonMagic);
			this.UserActionSelect.Controls.Add(this.buttonAttack);
			this.UserActionSelect.Controls.Add(this.buttonDefend);
			this.UserActionSelect.Controls.Add(this.buttonFlee);
			this.UserActionSelect.Location = new System.Drawing.Point(81, 219);
			this.UserActionSelect.Name = "UserActionSelect";
			this.UserActionSelect.Size = new System.Drawing.Size(235, 125);
			this.UserActionSelect.TabIndex = 34;
			this.UserActionSelect.TabStop = false;
			this.UserActionSelect.Text = "BattleMenu";
			// 
			// TargetSelect
			// 
			this.TargetSelect.Controls.Add(this.Enemy1);
			this.TargetSelect.Controls.Add(this.Enemy3);
			this.TargetSelect.Controls.Add(this.Enemy2);
			this.TargetSelect.Controls.Add(this.buttonBack);
			this.TargetSelect.Controls.Add(this.Enemy4);
			this.TargetSelect.Location = new System.Drawing.Point(81, 225);
			this.TargetSelect.Name = "TargetSelect";
			this.TargetSelect.Size = new System.Drawing.Size(235, 175);
			this.TargetSelect.TabIndex = 35;
			this.TargetSelect.TabStop = false;
			this.TargetSelect.Text = "EnemySelect";
			// 
			// SaveAndLoad
			// 
			this.SaveAndLoad.Controls.Add(this.buttonSave);
			this.SaveAndLoad.Controls.Add(this.buttonLoad);
			this.SaveAndLoad.Location = new System.Drawing.Point(650, 515);
			this.SaveAndLoad.Name = "SaveAndLoad";
			this.SaveAndLoad.Size = new System.Drawing.Size(235, 75);
			this.SaveAndLoad.TabIndex = 36;
			this.SaveAndLoad.TabStop = false;
			this.SaveAndLoad.Text = "SaveOrLoad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 37;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 38;
			this.label2.Text = "Health";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 39;
			this.label3.Text = "Mana";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 40;
			this.label4.Text = "Strength";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 179);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 41;
			this.label5.Text = "Defense";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 209);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 42;
			this.label6.Text = "Intelligence";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 251);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 43;
			this.label7.Text = "Experience";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 301);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 13);
			this.label8.TabIndex = 44;
			this.label8.Text = "Level";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(193, 38);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(100, 20);
			this.NameBox.TabIndex = 45;
			// 
			// HealthPick
			// 
			this.HealthPick.Location = new System.Drawing.Point(193, 74);
			this.HealthPick.Name = "HealthPick";
			this.HealthPick.Size = new System.Drawing.Size(120, 20);
			this.HealthPick.TabIndex = 46;
			// 
			// ManaPick
			// 
			this.ManaPick.Location = new System.Drawing.Point(193, 106);
			this.ManaPick.Name = "ManaPick";
			this.ManaPick.Size = new System.Drawing.Size(120, 20);
			this.ManaPick.TabIndex = 47;
			// 
			// StrengthPick
			// 
			this.StrengthPick.Location = new System.Drawing.Point(193, 143);
			this.StrengthPick.Name = "StrengthPick";
			this.StrengthPick.Size = new System.Drawing.Size(120, 20);
			this.StrengthPick.TabIndex = 48;
			// 
			// DefensePick
			// 
			this.DefensePick.Location = new System.Drawing.Point(193, 177);
			this.DefensePick.Name = "DefensePick";
			this.DefensePick.Size = new System.Drawing.Size(120, 20);
			this.DefensePick.TabIndex = 49;
			// 
			// IntelligencePick
			// 
			this.IntelligencePick.Location = new System.Drawing.Point(193, 207);
			this.IntelligencePick.Name = "IntelligencePick";
			this.IntelligencePick.Size = new System.Drawing.Size(120, 20);
			this.IntelligencePick.TabIndex = 50;
			// 
			// ExperiencePick
			// 
			this.ExperiencePick.Location = new System.Drawing.Point(193, 249);
			this.ExperiencePick.Name = "ExperiencePick";
			this.ExperiencePick.Size = new System.Drawing.Size(120, 20);
			this.ExperiencePick.TabIndex = 51;
			// 
			// LevelPick
			// 
			this.LevelPick.Location = new System.Drawing.Point(193, 299);
			this.LevelPick.Name = "LevelPick";
			this.LevelPick.Size = new System.Drawing.Size(120, 20);
			this.LevelPick.TabIndex = 52;
			// 
			// UserButton
			// 
			this.UserButton.Location = new System.Drawing.Point(85, 363);
			this.UserButton.Name = "UserButton";
			this.UserButton.Size = new System.Drawing.Size(147, 23);
			this.UserButton.TabIndex = 53;
			this.UserButton.Text = "Create Character";
			this.UserButton.UseVisualStyleBackColor = true;
			this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
			// 
			// GameStart
			// 
			this.GameStart.Controls.Add(this.LevelPick);
			this.GameStart.Controls.Add(this.UserButton);
			this.GameStart.Controls.Add(this.ExperiencePick);
			this.GameStart.Controls.Add(this.IntelligencePick);
			this.GameStart.Controls.Add(this.DefensePick);
			this.GameStart.Controls.Add(this.StrengthPick);
			this.GameStart.Controls.Add(this.ManaPick);
			this.GameStart.Controls.Add(this.HealthPick);
			this.GameStart.Controls.Add(this.NameBox);
			this.GameStart.Controls.Add(this.label8);
			this.GameStart.Controls.Add(this.label7);
			this.GameStart.Controls.Add(this.label6);
			this.GameStart.Controls.Add(this.label5);
			this.GameStart.Controls.Add(this.label4);
			this.GameStart.Controls.Add(this.label3);
			this.GameStart.Controls.Add(this.label2);
			this.GameStart.Controls.Add(this.label1);
			this.GameStart.Location = new System.Drawing.Point(12, 12);
			this.GameStart.Name = "GameStart";
			this.GameStart.Size = new System.Drawing.Size(398, 418);
			this.GameStart.TabIndex = 54;
			this.GameStart.TabStop = false;
			this.GameStart.Text = "CharacterCreation";
			// 
			// InGame
			// 
			this.InGame.Controls.Add(this.UserActionSelect);
			this.InGame.Controls.Add(this.PlayerStats);
			this.InGame.Controls.Add(this.TargetSelect);
			this.InGame.Location = new System.Drawing.Point(525, 8);
			this.InGame.Name = "InGame";
			this.InGame.Size = new System.Drawing.Size(487, 406);
			this.InGame.TabIndex = 55;
			this.InGame.TabStop = false;
			this.InGame.Text = "TheGame";
			// 
			// Return
			// 
			this.Return.Location = new System.Drawing.Point(491, 535);
			this.Return.Name = "Return";
			this.Return.Size = new System.Drawing.Size(94, 53);
			this.Return.TabIndex = 56;
			this.Return.Text = "Back To Creation";
			this.Return.UseVisualStyleBackColor = true;
			this.Return.Click += new System.EventHandler(this.Return_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1020, 600);
			this.Controls.Add(this.Return);
			this.Controls.Add(this.InGame);
			this.Controls.Add(this.GameStart);
			this.Controls.Add(this.SaveAndLoad);
			this.Controls.Add(this.StateText);
			this.HelpButton = true;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.UserActionSelect.ResumeLayout(false);
			this.TargetSelect.ResumeLayout(false);
			this.SaveAndLoad.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.HealthPick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ManaPick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StrengthPick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DefensePick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IntelligencePick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ExperiencePick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LevelPick)).EndInit();
			this.GameStart.ResumeLayout(false);
			this.GameStart.PerformLayout();
			this.InGame.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonAttack;
		private System.Windows.Forms.Button buttonDefend;
		private System.Windows.Forms.Button buttonMagic;
		private System.Windows.Forms.Button buttonFlee;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ListBox PlayerStats;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button Enemy1;
		private System.Windows.Forms.Button Enemy2;
		private System.Windows.Forms.Button Enemy3;
		private System.Windows.Forms.Button Enemy4;
		private System.Windows.Forms.TextBox StateText;
		private System.Windows.Forms.GroupBox UserActionSelect;
		private System.Windows.Forms.GroupBox TargetSelect;
		private System.Windows.Forms.GroupBox SaveAndLoad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.NumericUpDown HealthPick;
		private System.Windows.Forms.NumericUpDown ManaPick;
		private System.Windows.Forms.NumericUpDown StrengthPick;
		private System.Windows.Forms.NumericUpDown DefensePick;
		private System.Windows.Forms.NumericUpDown IntelligencePick;
		private System.Windows.Forms.NumericUpDown ExperiencePick;
		private System.Windows.Forms.NumericUpDown LevelPick;
		private System.Windows.Forms.Button UserButton;
		private System.Windows.Forms.GroupBox GameStart;
		private System.Windows.Forms.GroupBox InGame;
		private System.Windows.Forms.Button Return;
	}
}