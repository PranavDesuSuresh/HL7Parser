using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Parser.Models;

namespace HL7Parser.Data
{
    public interface IDataProvider
    {
        DataTable GetPid(int id);

        DataTable GetMsh(int id);

        int SetPid(Hl7Pid pidContent);

        int SetMsh(Hl7Msh mshContent);
    }
}
