/*
Author: Nicholas Cleveland
Creation date: 01/21/17
Last modification date: 01/23/17
*/
#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace YahtzeeGame
{
    public partial class Form1 : Form
    {
        #region Declaration of attributes

        private Image[] arrayOfDiceFaceImages;
        private int[] arrayOfDiceInts;
        private int[] amountOfEachDie;
        private int[] numberOfEachDie;
        private Random random;
        private int maxNumberOfRolls = 0;
        private int totalSum = 0;
        private bool CanRollDie1;
        private bool CanRollDie2;
        private bool CanRollDie3;
        private bool CanRollDie4;
        private bool CanRollDie5;
        private bool canApplyOnesPoints;
        private bool canApplyTwosPoints;
        private bool canApplyThreesPoints;
        private bool canApplyFoursPoints;
        private bool canApplyFivesPoints;
        private bool canApplySixesPoints;
        private bool canApplyToakPoints;
        private bool canApply4oakPoints;
        private bool canApplyFullHousePoints;
        private bool canApplySmallStraightPoints;
        private bool canApplyLargeStraightPoints;
        private bool canApplyYahtzeePoints;
        private bool canApplyChancePoints;
        //private bool haveOne;
        //private bool haveTwo;
        //private bool haveThree;
        //private bool haveFour;
        //private bool haveFive;
        //private bool haveSix;

        private bool newGame;



        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arrayOfDiceInts = new int[5];
            amountOfEachDie = new int[6];
            arrayOfDiceFaceImages = new Image[7];
           

            for (int index = 0; index < arrayOfDiceInts.Length; index++)
            {
                arrayOfDiceInts[index] = 0;
            }
            for (int index = 0; index < amountOfEachDie.Length; index++)
            {
                amountOfEachDie[index] = 0;
            }

            arrayOfDiceFaceImages[0] = Properties.Resources.die_reset;
            arrayOfDiceFaceImages[1] = Properties.Resources.die1;
            arrayOfDiceFaceImages[2] = Properties.Resources.die2;
            arrayOfDiceFaceImages[3] = Properties.Resources.die3;
            arrayOfDiceFaceImages[4] = Properties.Resources.die4;
            arrayOfDiceFaceImages[5] = Properties.Resources.die5;
            arrayOfDiceFaceImages[6] = Properties.Resources.die6;

            CanRollDie1 = true;
            CanRollDie2 = true;
            CanRollDie3 = true;
            CanRollDie4 = true;
            CanRollDie5 = true;


            canApplyOnesPoints = true;
            canApplyTwosPoints = true;
            canApplyThreesPoints = true;
            canApplyFoursPoints = true;
            canApplyFivesPoints = true;
            canApplySixesPoints = true;
            canApplyToakPoints = true;
            canApply4oakPoints = true;
            canApplyFullHousePoints = true;
            canApplySmallStraightPoints = true;
            canApplyLargeStraightPoints = true;
            canApplyYahtzeePoints = true;
            canApplyChancePoints = true;





        newGame = false;



        //haveOne = false;
        //haveTwo = false;
        //haveThree = false;
        //haveFour = false;
        //haveFive = false;
        //haveSix = false;


        random = new Random();
        }

        private void roll_the_dice_button_Click(object sender, EventArgs e)
        {
           // if (maxNumberOfRolls < 3)
           // {
                rollTheDice();
                calculateOnes();
                calculateTwos();
                calculateThrees();
                calculateFours();
                calculateFives();
                calculateSixes();
            calculateThreeOfAKind();
            calculateFourOfAKind();
            calculateFullHouse();
            calculateSmallStraight();
            calculateLargeStraight();


           // }
            maxNumberOfRolls++;
          //  if (maxNumberOfRolls == 3)
           // {
             //   roll_the_dice_button.Enabled = false;
          //  }
        }

        private void rollTheDice() //TODO: Amount does not reset after each roll
        {
            for (int index = 0; index < amountOfEachDie.Length; index++)
            {
                amountOfEachDie[index] = 0; //TODO: put reset somewhere else
            }
           

                if (CanRollDie1== true)
                {
                    arrayOfDiceInts[0] = random.Next(1, 7); //generate a random number between 1 nad 6 for each die
                  //  haveCheck(arrayOfDiceInts[0]);
                
                }
                if (CanRollDie2 == true)
                {
                    arrayOfDiceInts[1] = random.Next(1, 7); //generate a random number between 1 nad 6 for each die
                  //  haveCheck(arrayOfDiceInts[1]);

            }
            if (CanRollDie3 == true)
                {
                    arrayOfDiceInts[2] = random.Next(1, 7); //generate a random number between 1 nad 6 for each die
                  //  haveCheck(arrayOfDiceInts[2]);

            }
            if (CanRollDie4 == true)
                {
                    arrayOfDiceInts[3] = random.Next(1, 7); //generate a random number between 1 nad 6 for each die
                  //  haveCheck(arrayOfDiceInts[3]);

            }
            if (CanRollDie5 == true)
                {
                    arrayOfDiceInts[4] = random.Next(1, 7); //generate a random number between 1 nad 6 for each die
                 //  haveCheck(arrayOfDiceInts[4]);

            }

            for (int index = 0; index < arrayOfDiceInts.Length; index++)
            {

                if (arrayOfDiceInts[index] == 1) //if we get a one
                {
                    amountOfEachDie[0]++; //increase number of ones by one
                }
                else if (arrayOfDiceInts[index] == 2) //if we get a two etc...
                {
                    amountOfEachDie[1]++; //increase number of twos by 1 etc...

                }
                else if (arrayOfDiceInts[index] == 3) 
                {
                    amountOfEachDie[2]++;

                }
                else if (arrayOfDiceInts[index] == 4)
                {
                    amountOfEachDie[3]++;

                }
                else if (arrayOfDiceInts[index] == 5)
                {
                    amountOfEachDie[4]++;

                }
                else if (arrayOfDiceInts[index] == 6)
                {
                    amountOfEachDie[5]++;

                }
            }
            //give each die int a corresponding image
            die_1_label.Image = arrayOfDiceFaceImages[arrayOfDiceInts[0]];
            die_2_label.Image = arrayOfDiceFaceImages[arrayOfDiceInts[1]];
            die_3_label.Image = arrayOfDiceFaceImages[arrayOfDiceInts[2]];
            die_4_label.Image = arrayOfDiceFaceImages[arrayOfDiceInts[3]];
            die_5_label.Image = arrayOfDiceFaceImages[arrayOfDiceInts[4]];
        }

        private int calculateOnes()
        {
            int sum = 0;
            if (canApplyOnesPoints == true)
            {
               
                sum = amountOfEachDie[0] * 1;
                ones_points.Text = sum.ToString();
               
            }
            return sum;
        }

        private int calculateTwos()
        {
            int sum = 0;
            if (canApplyTwosPoints == true)
            {
                sum = amountOfEachDie[1] * 2;
                twos_points.Text = sum.ToString();
            }
            return sum;
        }

        private int calculateThrees()
        {
            int sum = 0;

            if (canApplyThreesPoints == true)
            {
                sum = amountOfEachDie[2] * 3;
                threes_points.Text = sum.ToString();
            }
            return sum;
        }

        private int calculateFours()
        {
            int sum = 0;
            if (canApplyFoursPoints == true)
            {
                sum = amountOfEachDie[3] * 4;
                fours_points.Text = sum.ToString();
            }
            return sum;
        }

        private int calculateFives()
        {
            int sum = 0;
            if (canApplyFivesPoints == true)
            {
                sum = amountOfEachDie[4] * 5;
                fives_points.Text = sum.ToString();
            }
            return sum;
        }

        private int calculateSixes()
        {
            int sum = 0;
            if (canApplySixesPoints == true)
            {
                sum = amountOfEachDie[5] * 6;
                sixes_points.Text = sum.ToString();
            }
            return sum;
        }

        private int calculateThreeOfAKind()
        {
            int sum = 0;
            if (canApplyToakPoints == true)
            {
                for (int index = 0; index < arrayOfDiceInts.Length; index++)
                {
                    if (amountOfEachDie[index] == 3)
                    {
                        for (int index2 = 0; index2 < arrayOfDiceInts.Length; index2++)
                        {
                            sum += arrayOfDiceInts[index];
                        }
                    }


                }
                three_of_a_kind_points.Text = sum.ToString();
            }
            return sum;
        }

        private int calculateFourOfAKind()
        {
            int sum = 0;
            if (canApply4oakPoints == true)
            {
                for (int index = 0; index < arrayOfDiceInts.Length; index++)
                {
                    if (amountOfEachDie[index] == 4)
                    {
                        for (int index2 = 0; index2 < arrayOfDiceInts.Length; index2++)
                        {
                            sum += arrayOfDiceInts[index];
                        }
                    }


                }
                four_of_a_kind_points.Text = sum.ToString();
            }
            return sum;
        }


        private int calculateFullHouse()
        {
            int sum = 0;
            if (canApplyFullHousePoints == true)
            {
                for (int index = 0; index < arrayOfDiceInts.Length; index++)
                {
                    if (amountOfEachDie[index] == 2 && amountOfEachDie[index] == 3)
                    {
                        sum = 25;
                    }

                }
                full_house_points.Text = sum.ToString();
            }
            return sum;
        }

        private int calculateSmallStraight()
        {
            int sum = 0;
            if (canApplySmallStraightPoints == true)
            {
                for (int index = 0; index < arrayOfDiceInts.Length; index++)
                {
                    // if ((haveOne && haveTwo && haveThree && haveFour) || (haveTwo && haveThree && haveFour && haveFive) || (haveThree && haveFour && haveFive && haveSix))
                    if((amountOfEachDie[0] == 1 && amountOfEachDie[1] == 1 && amountOfEachDie[2] == 1 && amountOfEachDie[3] == 1) || (amountOfEachDie[1] == 1 && amountOfEachDie[2] == 1 && amountOfEachDie[3] == 1 && amountOfEachDie[4] == 1) || (amountOfEachDie[2] == 1 && amountOfEachDie[3] == 1 && amountOfEachDie[4] == 1 && amountOfEachDie[5] == 1))
                    {
                        sum = 30;
                    }
                }
                small_straight_points.Text = sum.ToString();
            }
            return sum;
        }

        private int calculateLargeStraight()
        {
            int sum = 0;
            if (canApplyLargeStraightPoints == true)
            {
                for (int index = 0; index < arrayOfDiceInts.Length; index++)
                {
                    //  if ((haveOne && haveTwo && haveThree && haveFour && haveFive) || (haveTwo && haveThree && haveFour && haveFive && haveSix))
                    if ((amountOfEachDie[0] == 1 && amountOfEachDie[1] == 1 && amountOfEachDie[2] == 1 && amountOfEachDie[3] == 1 && amountOfEachDie[4] ==1) ||(amountOfEachDie[1] == 1 && amountOfEachDie[2] == 1 && amountOfEachDie[3] == 1 && amountOfEachDie[4] == 1 && amountOfEachDie[5] == 1))
                      {
                        sum = 40;
                    }
                }
            }
            large_straight_points.Text = sum.ToString();
            return sum;
        }

        private int calculateChance()
        {
            return 0;
        }

        private int calculateYahtzee()
        {
            return 0;
        }

        private int getTotalSum()
        {
            return 0;
        }

       


        private void keep_button_1_Click(object sender, EventArgs e)
        {
            CanRollDie1 = false;
            keep_button_1.Enabled = false;
        }
        private void keep_button_2_Click(object sender, EventArgs e)
        {
            CanRollDie2 = false;
            keep_button_2.Enabled = false;
        }

        private void keep_button_3_Click(object sender, EventArgs e)
        {
            CanRollDie3 = false;
            keep_button_3.Enabled = false;

        }

        private void keep_button_4_Click(object sender, EventArgs e)
        {
            CanRollDie4 = false;
            keep_button_4.Enabled = false;

        }
        private void keep_button_5_Click(object sender, EventArgs e)
        {
            CanRollDie5 = false;
            keep_button_5.Enabled = false;

        }

        private void apply_ones_button_Click(object sender, EventArgs e)
        {

            totalSum += calculateOnes();

            apply_ones_button.Enabled = false;
            ones_points.Enabled = false;
            canApplyOnesPoints = false;
        }

        private void apply_twos_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateTwos();

            apply_twos_button.Enabled = false;
            twos_points.Enabled = false;
            canApplyTwosPoints = false;


        }

        private void apply_threes_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateThrees();

            apply_threes_button.Enabled = false;
            threes_points.Enabled = false;
            canApplyThreesPoints = false;


        }

        private void apply_fours_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateFours();

            apply_fours_button.Enabled = false;
            fours_points.Enabled = false;
            canApplyFoursPoints = false;


        }

        private void apply_fives_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateFives();

            apply_fives_button.Enabled = false;
            fives_points.Enabled = false;
            canApplyFivesPoints = false;


        }

        private void apply_sixes_button_Click(object sender, EventArgs e)
        {

            totalSum += calculateSixes();

            apply_sixes_button.Enabled = false;
            sixes_points.Enabled = false;
            canApplySixesPoints = false;


        }

        private void apply_toak_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateThreeOfAKind();
            apply_toak_button.Enabled = false;
            canApplyToakPoints = false;
        }

        private void apply_4oak_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateFourOfAKind();
            apply_4oak_button.Enabled = false;
            canApply4oakPoints = false;
        }

        private void apply_full_house_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateFullHouse();
            apply_full_house_button.Enabled = false;
            canApplyFullHousePoints = false;
        }

        private void apply_small_straight_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateSmallStraight();
            apply_small_straight_button.Enabled = false;
            canApplySmallStraightPoints = false;
        }

        private void apply_large_straight_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateLargeStraight();
            apply_large_straight_button.Enabled = false;
            canApplyLargeStraightPoints = false;
        }

        private void apply_chance_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateChance();
            apply_chance_button.Enabled = false;
            canApplyChancePoints = false;
        }

        private void apply_yahtzee_button_Click(object sender, EventArgs e)
        {
            totalSum += calculateYahtzee();
            apply_yahtzee_button.Enabled = false;
            canApplyYahtzeePoints = false;
        }


        private void threes_points_Click(object sender, EventArgs e)
        {

        }

        private void fives_points_Click(object sender, EventArgs e)
        {

        }

        private void four_of_a_kind_points_Click(object sender, EventArgs e)
        {

        }

        private void sum_button_Click(object sender, EventArgs e)
        {
            sum_points.Text = totalSum.ToString();
        }


       

        private void yes_button_Click(object sender, EventArgs e)
        {
            newGame = true;
            yes_button.Enabled = false;
            new_game_label.Enabled = false;
        }

        private void no_button_Click(object sender, EventArgs e)
        {
            no_button.Enabled = false;
            new_game_label.Enabled = false;
        }


        //private void haveCheck(int number)
        //{
        //    if(number == 1)
        //    {
        //        haveOne = true;
        //    }
        //    else if (number == 2)
        //    {
        //        haveTwo = true;
        //    }
        //    else if (number == 3)
        //    {
        //        haveThree = true;
        //    }
        //    else if (number == 4)
        //    {
        //        haveFour = true;
        //    }
        //    else if (number == 5)
        //    {
        //        haveFive = true;
        //    }
        //    else if (number == 6)
        //    {
        //        haveSix = true;
        //    }
        //}




    }

}


   




