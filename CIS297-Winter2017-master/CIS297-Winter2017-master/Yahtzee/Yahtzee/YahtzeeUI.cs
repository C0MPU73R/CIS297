using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
	public partial class YahtzeeUI : Form
	{
		private PictureBox[] dicePictureBoxes;
		private Bitmap[] dicePictures;
		private RandomNumberGenerator random;
		private YahtzeeDice dice;
		private YahtzeeScoreCard scoreCard;
		public YahtzeeUI()
		{
			InitializeComponent();
			random = new RandomNumberGenerator();

			dice = new YahtzeeDice( random );
			dice.Changed += new YahtzeeDice.ChangeHandler( UpdatePossibleScoreLabels );

			scoreCard = new YahtzeeScoreCard();

			dicePictureBoxes = new PictureBox[ 5 ]
			{
				die1PictureBox,
				die2PictureBox,
				die3PictureBox,
				die4PictureBox,
				die5PictureBox
			};
			dicePictures = new Bitmap[ 6 ]
			{
				Properties.Resources.die_01,
				Properties.Resources.die_02,
				Properties.Resources.die_03,
				Properties.Resources.die_04,
				Properties.Resources.die_05,
				Properties.Resources.die_06
			};
			setScoreButtons( false );
		}

		private void rollButton_Click( object sender, EventArgs e )
		{
			setScoreButtons( true );
			if ( dice.RollCount <= 2 )
			{
				dice.roll();
				for ( int index = 0; index < 5; index++ )
				{
					dicePictureBoxes[ index ].Image = dicePictures[ dice[ index ] - 1 ];
				}
			}
			if ( dice.RollCount == 3 )
			{
				RollButton.Enabled = false;
			}
		}

		private void scoreOnesButton_Click( object sender, EventArgs e )
		{
			scoreCard.Ones = dice.getPossibleScores().Ones;
			scoreOnesButton.Visible = false;
			resetRolls();
		}

		private void scoreTwosButton_Click( object sender, EventArgs e )
		{
			scoreCard.Twos = dice.getPossibleScores().Twos;
			scoreTwosButton.Visible = false;
			resetRolls();
		}

		private void scoresThreeButton_Click( object sender, EventArgs e )
		{
			scoreCard.Threes = dice.getPossibleScores().Threes;
			scoreThreeButton.Visible = false;
			resetRolls();
		}


		private void scoreFoursButton_Click( object sender, EventArgs e )
		{
			scoreCard.Fours = dice.getPossibleScores().Fours;
			scoreFoursButton.Visible = false;
			resetRolls();
		}

		private void scoreFivesButton_Click( object sender, EventArgs e )
		{
			scoreCard.Fives = dice.getPossibleScores().Fives;
			scoreFivesButton.Visible = false;
			resetRolls();
		}

		private void scoreSixesButton_Click( object sender, EventArgs e )
		{
			scoreCard.Sixes = dice.getPossibleScores().Sixes;
			scoreSixesButton.Visible = false;
			resetRolls();
		}

		private void scoreThreeOfAKindButton_Click( object sender, EventArgs e )
		{
			scoreCard.ThreeOfAKind = dice.getPossibleScores().ThreeOfAKind;
			scoreThreeOfAKindButton.Visible = false;
			resetRolls();
		}

		private void scoreFourOfAKindButton_Click( object sender, EventArgs e )
		{
			scoreCard.FourOfAKind = dice.getPossibleScores().FourOfAKind;
			scoreFourOfAKindButton.Visible = false;
			resetRolls();
		}

		private void scoreFullHouseButton_Click( object sender, EventArgs e )
		{
			scoreCard.FullHouse = dice.getPossibleScores().FullHouse;
			scoreFullHouseButton.Visible = false;
			resetRolls();
		}

		private void scoreSmallStraightButton_Click( object sender, EventArgs e )
		{
			scoreCard.SmallStraight = dice.getPossibleScores().SmallStraight;
			scoreSmallStraightButton.Visible = false;
			resetRolls();
		}

		private void scoreLargeStraightButton_Click( object sender, EventArgs e )
		{
			scoreCard.LargeStraight = dice.getPossibleScores().LargeStraight;
			scoreLargeStraightButton.Visible = false;
			resetRolls();
		}

		private void scoreYahtzeeButton_Click( object sender, EventArgs e )
		{
			scoreCard.Yahtzee = dice.getPossibleScores().Yahtzee;
			scoreYahtzeeButton.Visible = false;
			resetRolls();
		}

		private void scoreChanceButton_Click( object sender, EventArgs e )
		{
			scoreCard.Chance = dice.getPossibleScores().Chance;
			scoreChanceButton.Visible = false;
			resetRolls();
		}

		private void resetRolls()
		{
			UpdateScoreCard();
			if ( scoreOnesButton.Visible || scoreTwosButton.Visible || scoreThreeButton.Visible || scoreFoursButton.Visible || scoreFivesButton.Visible || scoreSixesButton.Visible
				|| scoreThreeOfAKindButton.Visible || scoreFourOfAKindButton.Visible || scoreSmallStraightButton.Visible || scoreLargeStraightButton.Visible || scoreYahtzeeButton.Visible || scoreChanceButton.Visible )
			{
				RollButton.Enabled = true;
			}
			else
			{
				RollButton.Text = "GAME OVER!";
				RollButton.Enabled = false;
			}
			foreach ( PictureBox dicePicture in dicePictureBoxes )
			{
				dicePicture.Image = null;
			}
			dice.Changed -= UpdatePossibleScoreLabels;
			dice = new YahtzeeDice( random );
			dice.Changed += new YahtzeeDice.ChangeHandler( UpdatePossibleScoreLabels );
			dieOneHolding.Text = "";
			dieTwoHolding.Text = "";
			dieThreeHolding.Text = "";
			dieFourHolding.Text = "";
			dieFiveHolding.Text = "";
			setScoreButtons( false );
		}

		private void setScoreButtons( bool enabled )
		{
			scoreOnesButton.Enabled = enabled;
			scoreTwosButton.Enabled = enabled;
			scoreThreeButton.Enabled = enabled;
			scoreFoursButton.Enabled = enabled;
			scoreFivesButton.Enabled = enabled;
			scoreSixesButton.Enabled = enabled;
			scoreThreeOfAKindButton.Enabled = enabled;
			scoreFourOfAKindButton.Enabled = enabled;
			scoreFullHouseButton.Enabled = enabled;
			scoreSmallStraightButton.Enabled = enabled;
			scoreLargeStraightButton.Enabled = enabled;
			scoreYahtzeeButton.Enabled = enabled;
			scoreChanceButton.Enabled = enabled;
		}

		private void die1PictureBox_Click( object sender, EventArgs e )
		{
			if ( dice.RollDie1 )
			{
				dice.RollDie1 = false;
				dieOneHolding.Text = "Holding";
			}
			else
			{
				dice.RollDie1 = true;
				dieOneHolding.Text = "";
			}
		}

		private void die2PictureBox_Click( object sender, EventArgs e )
		{
			if ( dice.RollDie2 )
			{
				dice.RollDie2 = false;
				dieTwoHolding.Text = "Holding";
			}
			else
			{
				dice.RollDie2 = true;
				dieTwoHolding.Text = "";
			}
		}

		private void die3PictureBox_Click( object sender, EventArgs e )
		{
			if ( dice.RollDie3 )
			{
				dice.RollDie3 = false;
				dieThreeHolding.Text = "Holding";
			}
			else
			{
				dice.RollDie3 = true;
				dieThreeHolding.Text = "";
			}
		}

		private void die4PictureBox_Click( object sender, EventArgs e )
		{
			if ( dice.RollDie4 )
			{
				dice.RollDie4 = false;
				dieFourHolding.Text = "Holding";
			}
			else
			{
				dice.RollDie4 = true;
				dieFourHolding.Text = "";
			}
		}

		private void die5PictureBox_Click( object sender, EventArgs e )
		{
			if ( dice.RollDie5 )
			{
				dice.RollDie5 = false;
				dieFiveHolding.Text = "Holding";
			}
			else
			{
				dice.RollDie5 = true;
				dieFiveHolding.Text = "";
			}
		}

		private void UpdatePossibleScoreLabels( YahtzeeDice dice )
		{
			if ( scoreOnesButton.Visible )
			{
				onesScoreLabel.Text = dice.getPossibleScores().Ones.ToString();
			}
			if ( scoreTwosButton.Visible )
			{
				twosScoreLabel.Text = dice.getPossibleScores().Twos.ToString();
			}
			if ( scoreThreeButton.Visible )
			{
				threesScoreLabel.Text = dice.getPossibleScores().Threes.ToString();
			}
			if ( scoreFoursButton.Visible )
			{
				foursScoreLabel.Text = dice.getPossibleScores().Fours.ToString();
			}
			if ( scoreFivesButton.Visible )
			{
				fivesScoreLabel.Text = dice.getPossibleScores().Fives.ToString();
			}
			if ( scoreSixesButton.Visible )
			{
				sixesScoreLabel.Text = dice.getPossibleScores().Sixes.ToString();
			}

			if ( scoreThreeOfAKindButton.Visible )
			{
				threeOfAKindScoreLabel.Text = dice.getPossibleScores().ThreeOfAKind.ToString();
			}
			if ( scoreFourOfAKindButton.Visible )
			{
				fourOfAKindScoreLabel.Text = dice.getPossibleScores().FourOfAKind.ToString();
			}
			if ( scoreFullHouseButton.Visible )
			{
				fullHouseScoreLabel.Text = dice.getPossibleScores().FullHouse.ToString();
			}
			if ( scoreSmallStraightButton.Visible )
			{
				smallStraightScoreLabel.Text = dice.getPossibleScores().SmallStraight.ToString();
			}
			if ( scoreLargeStraightButton.Visible )
			{
				largeStraightScoreLabel.Text = dice.getPossibleScores().LargeStraight.ToString();
			}
			if ( scoreYahtzeeButton.Visible )
			{
				yahtzeeScoreLabel.Text = dice.getPossibleScores().Yahtzee.ToString();
			}
			if ( scoreChanceButton.Visible )
			{
				chanceScoreLabel.Text = dice.getPossibleScores().Chance.ToString();
			}
		}

		private void UpdateScoreCard()
		{
			onesScoreLabel.Text = scoreCard.Ones.ToString();
			twosScoreLabel.Text = scoreCard.Twos.ToString();
			threesScoreLabel.Text = scoreCard.Threes.ToString();
			foursScoreLabel.Text = scoreCard.Fours.ToString();
			fivesScoreLabel.Text = scoreCard.Fives.ToString();
			sixesScoreLabel.Text = scoreCard.Sixes.ToString();
			bonusScoreLabel.Text = scoreCard.Bonus.ToString();

			threeOfAKindScoreLabel.Text = scoreCard.ThreeOfAKind.ToString();
			fourOfAKindScoreLabel.Text = scoreCard.FourOfAKind.ToString();
			fullHouseScoreLabel.Text = scoreCard.FullHouse.ToString();
			smallStraightScoreLabel.Text = scoreCard.SmallStraight.ToString();
			largeStraightScoreLabel.Text = scoreCard.LargeStraight.ToString();
			yahtzeeScoreLabel.Text = scoreCard.Yahtzee.ToString();
			chanceScoreLabel.Text = scoreCard.Chance.ToString();
			
			upperScoreLabel.Text = scoreCard.UpperTotal.ToString();
			lowerScoreLabel.Text = scoreCard.LowerTotal.ToString();
			grandTotalScoreLabel.Text = scoreCard.GrandTotal.ToString();
		}
	}
}
