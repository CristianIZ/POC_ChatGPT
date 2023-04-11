using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_POC
{
    public class PostGPTModel
    {
        public string model { get; set; }
        public List<PostGPTMessages> messages { get; set; }
    }

    public class PostGPTMessages
    {
        public string role { get; set; }
        public string content { get; set; }
    }
}
