using Borromeo_Filomeno_FinalProject.Properties;
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
    public partial class UberGameHomepage : Form
    {
        public bool IsPlayClicked;

        public bool IsFormHidden;

        public bool IsHelpClicked;

        public UberGameHomepage()
        {
            InitializeComponent();
        }

        private void UberGameHomepage_Load(object sender, EventArgs e)
        {
            Cursor customCursor = new Cursor(Resources.sCursor.GetHicon());
            this.Cursor = customCursor;

            lblTitle.Bounds.IntersectsWith(pbPlayer.Bounds);


        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            IsPlayClicked = true;
            timerHomePageUB.Enabled = true;
        }

        private void timerHomePageUB_Tick(object sender, EventArgs e)
        {
            if (IsPlayClicked)
            {
                pbPlayer.Top -= 3;
            }

            //Iterates through each of the controls in this form
            foreach(Control ctr in this.Controls)
            {

                //If we don't use the "as" keyword then there's a possibility that label will be stored as the player picturebox
                //Therefore we can't cast it to a Label
                //So by using the "as" keyword we can specifically target Labels

                Label label = ctr as Label;
                if (label != null)
                {
                    if (label.Bounds.IntersectsWith(pbPlayer.Bounds))
                    {
                        label.Visible = false;
                    }
                }


            }
            
            if (pbPlayer.Top < -55)
            {
                this.Hide();
                IsFormHidden = true;

                timerHomePageUB.Stop();

                UberGame game = new UberGame();
                game.Show();
                
                this.Close();
                
            }
        
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            
            IsHelpClicked = true;


        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
