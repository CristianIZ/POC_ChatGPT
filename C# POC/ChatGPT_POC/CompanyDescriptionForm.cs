using System;
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
    public partial class CompanyDescriptionForm : Form
    {
        public CompanyDescriptionForm()
        {
            InitializeComponent();
        }

        private void CompanyDescriptionForm_Load(object sender, EventArgs e)
        {
            cmbCompanyLocation.Items.Add("EEUU");
            cmbCompanyLocation.Items.Add("Argentina");
            cmbCompanyLocation.Items.Add("Brazil");
            cmbCompanyLocation.Items.Add("Panama");
            cmbCompanyLocation.Items.Add("Poland");
            cmbCompanyLocation.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var question = GPTQuestions.CompanyDescription(cmbCompanyName.Text, cmbCompanyLocation.Text);

            txtResponse.Text = requestHelper.IARequest(question, IAModelEnum.ChatGPT).Result;
        }
    }
}
