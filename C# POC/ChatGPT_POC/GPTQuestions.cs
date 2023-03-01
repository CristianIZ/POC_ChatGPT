using ChatGPT_POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ChatGPT_POC
{
    public static class GPTQuestions
    {
        public static string DescriptionSection(string section, string seniority, string mainTechnology, string secondTechnologie, DateTime workingSince, List<TechnologyExperienceModel> technologies, bool boldImportantWords)
        {
            var yearsExp = DateTime.Today.Year - workingSince.Year;
            var monthExp = DateTime.Today.Month - workingSince.Month;


            string question = $"Generate a resume {section.ToLower()} for a {seniority} {mainTechnology} developer with {yearsExp} years";

            if (monthExp > 4)
                question = $"{question} and {monthExp} months";

            question = $"{question} of experience with knowledge in {secondTechnologie}";

            if (technologies.Count > 0)
            {
                var techList = new List<string>();

                foreach (var item in technologies)
                {
                    techList.Add($"{item.Name} with {DateTime.Now.Year - item.StartDate.Year} years of experience");
                }

                question = $"{question}, {string.Join(", ", techList)}";
            }

            if (boldImportantWords)
            {
                question = $"{question}, {BoldQuestion()}";
            }

            return question;
        }

        public static string TechnicalSkills(string mainTechnology, string secondTechnologie)
        {
            return $"List all sub technologies from {mainTechnology}, {secondTechnologie}";
        }

        private static string ReStructureBaseQuestion(string newPosition)
        {
            return $"Re organize the following description for a {newPosition} position: ";
        }

        private static string BoldQuestion()
        {
            return "and bold the important words";
        }

        public static string ReStructure(string text, string newPosition)
        {
            return $"{ReStructureBaseQuestion(newPosition)}: {text}";
        }

        public static string ReStructureAndBold(string text, string newPosition)
        {
            return $"{ReStructureBaseQuestion(newPosition)} and bold the important words: {text}";
        }

        public static string CompanyDescription(string company, string companyLocation)
        {
            return $"Can you give me a description of {company}? ({companyLocation} company) and a list of its clients?";
        }
    }
}
