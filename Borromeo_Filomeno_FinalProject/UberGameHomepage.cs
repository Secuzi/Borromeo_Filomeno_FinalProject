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
        public bool IsPlayClicked { get; set; }

        public bool IsFormHidden { get; set; }

        public bool IsHelpClicked { get; set; }
        public string User { get; set; }

        public UberGameHomepage()
        {
            InitializeComponent();
        }

        private void UberGameHomepage_Load(object sender, EventArgs e)
        {
            //When the form loads the cursor will be set to the image that I imported to resources.
            Cursor customCursor = new Cursor(Resources.sCursor.GetHicon());
            this.Cursor = customCursor;
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            //When the play label is clicked then the animation will start.
            IsPlayClicked = true;
            timerHomePageUB.Enabled = true;
        }

        private void timerHomePageUB_Tick(object sender, EventArgs e)
        {
            //If the IsPlayClicked is true then it will do the animation
            if (IsPlayClicked)
            {
                pbPlayer.Top -= 3;
            }

            //Iterates through each of the controls in this form
            foreach (Control ctr in this.Controls)
            {

                //If we don't use the "as" keyword then there's a possibility that label will be stored as the player picturebox
                //Therefore we can't cast it to a Label
                //So by using the "as" keyword we can specifically target Labels

                Label label = ctr as Label;
                if (label != null)
                {
                    if (label.Bounds.IntersectsWith(pbPlayer.Bounds))
                    {
                        //If it hits the labels in the form then it will disappear
                        label.Visible = false;
                    }
                }

            }


            //If the player exceeds the -55 in its position then the animation will stop and the game will commence.
            if (pbPlayer.Top < -55)
            {
                //This instance will be hidden and also the homepage because IsFormHidden is true
                this.Hide();
                IsFormHidden = true;

                //The timer also stops so that it won't create an infinite instance of UberGame forms
                timerHomePageUB.Stop();

                UberGame game = new UberGame();

                game.ShowDialog();

                this.Close();

            }

        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            //Is if this is true then the homepage form will instantiate the UberGameHomepage form and there it will tell you
            //how to play the game.
            IsHelpClicked = true;


        }

        private void lblExit_Click(object sender, EventArgs e)
        {

            this.Hide();

        }
    }
}
