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
    public partial class Math_Zilla : Form
    {
        public Math_Zilla()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Math_Zilla_Load(object sender, EventArgs e)
        {
            //panel_Problem.Visible = false;
            //panel_Answering.Visible = false;
        }

        private void txt_Player1Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            // inig enter sa user ky ma display ang pangan sa label
            if (true)
            {
                lbl_Player1Name.Text = txt_Player1Name.Text;
            }
        }

        private void txt_Player2Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (true)
            {
                lbl_Player2Name.Text = txt_Player2Name.Text;
            }

            panel_Problem.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Clue_Click(object sender, EventArgs e)
        {
            // when the user clicks clue, only the first or last number of the answer would be revealed
        }
    }
}
