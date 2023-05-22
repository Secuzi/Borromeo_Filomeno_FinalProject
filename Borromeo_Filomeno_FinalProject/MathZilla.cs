using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public partial class MathZilla : Form
    {
        clsMathZilla player = new clsMathZilla();

        public MathZilla()
        {
            InitializeComponent();
        }
        private void temp_Load(object sender, EventArgs e)
        {
            //Initalizes the controls false except the P1 turn so that P1 will always choose what problem to solve first
            lbl_Problem.Visible = false;
            lbl_Problem.Text = null;
            lbl_ClueDisplay.Visible = false;
            player.P1Turn = true;
            player.P2Turn = false;
            lblTurn.Visible = false;
        }

        private void txt_Answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                int playerInput = int.Parse(txt_Answer.Text);

                //Checks if it is player 1's turn
                if (player.P1Turn)
                {
                    player.P1_ans = playerInput;

                    bool IsCorrect = player.CheckPlayer1Answer(player);

                    if (IsCorrect)   
                        
                        player.P1Score++;
                                           
                    else                   
                        player.P1Score--;
                    
                }
                //Checks if it is player 2's turn

                if (player.P2Turn)
                {
                    player.P2_ans = playerInput;

                    bool IsCorrect = player.CheckPlayer2Answer(player);
                    if (IsCorrect)

                        player.P2Score++;
                        
                    else                    
                        player.P2Score--;
                    
                }
                //If player 1's turn is done then it will set the next turn to be player 2's
                if (player.P1Turn)
                {
                    player.P1Turn = false;
                    player.P2Turn = true;
                    lblTurn.Text = player.Player2_Name;
                }
                else
                {
                    player.P1Turn = true;
                    player.P2Turn = false;
                    lblTurn.Text = player.Player1_Name;
                }
                lbl_p1_score.Text = player.P1Score.ToString();
                lbl_p2_score.Text = player.P2Score.ToString();
                //Checks if a player gets to 10 points
                player.GetWinner(lbl_p1_score, lbl_p2_score);

                lbl_Problem.Text = null;
                txt_Answer.Clear();
                lblDigit.Text = null;
                lbl_ClueDisplay.Visible = false;
            }
        }

        // inig click sa operators ky mu show of different problems depende sa unsa nga operators ang gi pili
        private void picbox_Add_Click(object sender, EventArgs e)
        {
            lbl_Problem.Visible = true;
            player.Addition_Problem(lbl_Problem);

        }

        private void picbox_Subtract_Click(object sender, EventArgs e)
        {
            lbl_Problem.Visible = true;
            player.Subtraction_Problem(lbl_Problem);
        }

        private void picbox_Multiply_Click(object sender, EventArgs e)
        {
            lbl_Problem.Visible = true;
            player.Multiplication_Problem(lbl_Problem);
        }

        private void picbox_Divide_Click(object sender, EventArgs e)
        {
            lbl_Problem.Visible = true;
            player.Division_Problem(lbl_Problem);
        }

        private void txt_p1_name_KeyDown(object sender, KeyEventArgs e)
        {
            //Sets the player 1 to the user's input
            if (e.KeyCode == Keys.Enter)
            {
                lbl_p1_Name.Text = txt_p1_name.Text;
                player.Player1_Name = txt_p1_name.Text;
                lblTurn.Visible = true;
                lblTurn.Text = player.Player1_Name;

            }
        }

        private void txt_p2_name_KeyDown(object sender, KeyEventArgs e)
        {
            //Sets the player 2 to the user's input
            if (e.KeyCode == Keys.Enter)
            {
                lbl_p2_name.Text = txt_p2_name.Text;
                player.Player2_Name = txt_p2_name.Text;
            }
        }

        private void btn_Clue_Click(object sender, EventArgs e)
        {
            //This will only show if the user has generated a problem
            if (lbl_Problem.Text != null && lbl_Problem.Text != "")
            {
                lbl_ClueDisplay.Visible = true;
                lblDigit.Visible = true;
                lbl_ClueDisplay.Text = player.ShowClue(lblDigit).ToString();

            }
        }

        private void txt_Answer_Click(object sender, EventArgs e)
        {
            txt_Answer.Clear();
        }

        private void txt_Answer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
