namespace BettingGame
{
    partial class Betting_Game_Dock
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
            this.play_poker_button = new System.Windows.Forms.Button();
            this.play_horse_racing_button = new System.Windows.Forms.Button();
            this.play_power_ball_button = new System.Windows.Forms.Button();
            this.poker_label = new System.Windows.Forms.Label();
            this.horse_racing_label = new System.Windows.Forms.Label();
            this.powerball_label = new System.Windows.Forms.Label();
            this.pick_a_game_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // play_poker_button
            // 
            this.play_poker_button.Location = new System.Drawing.Point(719, 188);
            this.play_poker_button.Name = "play_poker_button";
            this.play_poker_button.Size = new System.Drawing.Size(75, 23);
            this.play_poker_button.TabIndex = 0;
            this.play_poker_button.Text = "Play";
            this.play_poker_button.UseVisualStyleBackColor = true;
            this.play_poker_button.Click += new System.EventHandler(this.play_poker_button_Click);
            // 
            // play_horse_racing_button
            // 
            this.play_horse_racing_button.Location = new System.Drawing.Point(407, 188);
            this.play_horse_racing_button.Name = "play_horse_racing_button";
            this.play_horse_racing_button.Size = new System.Drawing.Size(75, 23);
            this.play_horse_racing_button.TabIndex = 1;
            this.play_horse_racing_button.Text = "Play";
            this.play_horse_racing_button.UseVisualStyleBackColor = true;
            this.play_horse_racing_button.Click += new System.EventHandler(this.play_horse_racing_button_Click);
            // 
            // play_power_ball_button
            // 
            this.play_power_ball_button.Location = new System.Drawing.Point(97, 188);
            this.play_power_ball_button.Name = "play_power_ball_button";
            this.play_power_ball_button.Size = new System.Drawing.Size(75, 23);
            this.play_power_ball_button.TabIndex = 2;
            this.play_power_ball_button.Text = "Play";
            this.play_power_ball_button.UseVisualStyleBackColor = true;
            this.play_power_ball_button.Click += new System.EventHandler(this.play_power_ball_button_Click);
            // 
            // poker_label
            // 
            this.poker_label.AutoSize = true;
            this.poker_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.poker_label.Location = new System.Drawing.Point(738, 161);
            this.poker_label.Name = "poker_label";
            this.poker_label.Size = new System.Drawing.Size(35, 13);
            this.poker_label.TabIndex = 3;
            this.poker_label.Text = "Poker";
            // 
            // horse_racing_label
            // 
            this.horse_racing_label.AutoSize = true;
            this.horse_racing_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.horse_racing_label.Location = new System.Drawing.Point(410, 161);
            this.horse_racing_label.Name = "horse_racing_label";
            this.horse_racing_label.Size = new System.Drawing.Size(72, 13);
            this.horse_racing_label.TabIndex = 4;
            this.horse_racing_label.Text = "Horse Racing";
            // 
            // powerball_label
            // 
            this.powerball_label.AutoSize = true;
            this.powerball_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.powerball_label.Location = new System.Drawing.Point(105, 161);
            this.powerball_label.Name = "powerball_label";
            this.powerball_label.Size = new System.Drawing.Size(53, 13);
            this.powerball_label.TabIndex = 5;
            this.powerball_label.Text = "Powerball";
            // 
            // pick_a_game_label
            // 
            this.pick_a_game_label.AutoSize = true;
            this.pick_a_game_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pick_a_game_label.Location = new System.Drawing.Point(410, 37);
            this.pick_a_game_label.Name = "pick_a_game_label";
            this.pick_a_game_label.Size = new System.Drawing.Size(66, 13);
            this.pick_a_game_label.TabIndex = 6;
            this.pick_a_game_label.Text = "Pick a game";
            // 
            // Betting_Game_Dock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(949, 437);
            this.Controls.Add(this.pick_a_game_label);
            this.Controls.Add(this.powerball_label);
            this.Controls.Add(this.horse_racing_label);
            this.Controls.Add(this.poker_label);
            this.Controls.Add(this.play_power_ball_button);
            this.Controls.Add(this.play_horse_racing_button);
            this.Controls.Add(this.play_poker_button);
            this.Name = "Betting_Game_Dock";
            this.Text = "Betting Game Dock";
            this.Load += new System.EventHandler(this.Betting_Game_Dock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_poker_button;
        private System.Windows.Forms.Button play_horse_racing_button;
        private System.Windows.Forms.Button play_power_ball_button;
        private System.Windows.Forms.Label poker_label;
        private System.Windows.Forms.Label horse_racing_label;
        private System.Windows.Forms.Label powerball_label;
        private System.Windows.Forms.Label pick_a_game_label;
    }
}

