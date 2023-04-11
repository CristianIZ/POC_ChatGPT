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
using Microsoft.VisualBasic.ApplicationServices;

namespace ChatGPT_POC
{
    public static class requestHelper
    {
        private static readonly HttpClient client = new HttpClient();
        private static string APIKEY = ""; // Place your API KEY here !!!

        public static async Task<string> IARequest(string question, IAModelEnum iaModelEnum)
        {
            switch (iaModelEnum)
            {
                case IAModelEnum.ChatGPT:
                    return await ChatGPT(question);

                case IAModelEnum.Davinci:
                    return await Davinci(question);

                default:
                    return null;
            }
        }

        public static async Task<string> Davinci(string question)
        {
            try
            {
                var url = @"https://api.openai.com/v1/completions";

                var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);

                // requestMessage.Headers.Add(@"Content-Type", @"application/json");
                requestMessage.Headers.Add("Authorization", APIKEY);

                var gptModel = new PostDavinciModel()
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

        public static async Task<string> ChatGPT(string question)
        {
            try
            {
                var url = @"https://api.openai.com/v1/chat/completions";

                var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);

                // requestMessage.Headers.Add(@"Content-Type", @"application/json");
                requestMessage.Headers.Add("Authorization", APIKEY);

                var gptModel = new PostGPTModel()
                {
                    model = "gpt-3.5-turbo",
                    messages = new List<PostGPTMessages>()
                    {
                        new PostGPTMessages()
                        {
                            role = "user",
                            content = question
                        }
                    }

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
