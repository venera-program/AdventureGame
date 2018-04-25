namespace PresentationLayer
{
	partial class Program_Window
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
			this.Item_List = new System.Windows.Forms.ListBox();
			this.Item_Current_Label = new System.Windows.Forms.Label();
			this.Message_Log_Label = new System.Windows.Forms.Label();
			this.Item_Current_Description = new System.Windows.Forms.Label();
			this.Message_Log_Window = new System.Windows.Forms.Label();
			this.Item_List_Label = new System.Windows.Forms.Label();
			this.Movement_Button_West = new System.Windows.Forms.Button();
			this.Movement_Button_South = new System.Windows.Forms.Button();
			this.Movement_Button_East = new System.Windows.Forms.Button();
			this.Movement_Button_North = new System.Windows.Forms.Button();
			this.Movement_Box = new System.Windows.Forms.GroupBox();
			this.Combat_Button_Attack = new System.Windows.Forms.Button();
			this.Combat_Box = new System.Windows.Forms.GroupBox();
			this.Combat_Label_Enemy = new System.Windows.Forms.Label();
			this.Combat_Label_Player = new System.Windows.Forms.Label();
			this.Combat_Bar_Enemy = new System.Windows.Forms.ProgressBar();
			this.Combat_Bar_Player = new System.Windows.Forms.ProgressBar();
			this.Movement_Box.SuspendLayout();
			this.Combat_Box.SuspendLayout();
			this.SuspendLayout();
			// 
			// Item_List
			// 
			this.Item_List.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Item_List.FormattingEnabled = true;
			this.Item_List.Location = new System.Drawing.Point(12, 32);
			this.Item_List.Name = "Item_List";
			this.Item_List.Size = new System.Drawing.Size(143, 134);
			this.Item_List.TabIndex = 2;
			this.Item_List.ValueMemberChanged += new System.EventHandler(this.RefreshUI_CurrentItemInfo);
			this.Item_List.SelectedValueChanged += new System.EventHandler(this.RefreshUI_CurrentItemInfo);
			// 
			// Item_Current_Label
			// 
			this.Item_Current_Label.BackColor = System.Drawing.SystemColors.Window;
			this.Item_Current_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Item_Current_Label.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Item_Current_Label.Location = new System.Drawing.Point(11, 172);
			this.Item_Current_Label.Margin = new System.Windows.Forms.Padding(3);
			this.Item_Current_Label.Name = "Item_Current_Label";
			this.Item_Current_Label.Size = new System.Drawing.Size(144, 20);
			this.Item_Current_Label.TabIndex = 3;
			this.Item_Current_Label.Text = "$Item Name";
			this.Item_Current_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Message_Log_Label
			// 
			this.Message_Log_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Message_Log_Label.AutoSize = true;
			this.Message_Log_Label.BackColor = System.Drawing.SystemColors.Window;
			this.Message_Log_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Message_Log_Label.Cursor = System.Windows.Forms.Cursors.No;
			this.Message_Log_Label.Location = new System.Drawing.Point(0, 285);
			this.Message_Log_Label.Margin = new System.Windows.Forms.Padding(3);
			this.Message_Log_Label.Name = "Message_Log_Label";
			this.Message_Log_Label.Padding = new System.Windows.Forms.Padding(1);
			this.Message_Log_Label.Size = new System.Drawing.Size(75, 17);
			this.Message_Log_Label.TabIndex = 4;
			this.Message_Log_Label.Text = "Message Log";
			// 
			// Item_Current_Description
			// 
			this.Item_Current_Description.BackColor = System.Drawing.SystemColors.Window;
			this.Item_Current_Description.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Item_Current_Description.Location = new System.Drawing.Point(11, 195);
			this.Item_Current_Description.Margin = new System.Windows.Forms.Padding(3);
			this.Item_Current_Description.Name = "Item_Current_Description";
			this.Item_Current_Description.Size = new System.Drawing.Size(142, 84);
			this.Item_Current_Description.TabIndex = 7;
			this.Item_Current_Description.Text = "$Description";
			// 
			// Message_Log_Window
			// 
			this.Message_Log_Window.BackColor = System.Drawing.SystemColors.Window;
			this.Message_Log_Window.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Message_Log_Window.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Message_Log_Window.Location = new System.Drawing.Point(0, 305);
			this.Message_Log_Window.Name = "Message_Log_Window";
			this.Message_Log_Window.Size = new System.Drawing.Size(484, 56);
			this.Message_Log_Window.TabIndex = 8;
			this.Message_Log_Window.Text = "$Output";
			// 
			// Item_List_Label
			// 
			this.Item_List_Label.BackColor = System.Drawing.SystemColors.Window;
			this.Item_List_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Item_List_Label.Location = new System.Drawing.Point(11, 9);
			this.Item_List_Label.Name = "Item_List_Label";
			this.Item_List_Label.Size = new System.Drawing.Size(143, 20);
			this.Item_List_Label.TabIndex = 9;
			this.Item_List_Label.Text = "Room Items";
			this.Item_List_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Movement_Button_West
			// 
			this.Movement_Button_West.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Movement_Button_West.Location = new System.Drawing.Point(8, 58);
			this.Movement_Button_West.Margin = new System.Windows.Forms.Padding(5);
			this.Movement_Button_West.Name = "Movement_Button_West";
			this.Movement_Button_West.Size = new System.Drawing.Size(80, 40);
			this.Movement_Button_West.TabIndex = 5;
			this.Movement_Button_West.Text = "Move &West";
			this.Movement_Button_West.UseVisualStyleBackColor = true;
			this.Movement_Button_West.EnabledChanged += new System.EventHandler(this.UI_SyncObjectVisibility);
			this.Movement_Button_West.Click += new System.EventHandler(this.Movement_Button_West_Click);
			// 
			// Movement_Button_South
			// 
			this.Movement_Button_South.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Movement_Button_South.Location = new System.Drawing.Point(116, 109);
			this.Movement_Button_South.Margin = new System.Windows.Forms.Padding(5);
			this.Movement_Button_South.Name = "Movement_Button_South";
			this.Movement_Button_South.Size = new System.Drawing.Size(80, 40);
			this.Movement_Button_South.TabIndex = 6;
			this.Movement_Button_South.Text = "Move &South";
			this.Movement_Button_South.UseVisualStyleBackColor = true;
			this.Movement_Button_South.EnabledChanged += new System.EventHandler(this.UI_SyncObjectVisibility);
			this.Movement_Button_South.Click += new System.EventHandler(this.Movement_Button_South_Click);
			// 
			// Movement_Button_East
			// 
			this.Movement_Button_East.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Movement_Button_East.Location = new System.Drawing.Point(223, 58);
			this.Movement_Button_East.Margin = new System.Windows.Forms.Padding(5);
			this.Movement_Button_East.Name = "Movement_Button_East";
			this.Movement_Button_East.Size = new System.Drawing.Size(80, 40);
			this.Movement_Button_East.TabIndex = 0;
			this.Movement_Button_East.Text = "Move &East";
			this.Movement_Button_East.UseVisualStyleBackColor = true;
			this.Movement_Button_East.EnabledChanged += new System.EventHandler(this.UI_SyncObjectVisibility);
			this.Movement_Button_East.Click += new System.EventHandler(this.Movement_Button_East_Click);
			// 
			// Movement_Button_North
			// 
			this.Movement_Button_North.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Movement_Button_North.Location = new System.Drawing.Point(116, 21);
			this.Movement_Button_North.Margin = new System.Windows.Forms.Padding(5);
			this.Movement_Button_North.Name = "Movement_Button_North";
			this.Movement_Button_North.Size = new System.Drawing.Size(80, 40);
			this.Movement_Button_North.TabIndex = 1;
			this.Movement_Button_North.Text = "Move &North";
			this.Movement_Button_North.UseVisualStyleBackColor = true;
			this.Movement_Button_North.EnabledChanged += new System.EventHandler(this.UI_SyncObjectVisibility);
			this.Movement_Button_North.Click += new System.EventHandler(this.Movement_Button_North_Click);
			// 
			// Movement_Box
			// 
			this.Movement_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Movement_Box.BackColor = System.Drawing.SystemColors.Control;
			this.Movement_Box.Controls.Add(this.Movement_Button_North);
			this.Movement_Box.Controls.Add(this.Movement_Button_East);
			this.Movement_Box.Controls.Add(this.Movement_Button_West);
			this.Movement_Box.Controls.Add(this.Movement_Button_South);
			this.Movement_Box.Location = new System.Drawing.Point(160, 10);
			this.Movement_Box.Name = "Movement_Box";
			this.Movement_Box.Size = new System.Drawing.Size(311, 157);
			this.Movement_Box.TabIndex = 7;
			this.Movement_Box.TabStop = false;
			this.Movement_Box.Text = "Actions";
			// 
			// Combat_Button_Attack
			// 
			this.Combat_Button_Attack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Combat_Button_Attack.Location = new System.Drawing.Point(223, 25);
			this.Combat_Button_Attack.Margin = new System.Windows.Forms.Padding(5);
			this.Combat_Button_Attack.Name = "Combat_Button_Attack";
			this.Combat_Button_Attack.Size = new System.Drawing.Size(80, 30);
			this.Combat_Button_Attack.TabIndex = 7;
			this.Combat_Button_Attack.Text = "&Attack";
			this.Combat_Button_Attack.UseVisualStyleBackColor = true;
			this.Combat_Button_Attack.EnabledChanged += new System.EventHandler(this.UI_SyncObjectVisibility);
			this.Combat_Button_Attack.Click += new System.EventHandler(this.Combat_Button_Attack_Click);
			// 
			// Combat_Box
			// 
			this.Combat_Box.Controls.Add(this.Combat_Label_Enemy);
			this.Combat_Box.Controls.Add(this.Combat_Label_Player);
			this.Combat_Box.Controls.Add(this.Combat_Bar_Enemy);
			this.Combat_Box.Controls.Add(this.Combat_Bar_Player);
			this.Combat_Box.Controls.Add(this.Combat_Button_Attack);
			this.Combat_Box.Location = new System.Drawing.Point(160, 170);
			this.Combat_Box.Name = "Combat_Box";
			this.Combat_Box.Size = new System.Drawing.Size(311, 107);
			this.Combat_Box.TabIndex = 10;
			this.Combat_Box.TabStop = false;
			this.Combat_Box.Text = "Combat";
			// 
			// Combat_Label_Enemy
			// 
			this.Combat_Label_Enemy.AutoSize = true;
			this.Combat_Label_Enemy.Location = new System.Drawing.Point(8, 64);
			this.Combat_Label_Enemy.Name = "Combat_Label_Enemy";
			this.Combat_Label_Enemy.Size = new System.Drawing.Size(39, 13);
			this.Combat_Label_Enemy.TabIndex = 11;
			this.Combat_Label_Enemy.Text = "Enemy";
			this.Combat_Label_Enemy.EnabledChanged += new System.EventHandler(this.UI_SyncObjectVisibility);
			// 
			// Combat_Label_Player
			// 
			this.Combat_Label_Player.AutoSize = true;
			this.Combat_Label_Player.Location = new System.Drawing.Point(8, 23);
			this.Combat_Label_Player.Name = "Combat_Label_Player";
			this.Combat_Label_Player.Size = new System.Drawing.Size(26, 13);
			this.Combat_Label_Player.TabIndex = 10;
			this.Combat_Label_Player.Text = "You";
			this.Combat_Label_Player.EnabledChanged += new System.EventHandler(this.UI_SyncObjectVisibility);
			// 
			// Combat_Bar_Enemy
			// 
			this.Combat_Bar_Enemy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Combat_Bar_Enemy.Location = new System.Drawing.Point(8, 81);
			this.Combat_Bar_Enemy.Maximum = 10;
			this.Combat_Bar_Enemy.Name = "Combat_Bar_Enemy";
			this.Combat_Bar_Enemy.Size = new System.Drawing.Size(180, 13);
			this.Combat_Bar_Enemy.Step = 1;
			this.Combat_Bar_Enemy.TabIndex = 9;
			this.Combat_Bar_Enemy.Value = 7;
			this.Combat_Bar_Enemy.EnabledChanged += new System.EventHandler(this.UI_SyncObjectVisibility);
			// 
			// Combat_Bar_Player
			// 
			this.Combat_Bar_Player.Location = new System.Drawing.Point(8, 40);
			this.Combat_Bar_Player.Maximum = 10;
			this.Combat_Bar_Player.Name = "Combat_Bar_Player";
			this.Combat_Bar_Player.Size = new System.Drawing.Size(180, 13);
			this.Combat_Bar_Player.Step = 1;
			this.Combat_Bar_Player.TabIndex = 8;
			this.Combat_Bar_Player.Value = 7;
			this.Combat_Bar_Player.EnabledChanged += new System.EventHandler(this.UI_SyncObjectVisibility);
			// 
			// Program_Window
			// 
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.Combat_Box);
			this.Controls.Add(this.Item_List_Label);
			this.Controls.Add(this.Message_Log_Window);
			this.Controls.Add(this.Item_Current_Description);
			this.Controls.Add(this.Message_Log_Label);
			this.Controls.Add(this.Item_Current_Label);
			this.Controls.Add(this.Item_List);
			this.Controls.Add(this.Movement_Box);
			this.Name = "Program_Window";
			this.Text = "AdventureGame";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Movement_Box.ResumeLayout(false);
			this.Combat_Box.ResumeLayout(false);
			this.Combat_Box.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListBox Item_List;
		private System.Windows.Forms.Label Item_Current_Label;
		private System.Windows.Forms.Label Message_Log_Label;
		private System.Windows.Forms.Label Item_Current_Description;
		private System.Windows.Forms.Label Message_Log_Window;
		private System.Windows.Forms.Label Item_List_Label;
		private System.Windows.Forms.Button Movement_Button_West;
		private System.Windows.Forms.Button Movement_Button_South;
		private System.Windows.Forms.Button Movement_Button_East;
		private System.Windows.Forms.Button Movement_Button_North;
		private System.Windows.Forms.GroupBox Movement_Box;
		private System.Windows.Forms.Button Combat_Button_Attack;
		private System.Windows.Forms.GroupBox Combat_Box;
		private System.Windows.Forms.ProgressBar Combat_Bar_Player;
		private System.Windows.Forms.Label Combat_Label_Enemy;
		private System.Windows.Forms.Label Combat_Label_Player;
		private System.Windows.Forms.ProgressBar Combat_Bar_Enemy;
	}
}

