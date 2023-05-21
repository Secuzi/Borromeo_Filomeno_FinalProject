using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public class UVEnemyMedium : UVEnemy
    {
        public UVEnemyMedium()
        {

        }

        public override void SetEnemySpeed(int speed = 2)
        {
            EnemySpeed = speed;
        }
        public override void ResetEnemy(PictureBox enemy)
        {
            Random rnd = new Random();
            enemy.Visible = false;
            enemy.Left = rnd.Next(12, 741);
            enemy.Top = rnd.Next(0, 1200) * -1;
        }
        public override void MoveEnemy(PictureBox enemy)
        {

            enemy.Top += EnemySpeed;

        }

    }
}
