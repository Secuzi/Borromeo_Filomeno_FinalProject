using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    internal class clsMathZilla
    {
        public string Player1_Name;
        public string Player2_Name;
        public string Game_Mode;
        public int p1_ans;
        public int p2_ans;
        public int Num1;
        public int Num2;
        public int P1Score;
        public int P2Score;
        public int Result;
        public bool P1Turn;
        public bool P2Turn;
        public bool Playing;

        public clsMathZilla()
        {
            Player1_Name = null;
            Player2_Name = null;
            Game_Mode = null;
            Playing = false;
        }


        public bool CheckPlayer1Answer(clsMathZilla player)
        {
            if (player.p1_ans == Result)
                return true;
            else return false;

        }

        public bool CheckPlayer2Answer(clsMathZilla player)
        {
            if (player.p2_ans == Result)
                return true;
            else return false;

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

        public int ShowClue()
        {
            Random rnd = new Random();     
            char[] digits = Result.ToString().ToCharArray();
            int digit = digits[rnd.Next(0, digits.Length)];
            return digit;


        }


        public void Game_Start()
        {
            if (Game_Mode == "Addition")
            {
                while (Playing)
                {
                    
                }
            }
            else if (Game_Mode == "Subtraction")
            {

            }
            else if (Game_Mode == "Multiplcation")
            {

            }
            else if (Game_Mode == "Division")
            {

            }
            

        }
    }
}
