using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Parser.Models;

namespace HL7Parser.Business
{
    public interface IHl7Msh
    {
        PostResponse SetMsh(Hl7Msh msh);

        GetMshResponse GetMsh(int id);
    }
}
