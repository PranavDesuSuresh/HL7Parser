using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace HL7Parser.WebAppBusiness
{
    public static class JsonHelper
    {
        // Serialize Object to Json
        public static string ConvertToJson<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
        }

        //De-Serialize Json
        public static T ConvertFromJson<T>(string json)
        {
            T result = JsonConvert.DeserializeObject<T>(json);
            return result;
        }

        public enum ContentTypes
        {
            [Description("application/xml")]
            xml,
            [Description("application/json")]
            json
        };

        public static string GetDescription(Enum en)
        {
            Type type = en.GetType();
            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return Convert.ToString(en);
        }

        public static long GetEpochDTTM(int year, int month, int day)
        {
            try
            {
                DateTime dttm = new DateTime(year, month, day);

                return (dttm.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            }
            catch
            {
                return 0;
            }
        }

        public static XmlDocument ConvertJsonToXML(string ResponseAPI, string RemoveElement)
        {
            XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(ResponseAPI, RemoveElement);
            return doc;
        }

        public static string ConvertXMLToJson(string xmlDocumentPath, string RemoveElement)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlDocumentPath);
            return JsonConvert.SerializeXmlNode(doc);
        }

        public static string GetXMLAsString(string xmlDocumentPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlDocumentPath);
            return doc.OuterXml;
        }

        public static string Serialize<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch
            {
                throw;
            }
        }
    }
}
