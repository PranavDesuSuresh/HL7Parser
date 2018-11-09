using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Parser.Models;

namespace HL7Parser.WebAppBusiness
{
    public class PidManager
    {
        public Hl7Pid GetPidDetails(int id)
        {
            ApiResponse apiResponse = new ApiResponse();

            apiResponse = ApiCommunicator.CallApi(ConfigManager.ApiUrl + "pid/GetPid/" + id
                , "", "GET", "application/json");

            if (apiResponse.Status == "Success")
            {
                if (!string.IsNullOrEmpty(apiResponse.Message))
                    return JsonHelper.ConvertFromJson<Hl7Pid>(apiResponse.Message);
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public int SetPidDetails(Hl7Pid pid)
        {
            ApiResponse apiResponse = new ApiResponse();

            SetPidRequest objRequest = new SetPidRequest();
            objRequest.Params = pid;

            apiResponse = ApiCommunicator.CallApi(ConfigManager.ApiUrl + "pid/AddPid", JsonHelper.ConvertToJson(objRequest), "POST",
                "application/json");

            if (apiResponse.Status == "Success")
            {
                if (!string.IsNullOrEmpty(apiResponse.Message))
                    return JsonHelper.ConvertFromJson<int>(apiResponse.Message);
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
