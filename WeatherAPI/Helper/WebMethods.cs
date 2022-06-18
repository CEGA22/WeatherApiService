﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Helper
{
    public class WebMethods
    {
        public static async Task<string> MakeGetRequest(string url)
        {

            var strReturn = string.Empty;

            try
            {
                var request = WebRequest.Create(url);
                HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        strReturn = reader.ReadToEnd();

                        if (string.IsNullOrWhiteSpace(strReturn))
                        {
                            strReturn = response.StatusCode + "Response contained an empty body ...";
                        }

                        return strReturn;
                    }
                }

                else
                {
                    return "error";
                }
            }

            catch (Exception e)
            {
                return "error";
            }
        }

        public static async Task<string> MakePostRequest(Uri uri, object item)
        {
            try
            {
                var httpClient = new HttpClient();
                var json = JsonConvert.SerializeObject(item);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uri, content);

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }               
            }

            catch (System.Exception ex)
            {

                var x = ex.Message;
                return "error";
            }

            return string.Empty;
        }
    }
}
