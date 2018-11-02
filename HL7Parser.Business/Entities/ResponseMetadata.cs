using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HL7Parser.Business.Entities
{
    public class ResponseMetadata
    {
        public HttpStatusCode StatusCode { get; set; }

        public string StatusDescription
        {
            get
            {
                return StatusCode.ToString();
            }
        }

        public string ErrorMessage { get; set; }

        public object Response { get; set; }
    }
}
