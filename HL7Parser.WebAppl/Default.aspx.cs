using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HL7Parser.Models;
using HL7Parser.WebAppBusiness;

namespace HL7Parser.WebAppl
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMshsearch_Click(object sender, EventArgs e)
        {

        }

        protected void btnPidsearch_Click(object sender, EventArgs e)
        {
            PidManager pidManager = new PidManager();
            Hl7Pid pid = pidManager.GetPidDetails(Convert.ToInt32(txtPatientId.Value));
            if (pid != null)
            {
                txtPidID.Value = Convert.ToString(pid.ID);
                txtPid_1.Value = pid.Pid1;
                txtPid_2.Value = pid.Pid2;
                txtPid_3.Value = pid.Pid3;
                txtPid_4.Value = pid.Pid4;
                txtPid_5_1.Value = pid.Pid5_1;
                txtPid_5_2.Value = pid.Pid5_2;
                txtPid_5_3.Value = pid.Pid5_3;
                txtPid_5_4.Value = pid.Pid5_4;
                txtPid_5_5.Value = pid.Pid5_5;
                txtPid_5_6.Value = pid.Pid5_6;
                txtPid_6_1.Value = pid.Pid6_1;
                txtPid_6_2.Value = pid.Pid6_2;
                txtPid_6_3.Value = pid.Pid6_3;
                txtPid_6_4.Value = pid.Pid6_4;
                txtPid_6_5.Value = pid.Pid6_5;
                txtPid_6_6.Value = pid.Pid6_6;
                txtPid_6_7.Value = pid.Pid6_7;
                txtPid_7.Value = pid.Pid7;
                txtPid_8.Value = pid.Pid8;
                txtPid_9_1.Value = pid.Pid9_1;
                txtPid_9_2.Value = pid.Pid9_2;
                txtPid_9_3.Value = pid.Pid9_3;
                txtPid_9_4.Value = pid.Pid9_4;
                txtPid_9_5.Value = pid.Pid9_5;
                txtPid_9_6.Value = pid.Pid9_6;
                txtPid_9_7.Value = pid.Pid9_7;
                txtPid_10.Value = pid.Pid10;
                txtPid_11_1.Value = pid.Pid11_1;
                txtPid_11_2.Value = pid.Pid11_2;
                txtPid_11_3.Value = pid.Pid11_3;
                txtPid_11_4.Value = pid.Pid11_4;
                txtPid_11_5.Value = pid.Pid11_5;
                txtPid_11_6.Value = pid.Pid11_6;
                txtPid_11_7.Value = pid.Pid11_7;
                txtPid_11_8.Value = pid.Pid11_8;
                txtPid_11_9.Value = pid.Pid11_9;
                txtPid_12.Value = pid.Pid12;
                txtPid_13_1.Value = pid.Pid13_1;
                txtPid_13_2.Value = pid.Pid13_2;
                txtPid_13_3.Value = pid.Pid13_3;
                txtPid_13_4.Value = pid.Pid13_4;
                txtPid_14_1.Value = pid.Pid14_1;
                txtPid_14_2.Value = pid.Pid14_2;
                txtPid_14_3.Value = pid.Pid14_3;
                txtPid_14_4.Value = pid.Pid14_4;
                txtPid_15_1.Value = pid.Pid15_1;
                txtPid_15_2.Value = pid.Pid15_2;
                txtPid_16.Value = pid.Pid16;
                txtPid_17.Value = pid.Pid17;
                txtPid_18.Value = pid.Pid18;
                txtPid_19.Value = pid.Pid19;
                txtPid_20.Value = pid.Pid20;
                txtPid_21.Value = pid.Pid21;
                txtPid_22.Value = pid.Pid22;
                txtPid_23.Value = pid.Pid23;
                txtPid_24.Value = pid.Pid24;
                txtPid_25.Value = pid.Pid25;
                txtPid_26.Value = pid.Pid26;
                txtPid_27.Value = pid.Pid27;
                txtPid_28.Value = pid.Pid28;
                txtPid_29.Value = pid.Pid29;
                txtPid_30.Value = pid.Pid30;
            }
        }

        protected void btnMshSave_Click1(object sender, EventArgs e)
        {

        }

        protected void btnPidsave_Click1(object sender, EventArgs e)
        {
            Hl7Pid pid = new Hl7Pid();
            pid.PatientId = Convert.ToInt32(txtPatientId.Value);
            pid.Pid1 = txtPid_1.Value;
            pid.Pid2 = txtPid_2.Value;
            pid.Pid3 = txtPid_3.Value;
            pid.Pid4 = txtPid_4.Value;
            pid.Pid5_1 = txtPid_5_1.Value;
            pid.Pid5_2 = txtPid_5_2.Value;
            pid.Pid5_3 = txtPid_5_3.Value;
            pid.Pid5_4 = txtPid_5_4.Value;
            pid.Pid5_5 = txtPid_5_5.Value;
            pid.Pid5_6 = txtPid_5_6.Value;
            pid.Pid6_1 = txtPid_6_1.Value;
            pid.Pid6_2 = txtPid_6_2.Value;
            pid.Pid6_3 = txtPid_6_3.Value;
            pid.Pid6_4 = txtPid_6_4.Value;
            pid.Pid6_5 = txtPid_6_5.Value;
            pid.Pid6_6 = txtPid_6_6.Value;
            pid.Pid6_7 = txtPid_6_7.Value;
            pid.Pid7 = txtPid_7.Value;
            pid.Pid8 = txtPid_8.Value;
            pid.Pid9_1 = txtPid_9_1.Value;
            pid.Pid9_2 = txtPid_9_2.Value;
            pid.Pid9_3 = txtPid_9_3.Value;
            pid.Pid9_4 = txtPid_9_4.Value;
            pid.Pid9_5 = txtPid_9_5.Value;
            pid.Pid9_6 = txtPid_9_6.Value;
            pid.Pid9_7 = txtPid_9_7.Value;
            pid.Pid10 = txtPid_10.Value;
            pid.Pid11_1 = txtPid_11_1.Value;
            pid.Pid11_2 = txtPid_11_2.Value;
            pid.Pid11_3 = txtPid_11_3.Value;
            pid.Pid11_4 = txtPid_11_4.Value;
            pid.Pid11_5 = txtPid_11_5.Value;
            pid.Pid11_6 = txtPid_11_6.Value;
            pid.Pid11_7 = txtPid_11_7.Value;
            pid.Pid11_8 = txtPid_11_8.Value;
            pid.Pid11_9 = txtPid_11_9.Value;
            pid.Pid12 = txtPid_12.Value;
            pid.Pid13_1 = txtPid_13_1.Value;
            pid.Pid13_2 = txtPid_13_2.Value;
            pid.Pid13_3 = txtPid_13_3.Value;
            pid.Pid13_4 = txtPid_13_4.Value;
            pid.Pid14_1 = txtPid_14_1.Value;
            pid.Pid14_2 = txtPid_14_2.Value;
            pid.Pid14_3 = txtPid_14_3.Value;
            pid.Pid14_4 = txtPid_14_4.Value;
            pid.Pid15_1 = txtPid_15_1.Value;
            pid.Pid15_2 = txtPid_15_2.Value;
            pid.Pid16 = txtPid_16.Value;
            pid.Pid17 = txtPid_17.Value;
            pid.Pid18 = txtPid_18.Value;
            pid.Pid19 = txtPid_19.Value;
            pid.Pid20 = txtPid_20.Value;
            pid.Pid21 = txtPid_21.Value;
            pid.Pid22 = txtPid_22.Value;
            pid.Pid23 = txtPid_23.Value;
            pid.Pid24 = txtPid_24.Value;
            pid.Pid25 = txtPid_25.Value;
            pid.Pid26 = txtPid_26.Value;
            pid.Pid27 = txtPid_27.Value;
            pid.Pid28 = txtPid_28.Value;
            pid.Pid29 = txtPid_29.Value;
            pid.Pid30 = txtPid_30.Value;

            PidManager pidManager = new PidManager();
            pidManager.SetPidDetails(pid);
        }
    }
}