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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.buttonAttack = new System.Windows.Forms.Button();
			this.buttonDefend = new System.Windows.Forms.Button();
			this.buttonMagic = new System.Windows.Forms.Button();
			this.buttonFlee = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.PlayerStats = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.richTextBox1.Location = new System.Drawing.Point(10, 10);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(600, 580);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
			this.buttonDefend.Location = new System.Drawing.Point(920, 250);
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
			this.buttonFlee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonFlee.Location = new System.Drawing.Point(650, 300);
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
			this.buttonSave.Location = new System.Drawing.Point(920, 300);
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
			this.PlayerStats.HorizontalScrollbar = true;
			this.PlayerStats.ItemHeight = 19;
			this.PlayerStats.Items.AddRange(new object[] {
            "Name",
            "HP",
            "MP",
            "Level",
            "Experience"});
			this.PlayerStats.Location = new System.Drawing.Point(650, 10);
			this.PlayerStats.Name = "PlayerStats";
			this.PlayerStats.Size = new System.Drawing.Size(350, 213);
			this.PlayerStats.TabIndex = 5;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1020, 600);
			this.Controls.Add(this.PlayerStats);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonFlee);
			this.Controls.Add(this.buttonMagic);
			this.Controls.Add(this.buttonDefend);
			this.Controls.Add(this.buttonAttack);
			this.Controls.Add(this.richTextBox1);
			this.HelpButton = true;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button buttonAttack;
		private System.Windows.Forms.Button buttonDefend;
		private System.Windows.Forms.Button buttonMagic;
		private System.Windows.Forms.Button buttonFlee;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ListBox PlayerStats;
	}
}