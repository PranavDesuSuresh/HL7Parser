using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using HL7Parser.Models;

namespace HL7Parser.Batch
{
    public class BatchBusiness
    {
        private static BatchBusiness instance = null;

        private BatchBusiness()
        {
        }

        public static BatchBusiness Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BatchBusiness();
                }
                return instance;
            }
        }

        public void convertToHL7(string filePath)
        {
            string readContents = "";
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                readContents = streamReader.ReadToEnd();
            }

            var hl7Msg = readContents.Split(new string[] { "\r\n" }, StringSplitOptions.None).Select(x => x.Split('|')).ToArray();

            foreach (var seg in hl7Msg)
            {
                if (seg != null && seg.Length > 0)
                {
                    Hl7Msh msh = new Hl7Msh();
                    Hl7Pid pid = new Hl7Pid();
                    switch (seg[0])
                    {
                        case "MSH":
                            msh = ConvertToMsh(seg);
                            break;
                        case "PID":
                            pid = ConvertToPid(seg);
                            break;
                        default:
                            break;
                    }

                    //if (msh != null) ;
                    ApiManager apiManager = new ApiManager();
                    apiManager.PostMsh(msh, ConfigManager.ApiUrl + "msh/AddMsh/");
                }
            }
        }

        public Hl7Msh ConvertToMsh(string[] msh)
        {
            Hl7Msh mshSeg = new Hl7Msh();
            mshSeg.Msh1 = GetArrayElement(msh, 1);
            mshSeg.Msh2 = GetArrayElement(msh, 2);

            string[] msh3 = GetArrayElement(msh, 3).Split('^');
            mshSeg.Msh3_1 = GetArrayElement(msh3, 0);
            mshSeg.Msh3_2 = GetArrayElement(msh3, 1);
            mshSeg.Msh3_3 = GetArrayElement(msh3, 2);

            string[] msh4 = GetArrayElement(msh, 4).Split('^');
            mshSeg.Msh4_1 = GetArrayElement(msh4, 0);
            mshSeg.Msh4_2 = GetArrayElement(msh4, 1);
            mshSeg.Msh4_3 = GetArrayElement(msh4, 2);

            string[] msh5 = GetArrayElement(msh, 5).Split('^');
            mshSeg.Msh5_1 = GetArrayElement(msh5, 0);
            mshSeg.Msh5_2 = GetArrayElement(msh5, 1);
            mshSeg.Msh5_3 = GetArrayElement(msh5, 2);

            string[] msh6 = GetArrayElement(msh, 6).Split('^');
            mshSeg.Msh6_1 = GetArrayElement(msh6, 0);
            mshSeg.Msh6_2 = GetArrayElement(msh6, 1);
            mshSeg.Msh6_3 = GetArrayElement(msh6, 2);
            mshSeg.Msh7 = GetArrayElement(msh, 7);
            mshSeg.Msh8 = GetArrayElement(msh, 8);

            string[] msh9 = GetArrayElement(msh, 9).Split('^');
            mshSeg.Msh9_1 = GetArrayElement(msh9, 0);
            mshSeg.Msh9_2 = GetArrayElement(msh9, 1);
            mshSeg.Msh10 = GetArrayElement(msh, 10);

            string[] msh11 = GetArrayElement(msh, 11).Split('^');
            mshSeg.Msh11_1 = GetArrayElement(msh11, 0);
            mshSeg.Msh11_2 = GetArrayElement(msh11, 1);
            mshSeg.Msh12 = GetArrayElement(msh, 12);
            mshSeg.Msh13 = GetArrayElement(msh, 13);
            mshSeg.Msh14 = GetArrayElement(msh, 14);
            mshSeg.Msh15 = GetArrayElement(msh, 15);
            mshSeg.Msh16 = GetArrayElement(msh, 16);
            mshSeg.Msh17 = GetArrayElement(msh, 17);
            mshSeg.Msh18 = GetArrayElement(msh, 18);
            mshSeg.Msh19 = GetArrayElement(msh, 19);

            return mshSeg;
        }

        public Hl7Pid ConvertToPid(string[] pid)
        {
            Hl7Pid pidSeg = new Hl7Pid();
            pidSeg.Pid1 = GetArrayElement(pid, 1);
            pidSeg.Pid2 = GetArrayElement(pid, 2);
            pidSeg.Pid3 = GetArrayElement(pid, 3);
            pidSeg.Pid4 = GetArrayElement(pid, 4);

            string[] pid5 = GetArrayElement(pid, 5).Split('^');
            pidSeg.Pid5_1 = GetArrayElement(pid5, 0);
            pidSeg.Pid5_2 = GetArrayElement(pid5, 1);
            pidSeg.Pid5_3 = GetArrayElement(pid5, 2);
            pidSeg.Pid5_4 = GetArrayElement(pid5, 3);
            pidSeg.Pid5_5 = GetArrayElement(pid5, 4);
            pidSeg.Pid5_6 = GetArrayElement(pid5, 6);

            string[] pid6 = GetArrayElement(pid, 6).Split('^');
            pidSeg.Pid6_1 = GetArrayElement(pid6, 0);
            pidSeg.Pid6_2 = GetArrayElement(pid6, 1);
            pidSeg.Pid6_3 = GetArrayElement(pid6, 2);
            pidSeg.Pid6_4 = GetArrayElement(pid6, 3);
            pidSeg.Pid6_5 = GetArrayElement(pid6, 4);
            pidSeg.Pid6_6 = GetArrayElement(pid6, 5);
            pidSeg.Pid6_7 = GetArrayElement(pid6, 6);

            pidSeg.Pid7 = GetArrayElement(pid, 7);
            pidSeg.Pid8 = GetArrayElement(pid, 8);

            string[] pid9 = GetArrayElement(pid, 9).Split('^');
            pidSeg.Pid9_1 = GetArrayElement(pid9, 0);
            pidSeg.Pid9_2 = GetArrayElement(pid9, 1);
            pidSeg.Pid9_3 = GetArrayElement(pid9, 2);
            pidSeg.Pid9_4 = GetArrayElement(pid9, 3);
            pidSeg.Pid9_5 = GetArrayElement(pid9, 4);
            pidSeg.Pid9_6 = GetArrayElement(pid9, 5);
            pidSeg.Pid9_7 = GetArrayElement(pid9, 6);

            pidSeg.Pid10 = GetArrayElement(pid, 10);

            string[] pid11 = GetArrayElement(pid, 11).Split('^');
            pidSeg.Pid11_1 = GetArrayElement(pid11, 0);
            pidSeg.Pid11_2 = GetArrayElement(pid11, 1);
            pidSeg.Pid11_3 = GetArrayElement(pid11, 2);
            pidSeg.Pid11_4 = GetArrayElement(pid11, 3);
            pidSeg.Pid11_5 = GetArrayElement(pid11, 4);
            pidSeg.Pid11_6 = GetArrayElement(pid11, 5);
            pidSeg.Pid11_7 = GetArrayElement(pid11, 6);
            pidSeg.Pid11_8 = GetArrayElement(pid11, 7);
            pidSeg.Pid11_9 = GetArrayElement(pid11, 8);

            pidSeg.Pid12 = GetArrayElement(pid, 12);

            string[] pid13 = GetArrayElement(pid, 13).Split('^');
            pidSeg.Pid13_1 = GetArrayElement(pid13, 0);
            pidSeg.Pid13_2 = GetArrayElement(pid13, 1);
            pidSeg.Pid13_3 = GetArrayElement(pid13, 2);
            pidSeg.Pid13_4 = GetArrayElement(pid13, 3);

            string[] pid14 = GetArrayElement(pid, 14).Split('^');
            pidSeg.Pid14_1 = GetArrayElement(pid14, 0);
            pidSeg.Pid14_2 = GetArrayElement(pid14, 1);
            pidSeg.Pid14_3 = GetArrayElement(pid14, 2);
            pidSeg.Pid14_4 = GetArrayElement(pid14, 3);

            string[] pid15 = GetArrayElement(pid, 15).Split('^');
            pidSeg.Pid15_1 = GetArrayElement(pid15, 0);
            pidSeg.Pid15_2 = GetArrayElement(pid15, 1);

            pidSeg.Pid16 = GetArrayElement(pid, 16);
            pidSeg.Pid17 = GetArrayElement(pid, 17);
            pidSeg.Pid18 = GetArrayElement(pid, 18);
            pidSeg.Pid19 = GetArrayElement(pid, 19);
            pidSeg.Pid20 = GetArrayElement(pid, 20);
            pidSeg.Pid21 = GetArrayElement(pid, 21);
            pidSeg.Pid22 = GetArrayElement(pid, 22);
            pidSeg.Pid23 = GetArrayElement(pid, 23);
            pidSeg.Pid24 = GetArrayElement(pid, 24);
            pidSeg.Pid25 = GetArrayElement(pid, 25);
            pidSeg.Pid26 = GetArrayElement(pid, 26);
            pidSeg.Pid27 = GetArrayElement(pid, 27);
            pidSeg.Pid28 = GetArrayElement(pid, 28);
            pidSeg.Pid29 = GetArrayElement(pid, 29);
            pidSeg.Pid30 = GetArrayElement(pid, 30);
            return pidSeg;
        }

        private string GetArrayElement(string[] arr, int index)
        {
            return arr.ElementAtOrDefault(index);
        }
    }
}
