using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Parser.Models;
using HL7Parser.Data;
using System.Data;

namespace HL7Parser.Business
{
    public class PidHandler : IHl7Pid
    {
        private IDataProvider DataProvider;

        public PostResponse SetPid(Hl7Pid pid)
        {
            int id = -1;
            PostResponse objResponse = new PostResponse();
            if (DataProvider == null)
                DataProvider = new DataProvider();

            try
            {
                DataProvider.SetPid(pid);

                objResponse.Status = "Success";
                //objResponse.Id =id;
            }
            catch (Exception ex)
            {
                objResponse.Status = "Failure";
                objResponse.ResponseText = ex.Message;
            }

            return objResponse;
        }

        public GetPidResponse GetPid(int id)
        {
            GetPidResponse objResponse = new GetPidResponse();
            Hl7Pid pidItem = null;
            try
            {
                DataTable dtPid = DataProvider.GetPid(id);
                if (dtPid != null && dtPid.Rows.Count >= 1)
                {
                    DataRow dr = dtPid.Rows[0];
                    pidItem = new Hl7Pid();
                    pidItem.ID = Convert.ToInt32(dr["ID"]);
                    pidItem.Pid1 = Convert.ToString(dr["PID_1"]);
                    pidItem.Pid2 = Convert.ToString(dr["PID_2"]);
                    pidItem.Pid3 = Convert.ToString(dr["PID_3"]);
                    pidItem.Pid4 = Convert.ToString(dr["PID_4"]);
                    pidItem.Pid5_1 = Convert.ToString(dr["PID_5_1"]);
                    pidItem.Pid5_2 = Convert.ToString(dr["PID_5_2"]);
                    pidItem.Pid5_3 = Convert.ToString(dr["PID_5_3"]);
                    pidItem.Pid5_4 = Convert.ToString(dr["PID_5_4"]);
                    pidItem.Pid5_5 = Convert.ToString(dr["PID_5_5"]);
                    pidItem.Pid5_6 = Convert.ToString(dr["PID_5_6"]);
                    pidItem.Pid6_1 = Convert.ToString(dr["PID_6_1"]);
                    pidItem.Pid6_2 = Convert.ToString(dr["PID_6_2"]);
                    pidItem.Pid6_3 = Convert.ToString(dr["PID_6_3"]);
                    pidItem.Pid6_4 = Convert.ToString(dr["PID_6_4"]);
                    pidItem.Pid6_5 = Convert.ToString(dr["PID_6_5"]);
                    pidItem.Pid6_6 = Convert.ToString(dr["PID_6_6"]);
                    pidItem.Pid6_7 = Convert.ToString(dr["PID_6_7"]);
                    pidItem.Pid7 = Convert.ToString(dr["PID_7"]);
                    pidItem.Pid8 = Convert.ToString(dr["PID_8"]);
                    pidItem.Pid9_1 = Convert.ToString(dr["PID_9_1"]);
                    pidItem.Pid9_2 = Convert.ToString(dr["PID_9_2"]);
                    pidItem.Pid9_3 = Convert.ToString(dr["PID_9_3"]);
                    pidItem.Pid9_4 = Convert.ToString(dr["PID_9_4"]);
                    pidItem.Pid9_5 = Convert.ToString(dr["PID_9_5"]);
                    pidItem.Pid9_6 = Convert.ToString(dr["PID_9_6"]);
                    pidItem.Pid9_7 = Convert.ToString(dr["PID_9_7"]);
                    pidItem.Pid10 = Convert.ToString(dr["PID_10"]);
                    pidItem.Pid11_1 = Convert.ToString(dr["PID_11_1"]);
                    pidItem.Pid11_2 = Convert.ToString(dr["PID_11_2"]);
                    pidItem.Pid11_3 = Convert.ToString(dr["PID_11_3"]);
                    pidItem.Pid11_4 = Convert.ToString(dr["PID_11_4"]);
                    pidItem.Pid11_5 = Convert.ToString(dr["PID_11_5"]);
                    pidItem.Pid11_6 = Convert.ToString(dr["PID_11_6"]);
                    pidItem.Pid11_7 = Convert.ToString(dr["PID_11_7"]);
                    pidItem.Pid11_8 = Convert.ToString(dr["PID_11_8"]);
                    pidItem.Pid11_9 = Convert.ToString(dr["PID_11_9"]);
                    pidItem.Pid12 = Convert.ToString(dr["PID_12"]);
                    pidItem.Pid13_1 = Convert.ToString(dr["PID_13_1"]);
                    pidItem.Pid13_2 = Convert.ToString(dr["PID_13_2"]);
                    pidItem.Pid13_3 = Convert.ToString(dr["PID_13_3"]);
                    pidItem.Pid13_4 = Convert.ToString(dr["PID_13_4"]);
                    pidItem.Pid14_1 = Convert.ToString(dr["PID_14_1"]);
                    pidItem.Pid14_2 = Convert.ToString(dr["PID_14_2"]);
                    pidItem.Pid14_3 = Convert.ToString(dr["PID_14_3"]);
                    pidItem.Pid14_4 = Convert.ToString(dr["PID_14_4"]);
                    pidItem.Pid15_1 = Convert.ToString(dr["PID_15_1"]);
                    pidItem.Pid15_2 = Convert.ToString(dr["PID_15_2"]);
                    pidItem.Pid16 = Convert.ToString(dr["PID_16"]);
                    pidItem.Pid17 = Convert.ToString(dr["PID_17"]);
                    pidItem.Pid18 = Convert.ToString(dr["PID_18"]);
                    pidItem.Pid19 = Convert.ToString(dr["PID_19"]);
                    pidItem.Pid20 = Convert.ToString(dr["PID_20"]);
                    pidItem.Pid21 = Convert.ToString(dr["PID_21"]);
                    pidItem.Pid22 = Convert.ToString(dr["PID_22"]);
                    pidItem.Pid23 = Convert.ToString(dr["PID_23"]);
                    pidItem.Pid24 = Convert.ToString(dr["PID_24"]);
                    pidItem.Pid25 = Convert.ToString(dr["PID_25"]);
                    pidItem.Pid26 = Convert.ToString(dr["PID_26"]);
                    pidItem.Pid27 = Convert.ToString(dr["PID_27"]);
                    pidItem.Pid28 = Convert.ToString(dr["PID_28"]);
                    pidItem.Pid29 = Convert.ToString(dr["PID_29"]);
                    pidItem.Pid30 = Convert.ToString(dr["PID_30"]);
                }
                objResponse.Status = "Success";
                objResponse.Pid = pidItem;
            }
            catch (Exception ex)
            {
                objResponse.Status = "Failure";
                objResponse.ResponseText = ex.Message;
            }

            return objResponse;
        }
    }
}
