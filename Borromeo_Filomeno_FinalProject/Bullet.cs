using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public class Bullet : Uber_Form_Game
    {
        public int BulletSpeed { get; set; }
        public int BulletCount { get; set; }
        public PictureBox PbBullet { get; set; }

        public static int GetBulletCount { get; }

        public Bullet()
        {

        }
    }
}
