using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HL7Parser.Business.Entities
{
    public class ApiException : Exception
    {
        private readonly HttpStatusCode statusCode;
        private readonly string errorMessage;

        public ApiException(HttpStatusCode statusCode, string message, string errorMessage)
            : base(errorMessage + message)
        {
            this.statusCode = statusCode;
            this.errorMessage = errorMessage;
        }

        public ApiException(HttpStatusCode statusCode)
        {
            this.statusCode = statusCode;
            this.errorMessage = statusCode.ToString();
        }

        public HttpStatusCode StatusCode
        {
            get { return this.statusCode; }
        }
        public string ErrorMessage
        {
            get { return this.errorMessage; }
        }
    }
}
