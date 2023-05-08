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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }

        public void openform(object form)
        {
            if (this.panel_form.Controls.Count > 0)
            {
                this.panel_form.Controls.RemoveAt(0);
            }
            Form currentform = form as Form;
            currentform.TopLevel = false;
            currentform.Dock = DockStyle.Fill;
            this.panel_form.Controls.Add(currentform);
            this.panel_form.Tag = currentform;
            currentform.Show();

        }

        private void btn_Racing_Click(object sender, EventArgs e)
        {
            openform(new Racing());
        }

        private void btn_Math_Click(object sender, EventArgs e)
        {
            openform(new MathGameForm());
        }
    }
}
