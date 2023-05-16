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
            lbl_Problem.Visible = false;
            lbl_ClueDisplay.Visible = false;
            player.P1Turn = true;
            player.P2Turn = false;
        }

        private void txt_Answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // if correct/wrong i messagebox siya  
                // inig answer ky i check kung sakto ba then score dayun og swap players
                int playerInput = int.Parse(txt_Answer.Text);

                if (player.P1Turn)
                {
                    player.p1_ans = playerInput;

                    bool IsCorrect = player.CheckPlayer1Answer(player);
                    if (IsCorrect)
                    {
                        player.P1Score++;
                    }
                    
                    player.P1Turn = false;
                    player.P2Turn = true;

                }

                if (player.P2Turn)
                {
                    player.p2_ans = playerInput;

                    bool IsCorrect = player.CheckPlayer1Answer(player);
                    if (IsCorrect)
                    {
                        player.P2Score++;
                    }

                    player.P2Turn = false;
                    player.P1Turn = true;

                }



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
            if (e.KeyCode == Keys.Enter)
            {
                lbl_p1_Name.Text = txt_p1_name.Text;
                player.Player1_Name = txt_p1_name.Text;

            }
        }

        private void txt_p2_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl_p2_name.Text = txt_p2_name.Text;
                player.Player2_Name = txt_p2_name.Text;
            }
        }

        private void btn_Clue_Click(object sender, EventArgs e)
        {

            lbl_ClueDisplay.Visible = true;

            lbl_ClueDisplay.Text = player.ShowClue().ToString();



            // ang clue display.text ang ilisan sa clue, pwede ra ang 1st number sa answer ba or ang last number sa answer ang i hatag nga clue
        }

        private void txt_Answer_Click(object sender, EventArgs e)
        {
            txt_Answer.Clear();
        }
    }
}
