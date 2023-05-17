using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public class Uber_Form_Game
    {
        public bool IsMovingRight { get; set; }
        public bool IsMovingLeft { get; set; }

        public bool IsShooting { get; set; }
        public bool IsGameOver { get; set; }

        public int PlayerSpeed { get; set; }
        public int EnemySpeed { get; set; }

        public int Score { get; set; }

        public static List<UVEnemy> Enemies { get; set; }



    }
}
