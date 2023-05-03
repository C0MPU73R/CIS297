using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingGame
{
    public partial class Betting_Game_Dock : Form
    {
        public Betting_Game_Dock()
        {
            InitializeComponent();
        }

        private void Betting_Game_Dock_Load(object sender, EventArgs e)
        {

        }

        private void play_poker_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokerForm newPokerGame = new PokerForm();
            newPokerGame.FormClosed += (newObj, EVENT_ARGS_VAR) => this.Close();
            newPokerGame.Show();
        }

        private void play_horse_racing_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HorseRacingForm newHorseGame = new HorseRacingForm();
            newHorseGame.FormClosed += (newObj, EVENT_ARGS_VAR) => this.Close();
            newHorseGame.Show();
        }

        private void play_power_ball_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PowerballForm newPowerballGame = new PowerballForm();
            newPowerballGame.FormClosed += (newObj, EVENT_ARDS_VAR) => this.Close();
            newPowerballGame.Show();
        }
    }
}