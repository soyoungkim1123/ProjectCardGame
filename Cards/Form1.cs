using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BOLayer;

namespace Cards
{
    public partial class Form1 : Form
    {
        Deck aDeck;
        Hand turnCards;

        List<Player> players;

        bool playerTurn;
        bool gameStart;
        bool playerWin;
        bool gameover;

        int playerValue;
        int user1Value;
        int user2Value;

        int currentTurn;
        int nextTurn;

        int numOfPlayer;
        int firstZero;

        #region set up start
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// set up start game
        /// </summary>
        private void SetUp()
        {
            try
            {
                aDeck = new Deck();
                aDeck.Shuffle();

                gameStart = false;
                gameover = false;
                playerTurn = false;

                lbChooseCard.Visible = true;
                panel_turnChoice.Visible = true;
                panel_turnChoice.Enabled = true;
                lbFirstCard.Visible = true;
                lbSecondCard.Visible = true;
                lbThirdCard.Visible = true;
                lbSystem.Visible = false;
                lbSystem.Text = "";
                lbUser1Name.Visible = false;
                lbUser2Name.Visible = false;
                lbPlayerName.Visible = false;
                txtPlayerName.Visible = false;
                PanelPlayer.Visible = false;
                PanelUser1.Visible = false;
                PanelUser2.Visible = false;
                btnEndTurn.Visible = false;
                btnRestart.Visible = false;
                lbFirstCard.Text = "";
                lbSecondCard.Text = "";
                lbThirdCard.Text = "";
                lbPlayerName.Text = string.Empty;
                lbUser1Name.Text = string.Empty;
                lbUser2Name.Text = string.Empty;
                txtPlayerName.Text = "Enter your name";
                lbChooseCard.Text = "Please choose a card!";
                PanelPlayer.Controls.Clear();
                PanelUser1.Controls.Clear();
                PanelUser2.Controls.Clear();

                players = new List<Player>();

                lbFirstCard.ForeColor = Color.Gray;
                lbSecondCard.ForeColor = Color.Gray;
                lbThirdCard.ForeColor = Color.Gray;

                btnStart.Visible = false;
                btnEndTurn.Enabled = false;

                numOfPlayer = 3;
                firstZero = 0;
                currentTurn = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JoinGame();
            this.Text = "Find Joker!";
        }

        /// <summary>
        /// initialize three players and show cards to decide users turn(3 cards from ace to 10)
        /// </summary>
        private void JoinGame()
        {
            SetUp();

            players.Add(new Player("Player", "Player", "front", 63, 90, 67, "Player"));
            players.Add(new Player("User1", "User1", "back", 47, 67, 50, "User1"));
            players.Add(new Player("User2", "User2", "back", 47, 67, 50, "User2"));

            turnCards = new Hand();
            List<int> valueList = new List<int>();
            Random rGen = new Random();

            while (turnCards.Count < 3)
            {
                int randomValue = rGen.Next(0, 9);

                if (valueList.Contains(randomValue))
                {
                    randomValue = rGen.Next(0, 9);
                }
                else
                {
                    valueList.Add(randomValue);
                    int randomSuit = rGen.Next(0, 3);
                    Card randomCard = new Card((Suit)randomSuit, (FaceValue)randomValue);
                    turnCards.AddCard(randomCard);
                }
            }
            ShowCard("panel_turnChoice", turnCards, "back", 141, 192, 200);
        }

        #endregion


        #region turn decision

        /// <summary>
        /// When player choose a card, turn will be decided based on the facevalue of cards
        /// </summary>
        /// <param name="cardPos"></param>
        private void Turn_Decision(int cardPos)
        {
            if (cardPos != -1)
            {
                lbFirstCard.Text = "";
                lbSecondCard.Text = "";
                lbThirdCard.Text = "";

                ShowCard("panel_turnChoice", turnCards, "front", 141, 192, 200);
                Random rGen = new Random();
                int randomValue;
                int[] nums = new int[] { 1, 2 };
                randomValue = nums[rGen.Next(nums.Length)];

                // display user's choice, decide computer's choice randomly
                if (cardPos == 0)
                {
                    lbFirstCard.Text = "You";
                    lbFirstCard.ForeColor = Color.Gold;
                    playerValue = Convert.ToInt32(turnCards[0].FaceValue);

                    if (randomValue == 1)
                    {
                        lbSecondCard.Text = "User1";
                        lbThirdCard.Text = "User2";
                        user1Value = Convert.ToInt32(turnCards[1].FaceValue);
                        user2Value = Convert.ToInt32(turnCards[2].FaceValue);
                    }

                    else
                    {
                        lbThirdCard.Text = "User1";
                        lbSecondCard.Text = "User2";
                        user1Value = Convert.ToInt32(turnCards[2].FaceValue);
                        user2Value = Convert.ToInt32(turnCards[1].FaceValue);
                    }
                }
                else if (cardPos == 1)
                {
                    lbSecondCard.Text = "You";
                    lbSecondCard.ForeColor = Color.Gold;
                    playerValue = Convert.ToInt32(turnCards[1].FaceValue);

                    if (randomValue == 1)
                    {
                        lbFirstCard.Text = "User1";
                        lbThirdCard.Text = "User2";
                        user1Value = Convert.ToInt32(turnCards[0].FaceValue);
                        user2Value = Convert.ToInt32(turnCards[2].FaceValue);
                    }

                    else
                    {
                        lbThirdCard.Text = "User1";
                        lbFirstCard.Text = "User2";
                        user1Value = Convert.ToInt32(turnCards[2].FaceValue);
                        user2Value = Convert.ToInt32(turnCards[0].FaceValue);
                    }
                }
                else if (cardPos == 2)
                {
                    lbThirdCard.Text = "You";
                    lbThirdCard.ForeColor = Color.Gold;
                    playerValue = Convert.ToInt32(turnCards[2].FaceValue);

                    if (randomValue == 1)
                    {
                        lbFirstCard.Text = "User1";
                        lbSecondCard.Text = "User2";
                        user1Value = Convert.ToInt32(turnCards[0].FaceValue);
                        user2Value = Convert.ToInt32(turnCards[1].FaceValue);
                    }

                    else
                    {
                        lbSecondCard.Text = "User1";
                        lbFirstCard.Text = "User2";
                        user1Value = Convert.ToInt32(turnCards[1].FaceValue);
                        user2Value = Convert.ToInt32(turnCards[0].FaceValue);
                    }
                }

                // display turn text
                if (turnCards[0].FaceValue < turnCards[1].FaceValue && turnCards[0].FaceValue < turnCards[2].FaceValue)
                {
                    lbFirstCard.Text += "\nFirst turn!";
                    if (turnCards[1].FaceValue < turnCards[2].FaceValue) lbSecondCard.Text += "\nSecond turn!"; // 0 -> 1 -> 2
                    else lbThirdCard.Text += "\nSecond turn!"; // else : 0 -> 2 -> 1
                }

                else if (turnCards[0].FaceValue > turnCards[1].FaceValue && turnCards[1].FaceValue < turnCards[2].FaceValue)
                {
                    lbSecondCard.Text += "\nFirst turn!";
                    if (turnCards[0].FaceValue < turnCards[2].FaceValue) lbFirstCard.Text += "\nSecond turn!"; //  1 -> 0 -> 2
                    else lbThirdCard.Text += "\nSecond turn!"; // else : 1 -> 2 -> 0
                }

                else if (turnCards[0].FaceValue > turnCards[2].FaceValue && turnCards[1].FaceValue > turnCards[2].FaceValue)
                {
                    lbThirdCard.Text += "\nFirst turn!";
                    if (turnCards[0].FaceValue < turnCards[1].FaceValue) lbFirstCard.Text += "\nSecond turn!"; 
                    else lbSecondCard.Text += "\nSecond turn!";
                }

                btnStart.Visible = true;
                txtPlayerName.Visible = true;
                lbChooseCard.Text = "We are ready to play!";
            }
        }

        /// <summary>
        /// Store turn into players list
        /// </summary>
        private void Turn_Order()
        {
            // decide turn order
            if (playerValue < user1Value && playerValue < user2Value)
            {
                players[0].Turn = 1;

                players[1].Turn = user1Value < user2Value ? 2 : 3;
                players[2].Turn = user2Value < user1Value ? 2 : 3;

                // 0 -> 1 -> 2
                // 0 -> 2 -> 1
            }

            else if (playerValue > user1Value && user1Value < user2Value)
            {
                players[1].Turn = 1;

                players[0].Turn = playerValue < user2Value ? 2 : 3;
                players[2].Turn = user2Value < playerValue ? 2 : 3;
                // 1 -> 0 -> 2
                // 1 -> 2 -> 0
            }

            else if (playerValue > user2Value && user1Value > user2Value)
            {
                players[2].Turn = 1;

                players[0].Turn = playerValue < user1Value ? 2 : 3;
                players[1].Turn = user1Value < playerValue ? 2 : 3;

                // 2 -> 0 -> 1
                // 2 -> 1 -> 0
            }

            lbPlayerName.Text += $"({players[0].Turn})";
            lbUser1Name.Text += $"({players[1].Turn})";
            lbUser2Name.Text += $"({players[2].Turn})";

            // if playes is first turn.
            if (players[0].Turn == 1) playerTurn = true; 
        }
        #endregion


        #region game start

        /// <summary>
        /// Check player enter a name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPlayerName_Enter(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == string.Empty)
            {
                txtPlayerName.Text = "Enter your name";
            }

            else if (txtPlayerName.Text == "Enter your name")
            {
                txtPlayerName.Text = "";
            }

        }

