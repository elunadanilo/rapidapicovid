using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiCovid.Dao;
using RapidApiCovid.Models;
using RapidApiCovid.Services;

namespace RapidApiCovid.Controllers
{
    public class DownloadController : Controller
    {
        private ReportesDao reportesDao = new ReportesService();
        public IActionResult Index()
        {
            return View();
        }

        [Route("Regiones/{region}/Reporte/Json")]
        public async Task<IActionResult> JsonAsync(string region)
        {
            OperationResponse response = await reportesDao.GetProvinciasRegionReporte(region);

            if (response.Code == 1)
            {
                var content = JsonConvert.SerializeObject(response.Data, new JsonSerializerSettings());

                return File(Encoding.UTF8.GetBytes(content), "application/json", $"{region}-reporte.json");
            }

            return BadRequest();
        }

        [Route("Regiones/{region}/Reporte/Xml")]
        public async Task<IActionResult> XmlAsync(string region)
        {
            OperationResponse response = await reportesDao.GetProvinciasRegionReporte(region);

            if (response.Code == 1)
            {
                var writer = new StringWriter();
                var serializer = new XmlSerializer(typeof(List<ProvinciasCasesDeaths>));
                serializer.Serialize(writer, response.Data);
                string xml = writer.ToString();

                return File(Encoding.UTF8.GetBytes(xml), "application/xml", $"{region}-reporte.xml");
            }
            return BadRequest();
        }

        [Route("Regiones/{region}/Reporte/Csv")]
        public async Task<IActionResult> CsvAsync(string region)
        {
            OperationResponse response = await reportesDao.GetProvinciasRegionReporte(region);

            if (response.Code == 1)
            {
                using var mem = new MemoryStream();
                using var writer = new StreamWriter(mem);
                using var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);
                csvWriter.WriteRecords((List<ProvinciasCasesDeaths>)response.Data);

                writer.Flush();
                var result = Encoding.UTF8.GetString(mem.ToArray());
                /*Console.WriteLine(result);*/


                return File(Encoding.UTF8.GetBytes(result), "application/csv", $"{region}-reporte.csv");
            }
            return BadRequest();
        }

        [Route("Regiones/Reporte/Json2")]
        public async Task<IActionResult> Json2Async(string region)
        {
            OperationResponse response = await reportesDao.GetRegionReportesAsync();

            if (response.Code == 1)
            {
                var content = JsonConvert.SerializeObject(response.Data, new JsonSerializerSettings());

                return File(Encoding.UTF8.GetBytes(content), "application/json", $"regiones-reporte.json");
            }

            return BadRequest();
        }

        [Route("Regiones/Reporte/Xml2")]
        public async Task<IActionResult> Xml2Async(string region)
        {
            OperationResponse response = await reportesDao.GetRegionReportesAsync();

            if (response.Code == 1)
            {
                var writer = new StringWriter();
                var serializer = new XmlSerializer(typeof(List<RegionCasesDeaths>));
                serializer.Serialize(writer, response.Data);
                string xml = writer.ToString();

                return File(Encoding.UTF8.GetBytes(xml), "application/xml", $"regiones-reporte.xml");
            }
            return BadRequest();
        }

        [Route("Regiones/Reporte/Csv2")]
        public async Task<IActionResult> Csv2Async(string region)
        {
            OperationResponse response = await reportesDao.GetRegionReportesAsync();

            if (response.Code == 1)
            {
                using var mem = new MemoryStream();
                using var writer = new StreamWriter(mem);
                using var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture);
                csvWriter.WriteRecords((List<RegionCasesDeaths>)response.Data);

                writer.Flush();
                var result = Encoding.UTF8.GetString(mem.ToArray());


                return File(Encoding.UTF8.GetBytes(result), "application/csv", $"regiones-reporte.csv");
            }
            return BadRequest();
        }
    }
}
