﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGPT_POC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAskTo_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
        }

        private void btnCvGeneration_Click(object sender, EventArgs e)
        {
            var form = new ResumeGenerationForm();
            form.ShowDialog();
        }

        private void btnReStructure_Click(object sender, EventArgs e)
        {
            var form = new ReStructureForm();
            form.ShowDialog();
        }

        private void btnCompanyDescription_Click(object sender, EventArgs e)
        {
            var form = new CompanyDescriptionForm();
            form.ShowDialog();
        }
    }
}
