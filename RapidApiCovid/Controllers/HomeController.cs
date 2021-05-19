using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RapidApiCovid.Dao;
using RapidApiCovid.Models;
using RapidApiCovid.Services;

namespace RapidApiCovid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ReportesDao reportesDao = new ReportesService();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Home/Regiones/{region}/Reporte")]
        public async Task<IActionResult> ReporteAsync(string region)
        {
            OperationResponse response = await reportesDao.GetProvinciasRegionReporte(region);
            OperationResponse responseRegions = await reportesDao.GetRegionReportesAsync();

            ViewData["provincias"] = response.Data;
            ViewData["regiones"] = responseRegions.Data;
            ViewBag.Region = region;

            if(response.Code==1)
                return View();
            return View();
        }

        public async Task<IActionResult> RegionesAsync()
        {
            OperationResponse response=await reportesDao.GetRegionReportesAsync();
            if(response.Code==1)
                return View(response.Data);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
