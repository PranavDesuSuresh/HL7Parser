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
    public class MshHandler : IHl7Msh
    {
        private IDataProvider DataProvider;
        
        public PostResponse SetMsh(Hl7Msh msh)
        {
            int id = -1;
            PostResponse objResponse = new PostResponse();
            if (DataProvider == null)
                DataProvider = new DataProvider();

            try
            {
                DataProvider.SetMsh(msh);

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

        public GetMshResponse GetMsh(int id)
        {
            GetMshResponse objResponse = new GetMshResponse();
            Hl7Msh mshItem = null;
            try
            {
                DataTable dtMsh = DataProvider.GetMsh(id);
                if (dtMsh != null && dtMsh.Rows.Count >= 1)
                {
                    DataRow dr = dtMsh.Rows[0];
                    mshItem = new Hl7Msh();
                    mshItem.ID      =   Convert.ToInt32(dr["ID"]);
                    mshItem.Msh1    = Convert.ToString(dr["MSH_1"]);
                    mshItem.Msh2    = Convert.ToString(dr["MSH_2"]);
                    mshItem.Msh3_1  = Convert.ToString(dr["MSH_3_1"]);
                    mshItem.Msh3_2  = Convert.ToString(dr["MSH_3_2"]);
                    mshItem.Msh3_3  = Convert.ToString(dr["MSH_3_3"]);
                    mshItem.Msh4_1  = Convert.ToString(dr["MSH_4_1"]);
                    mshItem.Msh4_2  = Convert.ToString(dr["MSH_4_2"]);
                    mshItem.Msh4_3  = Convert.ToString(dr["MSH_4_3"]);
                    mshItem.Msh5_1  = Convert.ToString(dr["MSH_5_1"]);
                    mshItem.Msh5_2  = Convert.ToString(dr["MSH_5_2"]);
                    mshItem.Msh5_3  = Convert.ToString(dr["MSH_5_3"]);
                    mshItem.Msh6_1  = Convert.ToString(dr["MSH_6_1"]);
                    mshItem.Msh6_2  = Convert.ToString(dr["MSH_6_2"]);
                    mshItem.Msh6_3  = Convert.ToString(dr["MSH_6_3"]);
                    mshItem.Msh7    = Convert.ToString(dr["MSH_7"]);
                    mshItem.Msh8    = Convert.ToString(dr["MSH_8"]);
                    mshItem.Msh9_1  = Convert.ToString(dr["MSH_9_1"]);
                    mshItem.Msh9_2  = Convert.ToString(dr["MSH_9_2"]);
                    mshItem.Msh10   = Convert.ToString(dr["MSH_10"]);
                    mshItem.Msh11_1 = Convert.ToString(dr["MSH_11_1"]);
                    mshItem.Msh11_2 = Convert.ToString(dr["MSH_11_2"]);
                    mshItem.Msh12   = Convert.ToString(dr["MSH_12"]);
                    mshItem.Msh13   = Convert.ToString(dr["MSH_13"]);
                    mshItem.Msh14   = Convert.ToString(dr["MSH_14"]);
                    mshItem.Msh15   = Convert.ToString(dr["MSH_15"]);
                    mshItem.Msh16   = Convert.ToString(dr["MSH_16"]);
                    mshItem.Msh17   = Convert.ToString(dr["MSH_17"]);
                    mshItem.Msh18   = Convert.ToString(dr["MSH_18"]);
                    mshItem.Msh19   = Convert.ToString(dr["MSH_19"]);
                }

                objResponse.Status = "Success";
                objResponse.Msh = mshItem;
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
