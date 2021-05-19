using Newtonsoft.Json;
using RapidApiCovid.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiCovid.Services
{
    public class HttpRequestAPI
    {
        public async Task<OperationResponse> GetRegionesReportes()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://covid-19-statistics.p.rapidapi.com/reports"),
                    Headers =
                        {
                            { "x-rapidapi-key", "32ac4c9518msh7fb8f6c7a05eb7bp1178dbjsn193f09c779d6" },
                            { "x-rapidapi-host", "covid-19-statistics.p.rapidapi.com" },
                        },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    return new OperationResponse(1, body);
                }

            }
            catch(Exception exc)
            {
                Debug.WriteLine(exc);
                return new OperationResponse();
            }
        }

        public async Task<OperationResponse> GetProvinciasRegionAsync(string region)
        {
            try
            {

                DateTime currentminusmonth = DateTime.Now;
                currentminusmonth=currentminusmonth.AddMonths(-1);

                var urlqueries = $"https://covid-19-statistics.p.rapidapi.com/reports?date={currentminusmonth.ToString("yyyy-MM-dd")}&region_name={region}";


                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(urlqueries),
                    Headers =
                        {
                            { "x-rapidapi-key", "32ac4c9518msh7fb8f6c7a05eb7bp1178dbjsn193f09c779d6" },
                            { "x-rapidapi-host", "covid-19-statistics.p.rapidapi.com" },
                        },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    return new OperationResponse(1, body);
                }
            }
            catch(Exception exc)
            {
                Debug.WriteLine(exc);

                return new OperationResponse();
            }
        }
    }
}
