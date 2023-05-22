using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    internal class clsMathZilla
    {
        public string Player1_Name { get; set; }
        public string Player2_Name { get; set; }
        public string Game_Mode { get; set; }
        public int P1_ans { get; set; }
        public int P2_ans { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        private int p1Score { get; set; }
        private int p2Score { get; set; }

        public int P1Score
        {
            //Such that the score cannot be a negative number
            get { return p1Score; }
            set
            {
                if (value < 0)
                    p1Score = 0;
                else
                    p1Score = value;
            }
        }


        public int P2Score
        {
            get { return p2Score; }
            set
            {
                if (value < 0)
                    p2Score = 0;
                else
                    p2Score = value;
            }
        }

        public int Result { get; set; }
        public bool P1Turn { get; set; }
        public bool P2Turn { get; set; }
        public bool Playing { get; set; }


        public void GetWinner(Label score1, Label score2)
        {

            //Checks if either of the players' score gets to 10 then the messagebox will show and and score will reset.
            if (P1Score == 10)
            {
                MessageBox.Show("Player 1 wins!");
                P1Score = 0;
                P2Score = 0;

                score1.Text = p1Score.ToString();
                score2.Text = p2Score.ToString();

            }

            if (P2Score == 10)
            {
                MessageBox.Show("Player 2 wins!");
                P1Score = 0;
                P2Score = 0;
            }



        }


        public clsMathZilla()
        {
            Player1_Name = null;
            Player2_Name = null;
            Game_Mode = null;
            Playing = false;
        }


        public bool CheckPlayer1Answer(clsMathZilla player)
        {
            
            return (player.P1_ans == Result) ? true : false;

        }

        public bool CheckPlayer2Answer(clsMathZilla player)
        {

            return (player.P2_ans == Result) ? true : false;

        }



        public void Addition_Problem(Label problem)
        {
            // call to create new problem
            Random random = new Random();
            Num1 = random.Next(1, 100);
            Num2 = random.Next(1, 100);
            Result = Num1 + Num2;

            problem.Text = $"{Num1} + {Num2}";

            
        }

        public void Subtraction_Problem(Label problem)
        {
            Random random = new Random();
            Num1 = random.Next(50, 100);
            Num2 = random.Next(1, 50);
            Result = Num1 - Num2;
            problem.Text = $"{Num1} - {Num2}";
        }

        public void Multiplication_Problem(Label problem)
        {
            Random random = new Random();
            Num1 = random.Next(1, 10);
            Num2 = random.Next(1, 10);
            Result = Num1 * Num2;
            problem.Text = $"{Num1} * {Num2}";
        }

        public void Division_Problem(Label problem)
        {
            Random random = new Random();
            Num1 = random.Next(50, 100);
            Num2 = random.Next(1, 50);
            Result = Num1 / Num2;
            problem.Text = $"{Num1} / {Num2}";
        }

        public int ShowClue(Label clue)
        {
            Random rnd = new Random();

            string sDigit = Result.ToString();

            int index = rnd.Next(0, sDigit.Length);

            if (index == 0)            
                clue.Text = $"The clue is from the {index + 1}st digit";           
            else if (index == 1)         
                clue.Text = $"The clue is from the {index + 1}nd digit";          
            else if (index == 2)
                clue.Text = $"The clue is from the {index + 1}rd digit";
            else
                clue.Text = $"The clue is from the {index + 1}th digit";

            return Convert.ToInt32(sDigit[index].ToString());


        }

    }
}
