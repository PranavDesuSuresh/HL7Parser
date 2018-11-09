using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Parser.WebAppBusiness
{
    public class ConfigManager
    {
        public static string ApiUrl
        {
            get
            {
                return Convert.ToString(ConfigurationManager.AppSettings["ApiUrl"]);
            }
        }
    }
}
