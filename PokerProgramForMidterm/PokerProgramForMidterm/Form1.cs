using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerProgramForMidterm
{
    public partial class PokerGameForm : Form
    {
        private Image[,] arrayOfPokerImagesWithSuit;
        public PokerGameForm()
        {
            InitializeComponent();

            //note: 0 - back of car only,  cards 1-9 starts at twos (so card 1 is a two of...etc), 10 - jacks, 11 - queens, 12 - kings, 13 - aces (cards)
            // for suit, 0 - clubs, 1 - diamonds, 2 - hearts, 3 - spades


            arrayOfPokerImagesWithSuit = new Image[53,4];
            arrayOfPokerImagesWithSuit[0, 0] = Properties.Resources.back;
            arrayOfPokerImagesWithSuit[1, 0] = Properties.Resources._2_of_clubs;
            arrayOfPokerImagesWithSuit[1, 1] = Properties.Resources._2_of_diamonds;
            arrayOfPokerImagesWithSuit[1, 2] = Properties.Resources._2_of_hearts;
            arrayOfPokerImagesWithSuit[1, 3] = Properties.Resources._2_of_spades;
            arrayOfPokerImagesWithSuit[2, 0] = Properties.Resources._3_of_clubs;
            arrayOfPokerImagesWithSuit[2, 1] = Properties.Resources._3_of_diamonds;
            arrayOfPokerImagesWithSuit[2, 2] = Properties.Resources._3_of_hearts;
            arrayOfPokerImagesWithSuit[2, 3] = Properties.Resources._3_of_spades;
            arrayOfPokerImagesWithSuit[3, 0] = Properties.Resources._4_of_clubs;
            arrayOfPokerImagesWithSuit[3, 1] = Properties.Resources._4_of_diamonds;
            arrayOfPokerImagesWithSuit[3, 2] = Properties.Resources._4_of_hearts;
            arrayOfPokerImagesWithSuit[3, 3] = Properties.Resources._4_of_spades;
            arrayOfPokerImagesWithSuit[4, 0] = Properties.Resources._5_of_clubs;
            arrayOfPokerImagesWithSuit[4, 1] = Properties.Resources._5_of_diamonds;
            arrayOfPokerImagesWithSuit[4, 2] = Properties.Resources._5_of_hearts;
            arrayOfPokerImagesWithSuit[4, 3] = Properties.Resources._5_of_spades;
            arrayOfPokerImagesWithSuit[5, 0] = Properties.Resources._6_of_clubs;
            arrayOfPokerImagesWithSuit[5, 1] = Properties.Resources._6_of_diamonds;
            arrayOfPokerImagesWithSuit[5, 2] = Properties.Resources._6_of_hearts;
            arrayOfPokerImagesWithSuit[5, 3] = Properties.Resources._6_of_spades;
            arrayOfPokerImagesWithSuit[6, 0] = Properties.Resources._7_of_clubs;
            arrayOfPokerImagesWithSuit[6, 1] = Properties.Resources._7_of_diamonds;
            arrayOfPokerImagesWithSuit[6, 2] = Properties.Resources._7_of_hearts;
            arrayOfPokerImagesWithSuit[6, 3] = Properties.Resources._7_of_spades;
            arrayOfPokerImagesWithSuit[7, 0] = Properties.Resources._8_of_clubs;
            arrayOfPokerImagesWithSuit[7, 1] = Properties.Resources._8_of_diamonds;
            arrayOfPokerImagesWithSuit[7, 2] = Properties.Resources._8_of_hearts;
            arrayOfPokerImagesWithSuit[7, 3] = Properties.Resources._8_of_spades;
            arrayOfPokerImagesWithSuit[8, 0] = Properties.Resources._9_of_clubs;
            arrayOfPokerImagesWithSuit[8, 1] = Properties.Resources._9_of_diamonds;
            arrayOfPokerImagesWithSuit[8, 2] = Properties.Resources._9_of_hearts;
            arrayOfPokerImagesWithSuit[8, 3] = Properties.Resources._9_of_spades;
            arrayOfPokerImagesWithSuit[9, 0] = Properties.Resources._10_of_clubs;
            arrayOfPokerImagesWithSuit[9, 1] = Properties.Resources._10_of_diamonds;
            arrayOfPokerImagesWithSuit[9, 2] = Properties.Resources._10_of_hearts;
            arrayOfPokerImagesWithSuit[9, 3] = Properties.Resources._10_of_spades;
            arrayOfPokerImagesWithSuit[10, 0] = Properties.Resources.jack_of_clubs2;
            arrayOfPokerImagesWithSuit[10, 1] = Properties.Resources.jack_of_diamonds2;
            arrayOfPokerImagesWithSuit[10, 2] = Properties.Resources.jack_of_hearts2;
            arrayOfPokerImagesWithSuit[10, 3] = Properties.Resources.jack_of_spades2;
            arrayOfPokerImagesWithSuit[11, 0] = Properties.Resources.queen_of_clubs2;
            arrayOfPokerImagesWithSuit[11, 1] = Properties.Resources.queen_of_diamonds2;
            arrayOfPokerImagesWithSuit[11, 2] = Properties.Resources.queen_of_hearts2;
            arrayOfPokerImagesWithSuit[11, 3] = Properties.Resources.queen_of_spades2;
            arrayOfPokerImagesWithSuit[12, 0] = Properties.Resources.king_of_clubs2;
            arrayOfPokerImagesWithSuit[12, 1] = Properties.Resources.king_of_diamonds2;
            arrayOfPokerImagesWithSuit[12, 2] = Properties.Resources.king_of_hearts2;
            arrayOfPokerImagesWithSuit[12, 3] = Properties.Resources.king_of_spades2;
            arrayOfPokerImagesWithSuit[13, 0] = Properties.Resources.ace_of_clubs;
            arrayOfPokerImagesWithSuit[13, 1] = Properties.Resources.ace_of_diamonds;
            arrayOfPokerImagesWithSuit[13, 2] = Properties.Resources.ace_of_hearts;
            arrayOfPokerImagesWithSuit[13, 3] = Properties.Resources.ace_of_spades;


        }



      
        private void poker_game_form_Load(object sender, EventArgs e)
        {
           
        }


        private void raise_button_Click(object sender, EventArgs e)
        {

        }

        private void call_button_Click(object sender, EventArgs e)
        {

        }

        private void fold_button_Click(object sender, EventArgs e)
        {

        }

        private void leave_button_Click(object sender, EventArgs e)
        {
           

        }

        private void start_game_button_Click(object sender, EventArgs e)
        {
            startGame();

        }


        public void startGame()
        {
            // get all cards in deck
            //remove the 2 we have
            //remove the community cards
            //52 - 2 - 5 = 45 left
            //find my best hand of my 2 and the community cards
            //lets say found....
            //now look through the remaining 45 and find every possible combo of 2 (which are possible ai's hole cards)
            //then with every single combo of two find the best hand with that combo combined with the community cards

            List<Card> communityCards;
            Deck deck;
            communityCards = new List<Card>();
            deck = new Deck(new RandomNumberGenerator());
            for (int index = 0; index < 5; index++) // there are five community cards
            {
                communityCards.Add(deck.PickCard()); //picks first 5 random cards off top of deck
            }

            communityCard_Image_1.Image = arrayOfPokerImagesWithSuit[(int)communityCards[0].face,(int)communityCards[0].suit]; //has bugs. sometimes only 4 images will show
            communityCard_Image_2.Image = arrayOfPokerImagesWithSuit[(int)communityCards[1].face,(int)communityCards[1].suit];
            communityCard_Image_3.Image = arrayOfPokerImagesWithSuit[(int)communityCards[2].face,(int)communityCards[2].suit];
            communityCard_Image_4.Image = arrayOfPokerImagesWithSuit[(int)communityCards[3].face,(int)communityCards[3].suit];
            communityCard_Image_5.Image = arrayOfPokerImagesWithSuit[(int)communityCards[4].face,(int)communityCards[4].suit];



            //community cards are set for game
            //time to distribute hole cards to user and ai(who is permanent dealer)
            User user = new User(new HoleHand(deck)); // take 2 initial cards
            HoleHand usersHoleHand = user.getUsersHoleHand();
            List<Card> usersHoleHandInListForm = new List<Card>();
            userHand_Card1_Image.Image = arrayOfPokerImagesWithSuit[(int)usersHoleHand.Cards[0].face, (int)usersHoleHand.Cards[0].suit]; //error thrown


            AIUser user2 = new AIUser(new HoleHand(deck)); // take 2 initial cards
            user.addCommunityCards(communityCards); //let us have the community cards
            user2.addCommunityCards(communityCards); // let the ai have the community cards
        }

    }
}
