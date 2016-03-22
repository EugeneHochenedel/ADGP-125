﻿namespace ADGP_125
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
			this.BattleInfo = new System.Windows.Forms.RichTextBox();
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
			this.SuspendLayout();
			// 
			// BattleInfo
			// 
			this.BattleInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.BattleInfo.Location = new System.Drawing.Point(10, 10);
			this.BattleInfo.Name = "BattleInfo";
			this.BattleInfo.Size = new System.Drawing.Size(600, 580);
			this.BattleInfo.TabIndex = 0;
			this.BattleInfo.Text = "";
			this.BattleInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// buttonAttack
			// 
			this.buttonAttack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAttack.Location = new System.Drawing.Point(650, 250);
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
			this.buttonDefend.Location = new System.Drawing.Point(650, 300);
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
			this.buttonMagic.Location = new System.Drawing.Point(785, 250);
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
			this.buttonFlee.Location = new System.Drawing.Point(785, 300);
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
			this.buttonSave.Location = new System.Drawing.Point(650, 555);
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
			this.PlayerStats.Location = new System.Drawing.Point(650, 10);
			this.PlayerStats.Name = "PlayerStats";
			this.PlayerStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.PlayerStats.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.PlayerStats.Size = new System.Drawing.Size(350, 194);
			this.PlayerStats.TabIndex = 5;
			// 
			// buttonLoad
			// 
			this.buttonLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLoad.Location = new System.Drawing.Point(785, 555);
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
			this.buttonBack.Location = new System.Drawing.Point(650, 350);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(80, 35);
			this.buttonBack.TabIndex = 25;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Visible = false;
			this.buttonBack.Click += new System.EventHandler(this.Previous);
			// 
			// Enemy1
			// 
			this.Enemy1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Enemy1.Location = new System.Drawing.Point(650, 250);
			this.Enemy1.Name = "Enemy1";
			this.Enemy1.Size = new System.Drawing.Size(80, 35);
			this.Enemy1.TabIndex = 29;
			this.Enemy1.Text = "Enemy1";
			this.Enemy1.UseVisualStyleBackColor = true;
			this.Enemy1.Visible = false;
			// 
			// Enemy2
			// 
			this.Enemy2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Enemy2.Location = new System.Drawing.Point(785, 250);
			this.Enemy2.Name = "Enemy2";
			this.Enemy2.Size = new System.Drawing.Size(80, 35);
			this.Enemy2.TabIndex = 30;
			this.Enemy2.Text = "Enemy2";
			this.Enemy2.UseVisualStyleBackColor = true;
			this.Enemy2.Visible = false;
			// 
			// Enemy3
			// 
			this.Enemy3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Enemy3.Location = new System.Drawing.Point(650, 300);
			this.Enemy3.Name = "Enemy3";
			this.Enemy3.Size = new System.Drawing.Size(80, 35);
			this.Enemy3.TabIndex = 31;
			this.Enemy3.Text = "Enemy3";
			this.Enemy3.UseVisualStyleBackColor = true;
			this.Enemy3.Visible = false;
			// 
			// Enemy4
			// 
			this.Enemy4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Enemy4.Location = new System.Drawing.Point(785, 300);
			this.Enemy4.Name = "Enemy4";
			this.Enemy4.Size = new System.Drawing.Size(80, 35);
			this.Enemy4.TabIndex = 32;
			this.Enemy4.Text = "Enemy4";
			this.Enemy4.UseVisualStyleBackColor = true;
			this.Enemy4.Visible = false;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1020, 600);
			this.Controls.Add(this.buttonAttack);
			this.Controls.Add(this.buttonMagic);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.PlayerStats);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonFlee);
			this.Controls.Add(this.buttonDefend);
			this.Controls.Add(this.BattleInfo);
			this.Controls.Add(this.Enemy1);
			this.Controls.Add(this.Enemy2);
			this.Controls.Add(this.Enemy3);
			this.Controls.Add(this.Enemy4);
			this.HelpButton = true;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox BattleInfo;
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
	}
}