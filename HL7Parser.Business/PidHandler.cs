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

        public int SetPid(Hl7Pid pid)
        {
            int id = -1;
            if (DataProvider == null)
                DataProvider = new DataProvider();

            try
            {
                DataProvider.SetPid(pid);

                //objResponse.Id =id;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return id;
        }

        public Hl7Pid GetPid(int id)
        {
            if (DataProvider == null)
                DataProvider = new DataProvider();

            Hl7Pid pidItem = null;
            try
            {
                DataTable dtPid = DataProvider.GetPid(id);
                if (dtPid != null && dtPid.Rows.Count >= 1)
                {
                    DataRow dr = dtPid.Rows[0];
                    pidItem = new Hl7Pid
                    {
                        //ID = Convert.ToInt32(dr["ID"]),
                        PatientId = Convert.ToInt32(dr["PatientID"]),
                        Pid1 = Convert.ToString(dr["PID_1"]),
                        Pid2 = Convert.ToString(dr["PID_2"]),
                        Pid3 = Convert.ToString(dr["PID_3"]),
                        Pid4 = Convert.ToString(dr["PID_4"]),
                        Pid5_1 = Convert.ToString(dr["PID_5_1"]),
                        Pid5_2 = Convert.ToString(dr["PID_5_2"]),
                        Pid5_3 = Convert.ToString(dr["PID_5_3"]),
                        Pid5_4 = Convert.ToString(dr["PID_5_4"]),
                        Pid5_5 = Convert.ToString(dr["PID_5_5"]),
                        Pid5_6 = Convert.ToString(dr["PID_5_6"]),
                        Pid6_1 = Convert.ToString(dr["PID_6_1"]),
                        Pid6_2 = Convert.ToString(dr["PID_6_2"]),
                        Pid6_3 = Convert.ToString(dr["PID_6_3"]),
                        Pid6_4 = Convert.ToString(dr["PID_6_4"]),
                        Pid6_5 = Convert.ToString(dr["PID_6_5"]),
                        Pid6_6 = Convert.ToString(dr["PID_6_6"]),
                        Pid6_7 = Convert.ToString(dr["PID_6_7"]),
                        Pid7 = Convert.ToString(dr["PID_7"]),
                        Pid8 = Convert.ToString(dr["PID_8"]),
                        Pid9_1 = Convert.ToString(dr["PID_9_1"]),
                        Pid9_2 = Convert.ToString(dr["PID_9_2"]),
                        Pid9_3 = Convert.ToString(dr["PID_9_3"]),
                        Pid9_4 = Convert.ToString(dr["PID_9_4"]),
                        Pid9_5 = Convert.ToString(dr["PID_9_5"]),
                        Pid9_6 = Convert.ToString(dr["PID_9_6"]),
                        Pid9_7 = Convert.ToString(dr["PID_9_7"]),
                        Pid10 = Convert.ToString(dr["PID_10"]),
                        Pid11_1 = Convert.ToString(dr["PID_11_1"]),
                        Pid11_2 = Convert.ToString(dr["PID_11_2"]),
                        Pid11_3 = Convert.ToString(dr["PID_11_3"]),
                        Pid11_4 = Convert.ToString(dr["PID_11_4"]),
                        Pid11_5 = Convert.ToString(dr["PID_11_5"]),
                        Pid11_6 = Convert.ToString(dr["PID_11_6"]),
                        Pid11_7 = Convert.ToString(dr["PID_11_7"]),
                        Pid11_8 = Convert.ToString(dr["PID_11_8"]),
                        Pid11_9 = Convert.ToString(dr["PID_11_9"]),
                        Pid12 = Convert.ToString(dr["PID_12"]),
                        Pid13_1 = Convert.ToString(dr["PID_13_1"]),
                        Pid13_2 = Convert.ToString(dr["PID_13_2"]),
                        Pid13_3 = Convert.ToString(dr["PID_13_3"]),
                        Pid13_4 = Convert.ToString(dr["PID_13_4"]),
                        Pid14_1 = Convert.ToString(dr["PID_14_1"]),
                        Pid14_2 = Convert.ToString(dr["PID_14_2"]),
                        Pid14_3 = Convert.ToString(dr["PID_14_3"]),
                        Pid14_4 = Convert.ToString(dr["PID_14_4"]),
                        Pid15_1 = Convert.ToString(dr["PID_15_1"]),
                        Pid15_2 = Convert.ToString(dr["PID_15_2"]),
                        Pid16 = Convert.ToString(dr["PID_16"]),
                        Pid17 = Convert.ToString(dr["PID_17"]),
                        Pid18 = Convert.ToString(dr["PID_18"]),
                        Pid19 = Convert.ToString(dr["PID_19"]),
                        Pid20 = Convert.ToString(dr["PID_20"]),
                        Pid21 = Convert.ToString(dr["PID_21"]),
                        Pid22 = Convert.ToString(dr["PID_22"]),
                        Pid23 = Convert.ToString(dr["PID_23"]),
                        Pid24 = Convert.ToString(dr["PID_24"]),
                        Pid25 = Convert.ToString(dr["PID_25"]),
                        Pid26 = Convert.ToString(dr["PID_26"]),
                        Pid27 = Convert.ToString(dr["PID_27"]),
                        Pid28 = Convert.ToString(dr["PID_28"]),
                        Pid29 = Convert.ToString(dr["PID_29"]),
                        Pid30 = Convert.ToString(dr["PID_30"])
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pidItem;
        }
    }
}
