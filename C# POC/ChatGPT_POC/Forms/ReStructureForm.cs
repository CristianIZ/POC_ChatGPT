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
    public partial class ReStructureForm : Form
    {
        public ReStructureForm()
        {
            InitializeComponent();
        }

        private void ReStructureForm_Load(object sender, EventArgs e)
        {
            cmbNewPosition.Items.Add("Team Leader");
            cmbNewPosition.Items.Add("Developper");
            cmbNewPosition.SelectedIndex = 0;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkHighlight.Checked)
                    txtResponse.Text = await requestHelper.IARequest(GPTQuestions.ReStructureAndBold(txtText.Text, cmbNewPosition.Text), IAModelEnum.ChatGPT);
                else
                    txtResponse.Text = await requestHelper.IARequest(GPTQuestions.ReStructure(txtText.Text, cmbNewPosition.Text), IAModelEnum.ChatGPT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
