using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Parser.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace HL7Parser.Data
{
    public class DataProvider: IDataProvider
    {
        private Database database;



        /// <summary>
        /// Constructor to initialize the db connection.
        /// </summary>
        public DataProvider()
        {
            database = new DatabaseProviderFactory().CreateDefault();
        }

        public DataTable GetPid(int id)
        {
            DataTable pidItem = null;
            try
            {
                using (DbCommand spCommand = database.GetStoredProcCommand("GetPid"))
                {
                    database.AddInParameter(spCommand, "@ID", DbType.Int32, id);
                    pidItem = database.ExecuteDataSet(spCommand).Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //logger if any
            }
            return pidItem;
        }

        public DataTable GetMsh(int id)
        {
            DataTable mshItem = null;
            try
            {
                using (DbCommand spCommand = database.GetStoredProcCommand("GetMsh"))
                {
                    database.AddInParameter(spCommand, "@ID", DbType.Int32, id);
                    mshItem = database.ExecuteDataSet(spCommand).Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //logger if any
            }
            return mshItem;
        }

        public int SetPid(Hl7Pid pidContent)
        {
            int Id = -1;
            try
            {
                using (DbCommand spCommand = database.GetStoredProcCommand("SetPid"))
                {
                    database.AddInParameter(spCommand, "@ID", DbType.Int32, pidContent.ID);
                    database.AddInParameter(spCommand, "@PatientID", DbType.Int32, pidContent.PatientId);
                    database.AddInParameter(spCommand, "@PID_1 ", DbType.String, pidContent.Pid1);
                    database.AddInParameter(spCommand, "@PID_2", DbType.String, pidContent.Pid2);
                    database.AddInParameter(spCommand, "@PID_3 ", DbType.String, pidContent.Pid3);
                    database.AddInParameter(spCommand, "@PID_4", DbType.String, pidContent.Pid4);
                    database.AddInParameter(spCommand, "@PID_5_1", DbType.String, pidContent.Pid5_1);
                    database.AddInParameter(spCommand, "@PID_5_2", DbType.String, pidContent.Pid5_2);
                    database.AddInParameter(spCommand, "@PID_5_3", DbType.String, pidContent.Pid5_3);
                    database.AddInParameter(spCommand, "@PID_5_4", DbType.String, pidContent.Pid5_4);
                    database.AddInParameter(spCommand, "@PID_5_5", DbType.String, pidContent.Pid5_5);
                    database.AddInParameter(spCommand, "@PID_5_6", DbType.String, pidContent.Pid5_6);
                    database.AddInParameter(spCommand, "@PID_6_1", DbType.String, pidContent.Pid6_1);
                    database.AddInParameter(spCommand, "@PID_6_2", DbType.String, pidContent.Pid6_2);
                    database.AddInParameter(spCommand, "@PID_6_3", DbType.String, pidContent.Pid6_3);
                    database.AddInParameter(spCommand, "@PID_6_4", DbType.String, pidContent.Pid6_4);
                    database.AddInParameter(spCommand, "@PID_6_5", DbType.String, pidContent.Pid6_5);
                    database.AddInParameter(spCommand, "@PID_6_6", DbType.String, pidContent.Pid6_6);
                    database.AddInParameter(spCommand, "@PID_6_7", DbType.String, pidContent.Pid6_7);
                    database.AddInParameter(spCommand, "@PID_7", DbType.String, pidContent.Pid7);
                    database.AddInParameter(spCommand, "@PID_8 ", DbType.String, pidContent.Pid8);
                    database.AddInParameter(spCommand, "@PID_9_1", DbType.String, pidContent.Pid9_1);
                    database.AddInParameter(spCommand, "@PID_9_2", DbType.String, pidContent.Pid9_2);
                    database.AddInParameter(spCommand, "@PID_9_3", DbType.String, pidContent.Pid9_3);
                    database.AddInParameter(spCommand, "@PID_9_4", DbType.String, pidContent.Pid9_4);
                    database.AddInParameter(spCommand, "@PID_9_5", DbType.String, pidContent.Pid9_5);
                    database.AddInParameter(spCommand, "@PID_9_6", DbType.String, pidContent.Pid9_6);
                    database.AddInParameter(spCommand, "@PID_9_7", DbType.String, pidContent.Pid9_7);
                    database.AddInParameter(spCommand, "@PID_10", DbType.String, pidContent.Pid10);
                    database.AddInParameter(spCommand, "@PID_11_1", DbType.String, pidContent.Pid11_1);
                    database.AddInParameter(spCommand, "@PID_11_2", DbType.String, pidContent.Pid11_2);
                    database.AddInParameter(spCommand, "@PID_11_3", DbType.String, pidContent.Pid11_3);
                    database.AddInParameter(spCommand, "@PID_11_4", DbType.String, pidContent.Pid11_4);
                    database.AddInParameter(spCommand, "@PID_11_5", DbType.String, pidContent.Pid11_5);
                    database.AddInParameter(spCommand, "@PID_11_6", DbType.String, pidContent.Pid11_6);
                    database.AddInParameter(spCommand, "@PID_11_7", DbType.String, pidContent.Pid11_7);
                    database.AddInParameter(spCommand, "@PID_11_8", DbType.String, pidContent.Pid11_8);
                    database.AddInParameter(spCommand, "@PID_11_9", DbType.String, pidContent.Pid11_9);
                    database.AddInParameter(spCommand, "@PID_12", DbType.String, pidContent.Pid12);
                    database.AddInParameter(spCommand, "@PID_13_1", DbType.String, pidContent.Pid13_1);
                    database.AddInParameter(spCommand, "@PID_13_2", DbType.String, pidContent.Pid13_2);
                    database.AddInParameter(spCommand, "@PID_13_3", DbType.String, pidContent.Pid13_3);
                    database.AddInParameter(spCommand, "@PID_13_4", DbType.String, pidContent.Pid13_4);
                    database.AddInParameter(spCommand, "@PID_14_1", DbType.String, pidContent.Pid14_1);
                    database.AddInParameter(spCommand, "@PID_14_2", DbType.String, pidContent.Pid14_2);
                    database.AddInParameter(spCommand, "@PID_14_3", DbType.String, pidContent.Pid14_3);
                    database.AddInParameter(spCommand, "@PID_14_4", DbType.String, pidContent.Pid14_4);
                    database.AddInParameter(spCommand, "@PID_15_1", DbType.String, pidContent.Pid15_1);
                    database.AddInParameter(spCommand, "@PID_15_2", DbType.String, pidContent.Pid15_2);
                    database.AddInParameter(spCommand, "@PID_16", DbType.String, pidContent.Pid16);
                    database.AddInParameter(spCommand, "@PID_17", DbType.String, pidContent.Pid17);
                    database.AddInParameter(spCommand, "@PID_18", DbType.String, pidContent.Pid18);
                    database.AddInParameter(spCommand, "@PID_19", DbType.String, pidContent.Pid19);
                    database.AddInParameter(spCommand, "@PID_20", DbType.String, pidContent.Pid20);
                    database.AddInParameter(spCommand, "@PID_21", DbType.String, pidContent.Pid21);
                    database.AddInParameter(spCommand, "@PID_22", DbType.String, pidContent.Pid22);
                    database.AddInParameter(spCommand, "@PID_23", DbType.String, pidContent.Pid23);
                    database.AddInParameter(spCommand, "@PID_24", DbType.String, pidContent.Pid24);
                    database.AddInParameter(spCommand, "@PID_25", DbType.String, pidContent.Pid25);
                    database.AddInParameter(spCommand, "@PID_26", DbType.String, pidContent.Pid26);
                    database.AddInParameter(spCommand, "@PID_27", DbType.String, pidContent.Pid27);
                    database.AddInParameter(spCommand, "@PID_28", DbType.String, pidContent.Pid28);
                    database.AddInParameter(spCommand, "@PID_29", DbType.String, pidContent.Pid29);
                    database.AddInParameter(spCommand, "@PID_30", DbType.String, pidContent.Pid30);
                    //database.AddOutParameter(spCommand, "@NotificationID", DbType.Int32, Int32.MaxValue);
                    database.ExecuteScalar(spCommand);
                    //Id = (Int32)database.GetParameterValue(spCommand, "@NotificationID");
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //logger if any
            }

            return Id;
        }

        public int SetMsh(Hl7Msh mshContent)
        {
            int Id = -1;
            try
            {
                using (DbCommand spCommand = database.GetStoredProcCommand("SetMsh"))
                {
                    database.AddInParameter(spCommand, "@ID", DbType.Int32, mshContent.ID);
                    database.AddInParameter(spCommand, "@PatientID", DbType.Int32, mshContent.PatientId);
                    database.AddInParameter(spCommand, "@MSH_1", DbType.String, mshContent.Msh1);
                    database.AddInParameter(spCommand, "@MSH_2", DbType.String, mshContent.Msh2);
                    database.AddInParameter(spCommand, "@MSH_3_1", DbType.String, mshContent.Msh3_1);
                    database.AddInParameter(spCommand, "@MSH_3_2", DbType.String, mshContent.Msh3_2);
                    database.AddInParameter(spCommand, "@MSH_3_3", DbType.String, mshContent.Msh3_3);
                    database.AddInParameter(spCommand, "@MSH_4_1", DbType.String, mshContent.Msh4_1);
                    database.AddInParameter(spCommand, "@MSH_4_2", DbType.String, mshContent.Msh4_2);
                    database.AddInParameter(spCommand, "@MSH_4_3", DbType.String, mshContent.Msh4_3);
                    database.AddInParameter(spCommand, "@MSH_5_1", DbType.String, mshContent.Msh5_1);
                    database.AddInParameter(spCommand, "@MSH_5_2", DbType.String, mshContent.Msh5_2);
                    database.AddInParameter(spCommand, "@MSH_5_3", DbType.String, mshContent.Msh5_3);
                    database.AddInParameter(spCommand, "@MSH_6_1", DbType.String, mshContent.Msh6_1);
                    database.AddInParameter(spCommand, "@MSH_6_2", DbType.String, mshContent.Msh6_2);
                    database.AddInParameter(spCommand, "@MSH_6_3", DbType.String, mshContent.Msh6_3);
                    database.AddInParameter(spCommand, "@MSH_7", DbType.String, mshContent.Msh7);
                    database.AddInParameter(spCommand, "@MSH_8", DbType.String, mshContent.Msh8);
                    database.AddInParameter(spCommand, "@MSH_9_1", DbType.String, mshContent.Msh9_1);
                    database.AddInParameter(spCommand, "@MSH_9_2", DbType.String, mshContent.Msh9_2);
                    database.AddInParameter(spCommand, "@MSH_10 ", DbType.String, mshContent.Msh10);
                    database.AddInParameter(spCommand, "@MSH_11_1  ", DbType.String, mshContent.Msh11_1);
                    database.AddInParameter(spCommand, "@MSH_11_2  ", DbType.String, mshContent.Msh11_2);
                    database.AddInParameter(spCommand, "@MSH_12 ", DbType.String, mshContent.Msh12);
                    database.AddInParameter(spCommand, "@MSH_13 ", DbType.String, mshContent.Msh13);
                    database.AddInParameter(spCommand, "@MSH_14 ", DbType.String, mshContent.Msh14);
                    database.AddInParameter(spCommand, "@MSH_15 ", DbType.String, mshContent.Msh15);
                    database.AddInParameter(spCommand, "@MSH_16 ", DbType.String, mshContent.Msh16);
                    database.AddInParameter(spCommand, "@MSH_17 ", DbType.String, mshContent.Msh17);
                    database.AddInParameter(spCommand, "@MSH_18 ", DbType.String, mshContent.Msh18);
                    database.AddInParameter(spCommand, "@MSH_19 ", DbType.String, mshContent.Msh19);

                    //database.AddOutParameter(spCommand, "@NotificationID", DbType.Int32, Int32.MaxValue);
                    database.ExecuteScalar(spCommand);
                    //Id = (Int32)database.GetParameterValue(spCommand, "@NotificationID");
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //logger if any
            }

            return Id;
        }
    }
}
