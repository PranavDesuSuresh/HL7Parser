using System;
using System.Configuration;

namespace HL7Parser.Batch
{
    public class ConfigManager
    {
        public static string FilePath
        {
            get
            {
                return Convert.ToString(ConfigurationManager.AppSettings["FilePath"]);
            }
        }

        public static string ApiUrl
        {
            get
            {
                return Convert.ToString(ConfigurationManager.AppSettings["ApiUrl"]);
            }
        }
    }
}
