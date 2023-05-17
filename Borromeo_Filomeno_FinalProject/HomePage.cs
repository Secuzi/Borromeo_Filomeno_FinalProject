using Borromeo_Filomeno_FinalProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public partial class HomePage : Form
    {

        UberGameHomepage game = new UberGameHomepage();
        UberGameHelp gameHelp = new UberGameHelp();

        public HomePage()
        {
            InitializeComponent();
            
        }

        public void OpenForm(object form)
        {

            //If there's already a form occupying the panel then it will be removed.
            if (this.panel_form.Controls.Count > 0)
            {
                //removing the form
                this.panel_form.Controls.RemoveAt(0);
            }
            // turns the object into a Form and then adds the controls and tag of the form into the panel
            Form currentform = form as Form;
            //Making sure that the form won't be a top level window because it won't show the form if it is true (default)
            currentform.TopLevel = false;
            //Filling the form to fit the panel
            currentform.Dock = DockStyle.Fill;
            //Adding the current form to the panel
            this.panel_form.Controls.Add(currentform);
            this.panel_form.Tag = currentform;
            //Showing the form
            currentform.Show();

        }

        // opens the form into the panel
        private void btn_Math_Click(object sender, EventArgs e)
        {
            OpenForm(new MathZilla());
        }

        private void btn_UberVoid_Click(object sender, EventArgs e)
        {

            
            OpenForm(game = new UberGameHomepage());

            //this.Hide();
            //UberGame game = new UberGame();
            //game.User = Username;
            //game.ShowDialog();
            //this.Close();


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This will continue to run until the user closes the game or the homepage
        private void timerMainHomePage_Tick(object sender, EventArgs e)
        {

            //Gets the confirmation whether or not the form is hidden this will be true if the user decides to play the uber void game
            if (game.IsFormHidden)        
                this.Hide();
            
            else     
                this.Show();
            
            //This open the UberGameHelp form if the user clicks on the Help button in the UberGameHomepage form
            if (game.IsHelpClicked)
            {
                OpenForm(gameHelp = new UberGameHelp());
                game.IsHelpClicked = false;
            }

            //If the user clicks on the back Picturebox then this will open the UberGameHomepage
            if (gameHelp.IsBackToHome)
            {
                OpenForm(game = new UberGameHomepage());
                gameHelp.IsBackToHome = false;
            }
            
        }

        private void pb_logo_Click(object sender, EventArgs e)
        {
            OpenForm(new AboutUs());
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            OpenForm(new AboutUs());
        }
    }
}
