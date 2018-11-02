using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Parser.Models
{
    public class GetMshResponse
    {
        public string Status { get; set; }

        public string ResponseCode { get; set; }

        public string ResponseText { get; set; }

        public Hl7Msh Msh { get; set; }
    }
}