        /// <summary>
        /// Spread cards to users, after turn decision
        /// Remove duplicated facevalue cards in player's hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPlayerName.Text) || txtPlayerName.Text == "Enter your name") 
                {
                    SystemMsg("Please enter your name", 1000);
                }

                else
                {
                    players[0].Name = txtPlayerName.Text;
                    lbPlayerName.Text = players[0].Name;
                    lbUser1Name.Text = players[1].Name;
                    lbUser2Name.Text = players[2].Name;

                    panel_turnChoice.Controls.Clear();
                    panel_turnChoice.Visible = false;
                    lbFirstCard.Visible = false;
                    lbSecondCard.Visible = false;
                    lbThirdCard.Visible = false;
                    btnStart.Visible = false;
                    txtPlayerName.Visible = false;
                    lbChooseCard.Visible = false;
                    PanelPlayer.Visible = true;
                    PanelUser1.Visible = true;
                    PanelUser2.Visible = true;
                    gameStart = true;

                    SystemMsg("Dealing...", 1000);

                    players[0].Hand = aDeck.DealHand(18);
                    players[1].Hand = aDeck.DealHand(18);
                    players[2].Hand = aDeck.DealHand(17);

                    foreach(Player p in players)
                    {
                        ShowCard(p.PanelName, p.Hand, p.CardSide, p.CardWidth, p.CardHeight, p.CardLeft);
                    }
                   
                    lbUser1Name.Visible = true;
                    lbUser2Name.Visible = true;
                    lbPlayerName.Visible = true;
                    Delay(1000);

                    SystemMsg("Cards are sorting...", 2000);
                    foreach (Player p in players)
                    {
                        SortCards(p.Hand);
                    }

                    Turn_Order();
                    Delay(1000);

                    if(players[0].Hand.Count < 6)
                    {
                        SystemMsg("You are lucky! \nGame Start!", 2000);
                    }

                    else if(players[0].Hand.Count > 8)
                    {
                        SystemMsg("Oh, Good luck! \nGame Start!", 2000);
                    }

                    else
                    {
                        SystemMsg("Game Start!", 1000);
                    }

                    btnEndTurn.Visible = true;

                    Action();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// <summary>
        /// Method for deleting duplicated cards when the game is started
        /// </summary>
        /// <param name="theHand"></param>
        private void SortCards(Hand theHand)
        {
            Card duplicatedValueCard = null;

            for (int i = 0; i < theHand.Count; i++)
            {
                for (int j = i + 1; j <= theHand.Count - 1; j++)
                {
                    if (theHand[i].FaceValue == theHand[j].FaceValue)
                    {
                        duplicatedValueCard = theHand[i];
                        RemoveDuplicatedCard(duplicatedValueCard, theHand);
                        SortCards(theHand);
                    }
                }
            }
        }

        #endregion


        #region playing

        /// <summary>
        /// show cards in the hand
        /// </summary>
        /// <param name="thePanel"></param>
        /// <param name="theHand"></param>
        private void ShowCard(string panelName, Hand theHand, string cardSide, int width, int height, int left)
        {
            Panel thePanel = PanelChoice(panelName);
            
            thePanel.Controls.Clear();
            Card aCard;
            PictureBox aPic;
            string path = "";

            for (int i = 0; i < theHand.Count; i++)
            {
                aCard = theHand[i];

                if (cardSide == "front")
                {
                    path = @"images\" + aCard.FaceValue.ToString() + aCard.Suit.ToString() + ".jpg";
                }

                if (cardSide == "back")
                {
                    path = @"images\cardback.gif";
                }

                aPic = new PictureBox()
                {
                    Image = Image.FromFile(path),
                    Text = aCard.FaceValue.ToString(),
                    Width = width,
                    Height = height,
                    Left = left * i,
                    Tag = aCard
                };

                // The direction of User2's card in the panel is the opposite. (right -> left)
                if (theHand == players[2].Hand)
                {
                    aPic.Left = 890 - (left * i);
                }

                aPic.SizeMode = PictureBoxSizeMode.StretchImage;
                aPic.Click += PicturBox_Click;

                thePanel.Controls.Add(aPic);
            }
        }
        
        /// <summary>
        /// when user click the picture(turn choice and play)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicturBox_Click(object sender, EventArgs e)
        {
            PictureBox picClicked = (PictureBox)sender;
            int cardPos;

            if (gameStart)
            {
                if (playerTurn)
                {
                    nextTurn = currentTurn + 1 > numOfPlayer ? 1 : currentTurn + 1;
                    if (firstZero == nextTurn)
                    {
                        nextTurn = nextTurn + 1 > numOfPlayer ? 1 : nextTurn + 1;
                    }

                    int nextPlayerIndex = players.IndexOf(players.Where(p => p.Turn == nextTurn).FirstOrDefault());
                    cardPos = PanelChoice(players[nextPlayerIndex].PanelName).Controls.IndexOf(picClicked);
                    
                    if (cardPos == -1)
                    {
                        SystemMsg($"Please pick {players[nextPlayerIndex].Name}'s card.", 2000);
                        return;
                    }

                    else
                    {
                        players[nextPlayerIndex].Hand.RemoveCard((Card)picClicked.Tag);
                        players[0].Hand.AddCard((Card)picClicked.Tag);
                        players[nextPlayerIndex].Hand.Shuffle();
                        ShowCard(players[0].PanelName, players[0].Hand, "front", 63, 90, 67);
                        ShowCard(players[nextPlayerIndex].PanelName, players[nextPlayerIndex].Hand, "back", 47, 67, 50);
                    }

                    playerTurn = false;
                    btnEndTurn.Enabled = true;
                }

                else
                {
                    SystemMsg("Your turn is over.\nPlease click end turn.", 2000);
                }
            }

            else
            {
                cardPos = panel_turnChoice.Controls.IndexOf(picClicked);
                Turn_Decision(cardPos);
                panel_turnChoice.Enabled = false;
            }
        }

        /// <summary>
        /// End players turn, Start next turn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            btnEndTurn.Enabled = false;
            Check_Remove(players[0].Hand);

            Check_Win();
            if (gameover)
            {
                Restart();
                return;
            }

            Delay(1000);
            Action();
        }

