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
            
            pb1.Visible = true;
            timer1.Stop();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
            
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pb2.Visible = true;
            timer2.Stop();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pb3.Visible = true;
            timer3.Stop();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pb4.Visible = true;
            timer4.Stop();

        }

        public void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            checkBox1.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var register = new Register_Form();
                this.Hide();
                register.ShowDialog();
                this.Close();
            }
        }
    }
}
