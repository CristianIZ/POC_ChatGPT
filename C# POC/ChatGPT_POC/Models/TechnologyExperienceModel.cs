using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_POC.Models
{
    public class TechnologyExperienceModel
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}; Years: {DateTime.Today.Year - StartDate.Year}";
        }
    }
}
