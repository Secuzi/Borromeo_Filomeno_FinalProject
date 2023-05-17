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
    public partial class UberGameHelp : Form
    {
        public bool IsBackToHome;

        public UberGameHelp()
        {
            InitializeComponent();
        }

        private void pbBackTohome_Click(object sender, EventArgs e)
        {
            //If IsBackToHome is true then the HomePage form will open the UberGameHomepage form
            IsBackToHome = true;

        }

        private void UberGameHelp_Load(object sender, EventArgs e)
        {
            //When the form loads the cursor will be set to the image that I imported to resources.
            Cursor newCursor = new Cursor(Resources.sCursor.GetHicon());
            this.Cursor = newCursor;
        }
    }
}
