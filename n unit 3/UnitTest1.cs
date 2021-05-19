using NUnit.Framework;
using RapidApiCovid;
using RapidApiCovid.Services;

namespace n_unit_3
{
    public class Tests
    {
        private ReportesService reportesService;
        [SetUp]
        public void Setup()
        {
            reportesService = new ReportesService();
        }

        [Test]
        public async System.Threading.Tasks.Task Test1Async()
        {
            OperationResponse response = await reportesService.GetRegionReportesAsync();

            Assert.AreEqual(1, response.Code, "No se obtuvieron los reportes por region");
        }

        [Test]
        public async System.Threading.Tasks.Task Test2Async()
        {
            OperationResponse response = await reportesService.GetProvinciasRegionReporte("United Kingdom");

            Assert.AreEqual(1, response.Code, "No se obtuvieron los reportes de provincias por region");
        }
    }
}