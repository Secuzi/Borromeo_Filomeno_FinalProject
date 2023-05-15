using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public class UVEnemySmall : UVEnemy
    {
        public UVEnemySmall(PictureBox pbEnemy) : base(pbEnemy)
        {

        }
        public override void SetEnemySpeed(int speed = 3)
        {
            EnemySpeed = speed;
        }
        public override void ResetEnemy()
        {
            Random rnd = new Random();
            PbEnemy.Visible = false;
            PbEnemy.Left = rnd.Next(12, 741);
            PbEnemy.Top = rnd.Next(0, 1600) * -1;
        }

        public override void MoveEnemy()
        {
            if ((string)PbEnemy.Tag == "enemySmall")
            {
                PbEnemy.Top += EnemySpeed;
            }
        }
    }
}
