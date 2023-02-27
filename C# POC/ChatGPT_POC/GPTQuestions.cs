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
        public static string DescriptionSection(string section, string seniority, string mainTechnology, string secondTechnologie, DateTime workingSince, List<string> technologies)
        {
            var yearsExp = DateTime.Today.Year - workingSince.Year;
            var monthExp = DateTime.Today.Month - workingSince.Month;

            if (monthExp > 4)
                return $"Generate a resume {section} for a {seniority} {mainTechnology} developer with {yearsExp} years and {monthExp} months of experience with knowledge in {secondTechnologie}, {string.Join(", ", technologies)}";
            else
                return $"Generate a resume {section} for a {seniority} {mainTechnology} developer with {yearsExp} years of experience with knowledge in {secondTechnologie}, {string.Join(", ", technologies)}";
        }

        public static string TechnicalSkills(string mainTechnology, string secondTechnologie)
        {
            return $"List all sub technologies from {mainTechnology}, {secondTechnologie}";
        }

        private static string ReStructureBaseQuestion(string newPosition)
        {
            return $"Re organize the following description for a {newPosition} position: ";
        }

        public static string ReStructure(string text, string newPosition)
        {
            return $"{ReStructureBaseQuestion(newPosition)}: {text}";
        }

        public static string ReStructureAndBold(string text, string newPosition)
        {
            return $"{ReStructureBaseQuestion(newPosition)} and bold the important words: {text}";
        }
    }
}
