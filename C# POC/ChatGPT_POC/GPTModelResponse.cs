﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_POC
{
    public class GPTModelResponse
    {
        public string id { get; set; }
        public string created { get; set; }
        public string model { get; set; }
        public List<Choices> choices { get; set; }
        public Usage usage { get; set; }
    }

    public class Choices
    {
        public string text { get; set; }
        public int index { get; set; }
        public string logprobs { get; set; }
        public string finish_reason { get; set; }
    }

    public class Usage
    {
        public int prompt_tokens { get; set; }
        public int completion_tokens { get; set; }
        public int total_tokens { get; set; }
    }
}
