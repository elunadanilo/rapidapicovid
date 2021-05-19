using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApiCovid.Dao
{
    interface ReportesDao
    {
        public Task<OperationResponse> GetRegionReportesAsync();
        public Task<OperationResponse> GetProvinciasRegionReporte(string region);

    }
}
