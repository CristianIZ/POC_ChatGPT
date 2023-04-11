using ChatGPT_POC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            numYear.Minimum = 2000;

            numMonth.Maximum = 12;
            numMonth.Minimum = 0;

            numStartTechYear.Maximum = 3000;
            numStartTechYear.Minimum = 2000;

            numStartTechMonth.Maximum = 12;
            numStartTechMonth.Minimum = 0;

            numYear.Value = DateTime.Today.Year - 5;
            numMonth.Value = DateTime.Today.Month;
            numStartTechYear.Value = DateTime.Today.Year - 5;
            numStartTechMonth.Value = DateTime.Today.Month;

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

            var tech = new TechnologyExperienceModel()
            {
                Name = (string)(lstTechnologies.SelectedItems[0]),
                StartDate = new DateTime((int)numStartTechYear.Value, (int)numStartTechMonth.Value, 1)
            };

            lstTechLearned.Items.Add(tech);
            lstTechnologies.Items.RemoveAt(lstTechnologies.SelectedIndices[0]);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstTechLearned.SelectedItems == null || lstTechLearned.SelectedItems.Count == 0)
                return;

            lstTechnologies.Items.Add(((TechnologyExperienceModel)lstTechLearned.SelectedItems[0]).Name);
            lstTechLearned.Items.RemoveAt(lstTechLearned.SelectedIndices[0]);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string question = string.Empty;

                if (cmbSection.Text == "Description")
                {
                    question = GPTQuestions.DescriptionSection(cmbSection.Text, cmbSeniority.Text, cmbTechnology.Text, cmbSecondTechnology.Text, new DateTime((int)numYear.Value, (int)numMonth.Value, 1), MapList(), chkHighlight.Checked);
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
                txtResponse.Text = requestHelper.IARequest(question, IAModelEnum.ChatGPT).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<TechnologyExperienceModel> MapList()
        {
            var result = new List<TechnologyExperienceModel>();

            foreach (var item in lstTechLearned.Items)
            {
                result.Add((TechnologyExperienceModel)item);
            }

            return result;
        }
    }
}
