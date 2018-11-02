using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Parser.Models;

namespace HL7Parser.Business
{
    public interface IHl7Pid
    {
        PostResponse SetPid(Hl7Pid pid);

        GetPidResponse GetPid(int id);
    }
}
