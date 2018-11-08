using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Parser.Models
{
    public class ApiResponse
    {
        public string Status { get; set; }

        public string Message { get; set; }

        public string ErrorCode { get; set; }
    }
}
