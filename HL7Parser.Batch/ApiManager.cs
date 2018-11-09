using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Parser.Models;

namespace HL7Parser.Batch
{
    public class ApiManager
    {
        public void PostMsh(Hl7Msh msh,string url)
        {
            ApiResponse apiResponse = new ApiResponse();

            SetMshRequest objRequest = new SetMshRequest();
            objRequest.Params = msh;

            apiResponse = ApiCommunicator.CallApi(url, JsonHelper.ConvertToJson(objRequest), "POST",
                "application/json");
        }

        public void PostPid(Hl7Pid pid, string url)
        {
            ApiResponse apiResponse = new ApiResponse();

            SetPidRequest objRequest = new SetPidRequest();
            objRequest.Params = pid;

            apiResponse = ApiCommunicator.CallApi(url, JsonHelper.ConvertToJson(objRequest), "POST",
                "application/json");
        }
    }
}
