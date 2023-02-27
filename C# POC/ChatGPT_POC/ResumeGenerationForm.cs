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
    public partial class ResumeGenerationForm : Form
    {
        public ResumeGenerationForm()
        {
            InitializeComponent();
        }

        private void ResumeGeneration_Load(object sender, EventArgs e)
        {
            cmbSection.Items.Add("Description");
            cmbSection.Items.Add("Technical Skills");
            cmbSection.SelectedIndex = 0;

            cmbSeniority.Items.Add("Senior");
            cmbSeniority.Items.Add("Semi Senior");
            cmbSeniority.Items.Add("JR");
            cmbSeniority.SelectedIndex = 0;

            cmbTechnology.Items.Add("C#");
            cmbTechnology.Items.Add("Angular");
            cmbTechnology.SelectedIndex = 0;

            cmbSecondTechnology.Items.Add("Angular");
            cmbSecondTechnology.Items.Add("C#");
            cmbSecondTechnology.SelectedIndex = 0;

            numYear.Maximum = 3000;
            numYear.Minimum = 0;

            numYear.Value = DateTime.Today.Year - 5;
            numMonth.Value = DateTime.Today.Month;

            lstTechnologies.Items.Add("EntityFramework");
            lstTechnologies.Items.Add("Typescript");
            lstTechnologies.Items.Add("Elastic search");
            lstTechnologies.Items.Add("Mongo DB");
            lstTechnologies.Items.Add("jQuery");
            lstTechnologies.Items.Add("SQL");
            lstTechnologies.Items.Add("RabbitMQ");
            lstTechnologies.Items.Add("Microservices");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstTechnologies.SelectedItems == null || lstTechnologies.SelectedItems.Count == 0)
                return;

            lstTechLearned.Items.Add((string)(lstTechnologies.SelectedItems[0]));
            lstTechnologies.Items.RemoveAt(lstTechnologies.SelectedIndices[0]);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstTechLearned.SelectedItems == null || lstTechLearned.SelectedItems.Count == 0)
                return;

            lstTechnologies.Items.Add((string)(lstTechLearned.SelectedItems[0]));
            lstTechLearned.Items.RemoveAt(lstTechLearned.SelectedIndices[0]);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string question = string.Empty;

            if (cmbSection.Text == "Description")
            {
                question = GPTQuestions.DescriptionSection(cmbSection.Text, cmbSeniority.Text, cmbTechnology.Text, cmbSecondTechnology.Text, new DateTime((int)numYear.Value, (int)numMonth.Value, 1), MapList());
            }
            else if (cmbSection.Text == "Technical Skills")
            {
                question = GPTQuestions.TechnicalSkills(cmbTechnology.Text, cmbSecondTechnology.Text);
            }
            else
            {
                return;
            }

            txtQuestion.Text = question;
            txtResponse.Text = requestHelper.RequestChatGPT(question).Result;
        }

        private List<string> MapList()
        {
            var result = new List<string>();

            foreach (var item in lstTechLearned.Items)
            {
                result.Add((string)item);
            }

            return result;
        }
    }
}
