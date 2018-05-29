using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    public interface IComputerBuild
    {
        IPCType GetPCType();
        IMonitorType GetMonitorType();
    }
}
