using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_1._3
{
    public partial class Form1 : Form
    {
        private enum RPS {
            rock = 0,
            paper = 1,
            scissors = 2
        }

        public Form1()
        {
            InitializeComponent();
        }

        int playerWon = 0;
        int playerDraw = 0;
        int playerLose = 0;

        private void PlayRPS(RPS playerChoice)
        {
            bool playerWin = false;
            Random random = new Random();

            Type type = typeof(RPS);
            Array values = type.GetEnumValues();
            int index = random.Next(values.Length);

            RPS enemyChoice = (RPS)values.GetValue(index);
            SetDialog(enemyChoice);

            if (enemyChoice == playerChoice)
            {
                SetStatus("Seri", Color.Orange);
                playerDraw++;

                SetStatusNumber();
                return;
            }

            switch (enemyChoice)
            {
                case RPS.rock:
                    if(playerChoice == RPS.paper) playerWin = true;
                    else playerWin = false;

                    break;
                case RPS.paper:
                    if (playerChoice == RPS.scissors) playerWin = true;
                    else playerWin = false;

                    break;
                case RPS.scissors:
                    if(playerChoice == RPS.rock) playerWin = true;
                    else playerWin = false;

                    break;
            }

            if (playerWin)
            {
                SetStatus("Anda menang!", Color.Green);
                playerWon++;
            }
            else
            {
                SetStatus("Anda kalah", Color.Red);
                playerLose++;
            }

            SetStatusNumber();
        }

        private void SetDialog(RPS enemyChoice)
        {
            string dialog = "";
            if (enemyChoice == RPS.rock) dialog = "Musuh mengeluarkan batu.";
            else if (enemyChoice == RPS.paper) dialog = "Musuh mengeluarkan kertas.";
            else if (enemyChoice == RPS.scissors) dialog = "Musuh mengeluarkan gunting.";

            lb_dialog.Items.Add(DateTime.Now.ToString("[HH:mm:ss]") + " " + dialog);

            lb_dialog.SelectedIndex = lb_dialog.Items.Count - 1;
            lb_dialog.SelectedIndex = -1;
        }
        private void SetStatus(string text, Color c)
        {
            lbl_status.Text = text;
            lbl_status.ForeColor = c;
        }

        private void SetStatusNumber()
        {
            int playerMatch = (playerWon + playerDraw + playerLose);

            lbl_totalMatch.Text = "Total Permainan : " + playerMatch.ToString();
            lbl_winRate.Text = "Win Rate : " + ((double)playerWon / playerMatch * 100).ToString("0.00") + "%";
            lbl_statusNum.Text = "Menang : " + playerWon + " | Seri : " + playerDraw + " | Lose : " + playerLose;
        }

        private void btn_rock_Click(object sender, EventArgs e)
        {
            PlayRPS(RPS.rock);
        }

        private void btn_scissors_Click(object sender, EventArgs e)
        {
            PlayRPS(RPS.scissors);
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            PlayRPS(RPS.paper);
        }
    }
}
