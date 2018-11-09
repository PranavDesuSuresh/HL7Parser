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
        int SetPid(Hl7Pid pid);

        Hl7Pid GetPid(int id);
    }
}
