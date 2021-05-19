using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApiCovid
{
    public class OperationResponse
    {
        public int Code { get; set; }
        public Object Data { get; set; }

        public OperationResponse(int code=0, object data=null)
        {
            Code = code;
            Data = data;
        }
    }
}