        /// <summary>
        /// Check duplicated cards when user pick other user's card during game play
        /// </summary>
        /// <param name="theHand"></param>
        private void Check_Remove(Hand theHand)
        {
            Card duplicatedValueCard = null;

            for (int i = 0; i < theHand.Count; i++)
            {
                for (int j = i + 1; j <= theHand.Count - 1; j++)
                {
                    if (theHand[i].FaceValue == theHand[j].FaceValue)
                    {
                        duplicatedValueCard = theHand[i];
                        RemoveDuplicatedCard(duplicatedValueCard, theHand);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Remove duplicated cards in each user's hand
        /// </summary>
        /// <param name="duplicatedValueCard"></param>
        /// <param name="theHand"></param>
        private void RemoveDuplicatedCard(Card duplicatedValueCard, Hand theHand)
        {
            if (duplicatedValueCard != null)
            {
                Card firstDuplicated;
                Card secondDuplicated;

                if (theHand == players[0].Hand)
                {
                    firstDuplicated = theHand.sortHand(duplicatedValueCard.FaceValue)[0];
                    secondDuplicated = theHand.sortHand(duplicatedValueCard.FaceValue)[1];
                    players[0].Hand.RemoveCard(firstDuplicated);
                    players[0].Hand.RemoveCard(secondDuplicated);
                    ShowCard(players[0].PanelName, players[0].Hand, "front", 63, 90, 67);
                }

                if (theHand == players[1].Hand)
                {
                    firstDuplicated = theHand.sortHand(duplicatedValueCard.FaceValue)[0];
                    secondDuplicated = theHand.sortHand(duplicatedValueCard.FaceValue)[1];
                    players[1].Hand.RemoveCard(firstDuplicated);
                    players[1].Hand.RemoveCard(secondDuplicated);
                    ShowCard(players[1].PanelName, players[1].Hand, "back", 47, 67, 50);
                }

                if (theHand == players[2].Hand)
                {
                    firstDuplicated = theHand.sortHand(duplicatedValueCard.FaceValue)[0];
                    secondDuplicated = theHand.sortHand(duplicatedValueCard.FaceValue)[1];
                    players[2].Hand.RemoveCard(firstDuplicated);
                    players[2].Hand.RemoveCard(secondDuplicated);
                    ShowCard(players[2].PanelName, players[2].Hand, "back", 47, 67, 50);
                }
            }
        }

        /// <summary>
        /// players' action
        /// </summary>
        private void Action()
        {
            int curentPlayerIndex = players.IndexOf(players.Where(p => p.Turn == currentTurn).FirstOrDefault());
            SystemMsg($"{players[curentPlayerIndex].Name}'s turn", 2000);

            if (!playerTurn)
            {
                nextTurn = currentTurn + 1 > numOfPlayer ? 1 : currentTurn + 1;
                if (firstZero == nextTurn)
                {
                    nextTurn = nextTurn + 1 > numOfPlayer ? 1 : nextTurn + 1;
                }

                int nextPlayerIndex = players.IndexOf(players.Where(p => p.Turn == nextTurn).FirstOrDefault());

                lbSystem.Text = "";
                Random rGen = new Random();
                int removeIndex = rGen.Next(0, players[nextPlayerIndex].Hand.Count);
                Card pickCard = players[nextPlayerIndex].Hand[removeIndex];
                players[nextPlayerIndex].Hand.RemoveCard(pickCard);
                players[curentPlayerIndex].Hand.AddCard(pickCard);

                Delay(1000);
                Check_Remove(players[curentPlayerIndex].Hand);
                players[curentPlayerIndex].Hand.Shuffle();
                ShowCard(players[curentPlayerIndex].PanelName, players[curentPlayerIndex].Hand, players[curentPlayerIndex].CardSide, players[curentPlayerIndex].CardWidth, players[curentPlayerIndex].CardHeight, players[curentPlayerIndex].CardLeft);
                ShowCard(players[nextPlayerIndex].PanelName, players[nextPlayerIndex].Hand, players[nextPlayerIndex].CardSide, players[nextPlayerIndex].CardWidth, players[nextPlayerIndex].CardHeight, players[nextPlayerIndex].CardLeft);

                Check_Win();

                if (gameover)
                {
                    Restart();
                    return;
                }

                Delay(1000);

                if(players.Where(p => p.Turn == nextTurn).FirstOrDefault().Tag == "Player")
                {
                    playerTurn = true;
                    SystemMsg($"{players[0].Name}'s turn", 2000);
                    return;
                }

                Action();
            }
        }
        
        /// <summary>
        /// check win based on the number of player's card
        /// </summary>
        private void Check_Win()
        {
            if (players[0].Hand.Count == 0)
            {
                if (players[1].Hand.Count > 0) ShowCard(players[1].PanelName, players[1].Hand, "front", 47, 67, 50);
                if (players[2].Hand.Count > 0) ShowCard(players[2].PanelName, players[2].Hand, "front", 47, 67, 50);
                playerWin = true;
                gameover = true;
            }

            else if (players[1].Hand.Count == 0 && players[2].Hand.Count == 0)
            {
                playerWin = false;
                gameover = true;
            }

            else if (players[1].Hand.Count == 0)
            {
                firstZero = players[1].Turn;
            }

            else if (players[2].Hand.Count == 0)
            {
                firstZero = players[2].Turn;
            }

            if (firstZero == nextTurn)
            {
                nextTurn = nextTurn + 1 > numOfPlayer ? 1 : nextTurn + 1;
            }
            currentTurn = nextTurn;

        }

        #endregion


        #region Restart

        /// <summary>
        /// When game is over, shows the restart message and button
        /// </summary>
        private void Restart()
        {
            lbSystem.Visible = true;
            if (playerWin)
            {
                lbSystem.Text = $"Congraturations! {players[0].Name} win!\nDo you want to play again?";
            }
            else
            {
                lbSystem.Text = $"{players[0].Name} lose.\nDo you want to play again?";
            }

            btnRestart.Visible = true;

        }

        /// <summary>
        /// When click restart button, set up new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestart_Click(object sender, EventArgs e)
        {
            JoinGame();
        }
        #endregion


        #region functions

        /// <summary>
        /// which panel should be selected based on player
        /// </summary>
        /// <param name="panelName"></param>
        /// <returns></returns>
        private Panel PanelChoice(string panelName)
        {
            if (panelName == "User1")
                return PanelUser1;

            if (panelName == "User2")
                return PanelUser2;

            if (panelName == "panel_turnChoice")
                return panel_turnChoice;

            return PanelPlayer;
        }

        /// <summary>
        /// for system message(start game, turn change, etc..)
        /// </summary>
        /// <param name="msg"></param>
        private void SystemMsg(string msg, int delayTime)
        {
            lbSystem.Visible = true;
            lbSystem.Text = msg;
            Delay(delayTime);
            lbSystem.Text = "";
            lbSystem.Visible = false;
        }

        /// <summary>
        /// give delay between functions
        /// </summary>
        /// <param name="MS"></param>
        /// <returns></returns>
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }
        #endregion

    }


}
