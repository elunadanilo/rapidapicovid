using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RapidApiCovid.Dao;
using RapidApiCovid.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApiCovid.Services
{
    public class ReportesService : IReportesDao
    {
        private HttpRequestAPI httpRequest = new HttpRequestAPI();

        public async Task<OperationResponse> GetProvinciasRegionReporte(string region)
        {
            try
            {
                OperationResponse response = await httpRequest.GetProvinciasRegionAsync(region);

                if (response.Code == 1)
                {
                    JObject objectt = JObject.Parse((string)response.Data);
                    var reportes = JsonConvert.DeserializeObject<List<Reportes>>(objectt["data"].ToString());

                    var provincias = reportes.Select(item => new ProvinciasCasesDeaths()
                    {
                        Provincia=item.Region.Province,
                        Cases=item.Active,
                        Deaths=int.Parse(item.Deaths)
                    }).OrderByDescending(item => item.Cases).Take(10).ToList();

                    return new OperationResponse(1,provincias);
                }

                return response;
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc);
                return new OperationResponse();
            }
        }

        public async Task<OperationResponse> GetRegionReportesAsync()
        {
            try
            {
                OperationResponse response=await httpRequest.GetRegionesReportes();

                if (response.Code == 1)
                {
                    JObject objectt = JObject.Parse((string)response.Data);
                    var reportes = JsonConvert.DeserializeObject<List<Reportes>>(objectt["data"].ToString());

                    var regiones = reportes.GroupBy(item => new
                    {
                        item.Region.Name,
                    }).Select(item => new RegionCasesDeaths()
                    {
                        Region=item.Key.Name,
                        Cases = item.Sum(item => item.Active),
                        Deaths =item.Sum(item=>int.Parse(item.Deaths)),
                    }).OrderByDescending(item=>item.Cases).Take(10).ToList();

                    return new OperationResponse(1, regiones);
                }

                return response;
            }catch(Exception exc)
            {
                Debug.WriteLine(exc);
                return new OperationResponse();
            }
        }
    }
}
