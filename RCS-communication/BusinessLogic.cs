using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace RCS_communication
{
    public static class BusinessLogic
    {
        public static string SystemId = "VITSSK";
        public static string GenerateId()
        {
            string formattedDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            string dateTimeMilli = formattedDate + DateTime.Now.Millisecond.ToString();
            string id = "T" + dateTimeMilli;
            return id;
        }

        public static async Task<bool> InstructionPost(Instruction instr)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(instr);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("https://92897245-339d-4852-ac85-204e6dcf53d7.mock.pstmn.io/api/v2/orders", content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseContent);
                        return true;
                    }
                    return false;
                }
            }

            catch (Exception ex) { return false; }
        }

        public static async Task<Instruction> InstructionGet(string id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("https://92897245-339d-4852-ac85-204e6dcf53d7.mock.pstmn.io/api/v2/orders?id=" + id);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        Instruction instruction = JsonConvert.DeserializeObject<Instruction>(responseContent);
                        return instruction;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
