﻿using System;
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
            IsBackToHome = true;

        }
    }
}