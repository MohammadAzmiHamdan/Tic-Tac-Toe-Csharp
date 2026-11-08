using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tik_Tak_Toe_Game.Properties;

namespace Tik_Tak_Toe_Game
{
    public partial class Form1 : Form
    {

        enPlayer PlayerTurn = enPlayer.Player1;
        stGameStatus GameStatus;
        
       enum enPlayer
        {
          Player1 , Player2
        }
        enum enWinner
        {
            Player1, Player2 , Draw ,InProgress 
        }
        struct stGameStatus
        {
           public  enWinner Winner;
           public short PlayCount;

            public bool GameOver;

        }
        public void ChangingButtonsClickability(bool Enabled )
        {
            
                btn1.Enabled = Enabled;
                btn2.Enabled = Enabled;
                btn3.Enabled = Enabled;
                btn4.Enabled = Enabled;
                btn5.Enabled = Enabled;
                btn6.Enabled = Enabled;
                btn7.Enabled = Enabled;
                btn8.Enabled = Enabled;
                btn9.Enabled = Enabled;



        }
        public void EndGame()
        {

            lblTurn.Text = "Game Over .";
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    lblWinner.Text = "Player 2";
                    break;
                default :
                    lblWinner.Text = "Draw";
                    break;

            }
            ChangingButtonsClickability(false);

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public bool CheckValue(Button btn1 , Button btn2,Button btn3)
        {
            if(btn1.Tag.ToString()!="?" &&  btn1.Tag.ToString()== btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString() )
            {
                btn1.BackColor = Color.DarkGoldenrod;
                btn2.BackColor = Color.DarkGoldenrod;
                btn3.BackColor = Color.DarkGoldenrod;
                if (btn1.Tag.ToString() == "O")
                {
                    GameStatus.Winner=enWinner.Player2 ;
                    GameStatus.GameOver=true;
                    EndGame();
                    return true;

                }
                else
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }
            GameStatus.GameOver = false;
            return false;
        }
        public void  CheckWinner()
        {
            //Check Rows 
            if (CheckValue(btn1, btn2, btn3) ) 
                return;
            if (CheckValue(btn4, btn5, btn6))
                return;
            if (CheckValue(btn7, btn8, btn9))
                return;

            //Check Cols
            if (CheckValue(btn1, btn4, btn7))
                return;
            if (CheckValue(btn2, btn5, btn8))
                return;
            if (CheckValue(btn3, btn6, btn9))
                return;


            //Check Diognal
            if (CheckValue(btn1, btn5, btn9))
                return;
            if (CheckValue(btn3, btn5, btn7))
                return;



        }
        public void ChangeImage (Button btn)
        {



            if (btn.Tag.ToString() != "?")
            { 
                
                MessageBox.Show("Wrong Choice!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return; 
            
            }



            switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.BackgroundImage = Resources.X_transparent;
                        btn.Tag = "X";
                        lblTurn.Text = "Player 2";
                        PlayerTurn= enPlayer.Player2 ;
                       
                    break;
                    case enPlayer.Player2:
                        btn.BackgroundImage = Resources.O_transparent;
                        btn.Tag = "O";
                        lblTurn.Text = "Player 1";
                        PlayerTurn = enPlayer.Player1;
                        
                    break;


            }
            GameStatus.PlayCount++;
            CheckWinner();

            if (GameStatus.PlayCount == 9 && !GameStatus.GameOver)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }


        public Form1()
        {
            InitializeComponent();
            RestGame();

        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color LineColor = Color.FromArgb(0, 220, 255);
            Pen pen =new Pen(LineColor, 20);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //First line is horizontal.
            e.Graphics.DrawLine(pen, 480, 268, 935, 268);
            //The second line is horizontal. 
            e.Graphics.DrawLine(pen, 480, 418, 935, 418);

            //First line is Vrctical .
            e.Graphics.DrawLine(pen, 630, 125, 630, 560);
            //second line is Vrctical .
            e.Graphics.DrawLine(pen, 782, 125, 782, 560);
        }
        private void RestButton(Button btn)
        {
            btn.BackgroundImage = Resources.Empty_transparent;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;

        }
        private void RestGame()
        {
            RestButton(btn1);
            RestButton(btn2);
            RestButton(btn3);
            RestButton(btn4);
            RestButton(btn5);
            RestButton(btn6);
            RestButton(btn7);
            RestButton(btn8);
            RestButton(btn9);
            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.InProgress;
            lblWinner.Text = "In Progress";
            ChangingButtonsClickability(true);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

           RestGame();
        }
    }
}
