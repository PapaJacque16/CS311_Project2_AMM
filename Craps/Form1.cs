using System.Security.Cryptography;

namespace Craps
{
    public partial class CrapsGame : Form
    {

        Image[] diceImages;
        int[] dice;
        int[] diceResult;
        Random rand;

        public CrapsGame()
        {
            InitializeComponent();
        }

        private void CrapsGame_Load(object sender, EventArgs e)
        {
            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.Die0;
            diceImages[1] = Properties.Resources.Die1;
            diceImages[2] = Properties.Resources.Die2;
            diceImages[3] = Properties.Resources.Die3;
            diceImages[4] = Properties.Resources.Die4;
            diceImages[5] = Properties.Resources.Die5;
            diceImages[6] = Properties.Resources.Die6;

            dice = new int[2] { 0, 0 };
            diceResult = new int[6] { 0, 0, 0, 0, 0, 0 };
            rand = new Random();
        }

        private void lblDice1_Click(object sender, EventArgs e)
        {

        }

        private void lblDice2_Click(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Roll();
            getResults();
            calculate_score();
        }

        private void Roll()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);// Dice should roll from 1 to six.

                lblDice1.Image = diceImages[dice[0]];
                lblDice2.Image = diceImages[dice[1]];


                switch (dice[i])//switch statement for the dice i
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
        }

        private void getResults()
        {
            //Using boolean value to call getResult
            bool lowresult = false;
            bool highResult = false;
            bool reallyhighNumber = false;

            lblDisplayResults.Text = "Point is (sum of the dice)";
            //for loop used to display results
            for (int i = 0; i<diceResult.Length; i++)
            {

                if (diceResult[i] > 6)
                    lowresult  = true;
                else if (diceResult[i] < 6)
                    highResult = true;
                else if (diceResult[i] > 9)
                    reallyhighNumber = true;
            }

            if (lowresult)
                lblDisplayResults.Text = "You win";
            else if (highResult)
                lblDisplayResults.Text = "You lose";
            else if (reallyhighNumber)
                lblDisplayResults.Text = "Point is (sum of the dice)";
        }

        private void calculate_score()
        {
            float BettingAmount = float.Parse(txtBoxBets.Text);

            float winnings = 100 + BettingAmount;

            lblBankBalance.Text = winnings.ToString("C");
        }
        private void lblBankBalance_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBoxBets_TextChanged(object sender, EventArgs e)
        {     
        }

        private void lblDisplayResults_Click(object sender, EventArgs e)
        { 
        }

    }//end class
}//end namespace