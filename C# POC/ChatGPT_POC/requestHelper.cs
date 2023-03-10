using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace ChatGPT_POC
{
    public static class requestHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> RequestChatGPT(string question)
        {
            try
            {
                var url = @"https://api.openai.com/v1/completions";

                var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);

                // requestMessage.Headers.Add(@"Content-Type", @"application/json");
                requestMessage.Headers.Add("Authorization", "Bearer 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");

                var gptModel = new PostGPTModel()
                {
                    model = "text-davinci-003",
                    prompt = question,
                    max_tokens = 4000,
                    temperature = 1.0M
                };

                // requestMessage.Content = new StringContent("{\r\n  \"model\": \"text-davinci-003\",\r\n  \"prompt\": \"What is your name?\",\r\n  \"max_tokens\": 4000,\r\n  \"temperature\": 1.0\r\n}", Encoding.UTF8, "application/json");
                requestMessage.Content = new StringContent(JsonConvert.SerializeObject(gptModel), Encoding.UTF8, "application/json");


                var response = client.SendAsync(requestMessage).Result;
                var result = response.Content.ReadAsStringAsync().Result;

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new Exception(result);

                var parseObject = JsonConvert.DeserializeObject<GPTModelResponse>(result);

                return string.Join("", parseObject.choices.Select(r => r.text).ToList().First());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
