using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Parser.Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            ScanFiles();
            //File.Move(fileToMove, moveTo);

        }

        private static void ScanFiles()
        {
            string[] fileInfo = Directory.GetFiles(ConfigManager.FilePath + "\\IN", "*.*", SearchOption.AllDirectories);
            foreach (string fileName in fileInfo)
            {
                BatchBusiness.Instance.convertToHL7(fileName);
            }
        }
    }
}
