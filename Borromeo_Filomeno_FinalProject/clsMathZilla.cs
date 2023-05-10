using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Result;
        public bool Playing;

        public clsMathZilla()
        {
            Player1_Name = null;
            Player2_Name = null;
            Game_Mode = null;
            Playing = false;
        }
        public void Addition_Problem()
        {
            // call to create new problem
            Random random = new Random();
            Num1 = random.Next(1, 100);
            Num2 = random.Next(1, 100);
            Result = Num1 + Num2;
        }

        public void Subtraction_Problem()
        {
            Random random = new Random();
            Num1 = random.Next(50, 100);
            Num2 = random.Next(1, 50);
            Result = Num1 - Num2;
        }

        public void Multiplication_Problem()
        {
            Random random = new Random();
            Num1 = random.Next(1, 10);
            Num2 = random.Next(1, 10);
            Result = Num1 * Num2;
        }

        public void Division_Problem()
        {
            Random random = new Random();
            Num1 = random.Next(50, 100);
            Num2 = random.Next(1, 50);
            Result = Num1 / Num2;
        }

        public void Game_Start()
        {
            if (Game_Mode == "Addition")
            {
                while (Playing)
                {
                    Addition_Problem();
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
