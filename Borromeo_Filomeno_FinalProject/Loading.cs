using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public partial class Loading_Form : Form
    {
        
        public Loading_Form()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //shows the quadrant 2

            pb1.Visible = true;
            timer1.Stop();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // hides all the picture boxes
            checkBox_true.Visible = false;
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;

            //timer1.Start();
            //timer2.Start();
            //timer3.Start();
            //timer4.Start();
            //timer5.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //shows the quadrant 1

            pb2.Visible = true;
            timer2.Stop();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //shows the quadrant 3

            pb3.Visible = true;
            timer3.Stop();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //shows the quadrant 4

            pb4.Visible = true;
            timer4.Stop();

        }

        public void timer5_Tick(object sender, EventArgs e)
        {
            //when the time has come, checks the checkbox
            timer5.Stop();
            checkBox_true.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // when the checkbox has been checked, then the program loads the registration form
            if (checkBox_true.Checked)
            {
                var register = new Register_Form();
                this.Hide();
                register.ShowDialog();
                this.Close();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
        }
    }
}