/*
#region Declaration

Image[] arrayOfDiceFaces;
int[] diceInts;
int[] diceResult;
Random random;

#endregion

#region Initialization

public Form1()
{
InitializeComponent();
}

private void Form1_Load(object sender, EventArgs e)
{
arrayOfDiceFaces = new Image[7];
arrayOfDiceFaces[0] = Properties.Resources.die_reset;
arrayOfDiceFaces[1] = Properties.Resources.die1;
arrayOfDiceFaces[2] = Properties.Resources.die2;
arrayOfDiceFaces[3] = Properties.Resources.die3;
arrayOfDiceFaces[4] = Properties.Resources.die4;
arrayOfDiceFaces[5] = Properties.Resources.die5;
arrayOfDiceFaces[6] = Properties.Resources.die6;
diceInts = new int[5] {0, 0, 0, 0, 0};
diceResult = new int[6] {0, 0, 0, 0, 0, 0};
random = new Random();
}

#endregion

#region Private Methods

private void roll_the_dice_button_Click(object sender, EventArgs e)
{
RollTheDice();
getResults();
resetResults();

}

private void RollTheDice()
{
for (int index = 0; index < diceInts.Length; index++)
{
    diceInts[index] = random.Next(1, 7);


    switch (diceInts[index])
    {
        case 1:
            diceResult[0]++;
            break;
        case 2:
            diceResult[1]++;
            break;
        case 3:
            diceResult[2]++;
            break;
        case 4:
            diceResult[3]++;
            break;
        case 5:
            diceResult[4]++;
            break;
        case 6:
            diceResult[5]++;
            break;

    }
}




die_1_label.Image = arrayOfDiceFaces[diceInts[0]];
die_2_label.Image = arrayOfDiceFaces[diceInts[1]];
die_3_label.Image = arrayOfDiceFaces[diceInts[2]];
die_4_label.Image = arrayOfDiceFaces[diceInts[3]];
die_5_label.Image = arrayOfDiceFaces[diceInts[4]];



}

private void getResults()
{
bool threeOfAKind = false;
bool fourOfAKind = false;
bool fullHouse = false;
bool smallStraight = false;
bool largeStraight = false;
bool YAHTZEE = false;
bool chance = false;
bool haveAOne = false;
bool haveATwo = false;
bool haveAThree = false;
bool haveAFour = false;
bool haveAFive = false;
bool haveASix = false;

for (int index = 0; index < diceResult.Length; index++)
{
    if (diceResult[index] == 5)
    {
        YAHTZEE = true;
    }
    if (diceResult[index] == 4)
    {
        fourOfAKind = true;
    }
    if (diceResult[index] == 3)
    {
        threeOfAKind = true;
        for (int index2 = 0; index2 < diceResult.Length; index2++)
        {
            if (diceResult[index2] == 2)
            {
                fullHouse = true;
            }
        }
    }

    if ((diceResult[0] == 1 && diceResult[1] == 1 && diceResult[2] == 1
         && diceResult[3] == 1) || (diceResult[1] == 1 && diceResult[2] == 1
                                    && diceResult[3] == 1 && diceResult[4] == 1) || (diceResult[2] == 1
                                                                                     && diceResult[3] == 1 &&
                                                                                     diceResult[4] == 1 &&
                                                                                     diceResult[5] == 1))
    {
        smallStraight = true;
    }


    if ((diceResult[1] == 1 && diceResult[2] == 1 && diceResult[3] == 1
         && diceResult[4] == 1 && diceResult[5] == 1) ||
        (diceResult[0] == 1 && diceResult[1] == 1 && diceResult[2] == 1
         && diceResult[3] == 1 && diceResult[4] == 1))
    {
        largeStraight = true;
    }
}

for (int index3 = 0; index3 < diceInts.Length; index3++)
{
    switch (diceInts[index3])
    {
        case 1:
            haveAOne = true;
            break;
        case 2:
            haveATwo = true;
            break;
        case 3:
            haveAThree = true;
            break;
        case 4:
            haveAFour = true;
            break;
        case 5:
            haveAFive = true;
            break;
        case 6:
            haveASix = true;
            break;
    }
}
}



private void resetResults()
{



}


#endregion

private void keep_button_1_Click(object sender, EventArgs e)
{
keep_button_1.Enabled = false;
}
private void keep_button_2_Click(object sender, EventArgs e)
{
keep_button_2.Enabled = false;
}

private void keep_button_3_Click(object sender, EventArgs e)
{
keep_button_3.Enabled = false;

}

private void keep_button_4_Click(object sender, EventArgs e)
{
keep_button_4.Enabled = false;

}
private void keep_button_5_Click(object sender, EventArgs e)
{
keep_button_5.Enabled = false;

}

private void apply_ones_button_Click(object sender, EventArgs e)
{
apply_ones_button.Enabled = false;
}

private void apply_twos_button_Click(object sender, EventArgs e)
{
apply_twos_button.Enabled = false;
}

private void apply_threes_button_Click(object sender, EventArgs e)
{
apply_threes_button.Enabled = false;
}

private void apply_fours_button_Click(object sender, EventArgs e)
{
apply_fours_button.Enabled = false;
}

private void apply_fives_button_Click(object sender, EventArgs e)
{
apply_fives_button.Enabled = false;
}

private void apply_sixes_button_Click(object sender, EventArgs e)
{
apply_sixes_button.Enabled = false;
}

private void apply_toak_button_Click(object sender, EventArgs e)
{
apply_toak_button.Enabled = false;
}

private void apply_4oak_button_Click(object sender, EventArgs e)
{
apply_4oak_button.Enabled = false;
}

private void apply_full_house_button_Click(object sender, EventArgs e)
{
apply_full_house_button.Enabled = false;
}

private void apply_small_straight_button_Click(object sender, EventArgs e)
{
apply_small_straight_button.Enabled = false;
}

private void apply_large_straight_button_Click(object sender, EventArgs e)
{
apply_large_straight_button.Enabled = false;
}

private void apply_chance_button_Click(object sender, EventArgs e)
{
apply_chance_button.Enabled = false;
}

private void apply_yahtzee_button_Click(object sender, EventArgs e)
{
apply_yahtzee_button.Enabled = false;
}

}

}
*/
