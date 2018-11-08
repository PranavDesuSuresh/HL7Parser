using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using HL7Parser.Models;

namespace HL7Parser.Batch
{
    public static class ApiCommunicator
    {
        public static ApiResponse CallApi(string url, string param, string methodType, string contentType)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                CookieContainer cookieContainer = new CookieContainer();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = methodType;
                request.ContentType = contentType;
                request.ContentLength = param.Length;
                request.KeepAlive = false;
                request.Timeout = 200000;   //2 mins  

                ServicePointManager.ServerCertificateValidationCallback = new
                RemoteCertificateValidationCallback
                (
                   delegate { return true; }
                );
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;

                if (methodType == "POST" || methodType == "PUT")
                {
                    using (Stream webStream = request.GetRequestStream())
                    using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
                    {
                        requestWriter.Write(param);
                    }
                }

                try
                {
                    WebResponse webResponse = request.GetResponse();
                    using (Stream webStream = webResponse.GetResponseStream())
                    {
                        if (webStream != null)
                        {
                            //XmlTextReader reader = new XmlTextReader(webStream);
                            using (StreamReader responseReader = new StreamReader(webStream))
                            {
                                response.Message = responseReader.ReadToEnd();
                                response.Message = response.Message.Replace("<boolean>", "").Replace("</boolean>", "");
                            }

                            if (response.Message == "false")
                                response.Status = "Failure";
                            else
                                response.Status = "Success";
                            return response;
                        }
                    }
                }
                catch (WebException ex)
                {
                    if (ex.Response != null)
                    {
                        using (HttpWebResponse errorResponse = (HttpWebResponse)ex.Response)
                        {
                            using (StreamReader reader = new StreamReader(errorResponse.GetResponseStream()))
                            {
                                string sError = reader.ReadToEnd();

                                response.Message = "bad request :" + sError;
                                response.Status = "Failure";
                                return response;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    response.Message = Convert.ToString(e.Message);
                    response.Status = "Failure";
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Message = Convert.ToString(ex.Message);
                response.Status = "Failure";
                return response;
            }
            return response;
        }
    }
}
