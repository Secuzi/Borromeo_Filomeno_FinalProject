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

        public string Username { get; set; }
        UberGameHomepage game = new UberGameHomepage();


        public HomePage()
        {
            InitializeComponent();
            
        }

        public void OpenForm(object form)
        {
            if (this.panel_form.Controls.Count > 0)
            {
                this.panel_form.Controls.RemoveAt(0);
            }
            // turns the object into a Form and then adds the controls and tag of the form into the panel
            Form currentform = form as Form;
            currentform.TopLevel = false;
            currentform.Dock = DockStyle.Fill;
            this.panel_form.Controls.Add(currentform);
            this.panel_form.Tag = currentform;
            currentform.Show();

        }

        // opens the form into the panel
        private void btn_Math_Click(object sender, EventArgs e)
        {
            OpenForm(new MathZilla());

            /*
            char[] charArray = ans.ToCharArray;

            Random rnd = new Random();

            int digit = rnd.Next(0, charArray.Length + 1) rnd(inclusive, exclusive) mao nang + 1
            12345 example
    
            1 = 0 + 1 (digit)
                                    value
            string clue = charArray[digit].ToString();

            Clue.Text = $"{digit + 1} is the {clue}";
            */





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
            this.Close();
        }

        private void timerMainHomePage_Tick(object sender, EventArgs e)
        {
            if (game.IsFormHidden)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }

        }
    }
}
