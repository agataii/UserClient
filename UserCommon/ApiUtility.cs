using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCommon
{
    public class ApiUtility
    {
        public const string URL = "https://localhost:7017/";

        public static async Task<string> GetApiResponseAsync(string route) // users
        {
            HttpResponseMessage response;
            string responceContent;

            try
            {
                HttpClient httpClient = new HttpClient();

                response = await httpClient.GetAsync(URL + route);

                if (response.IsSuccessStatusCode)
                {
                    responceContent = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    responceContent = null;
                }
            }
            catch
            {
                responceContent = null;
            }

            return responceContent;
        }
    }
}
