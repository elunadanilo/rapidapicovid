using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

///<summary>
///interface .
///</summary>
///<remarks>
///Encapsulamos la tecnología empleada para acceder a la capa de datos, 
///separando completamente la lógica de negocio de la lógica de acceso a datos
///</remarks>
///
namespace RapidApiCovid.Dao
{
    interface IReportesDao
    {
        public Task<OperationResponse> GetRegionReportesAsync();
        public Task<OperationResponse> GetProvinciasRegionReporte(string region);

    }
}
