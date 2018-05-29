using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    class HPFactory : IComputerBuild
    {
        public IPCType GetPCType()
        {
            return new PCHPType();
        }

        public IMonitorType GetMonitorType()
        {
            return new M17Type();
        }
    }

    class AsusFactory : IComputerBuild
    {
        public IPCType GetPCType()
        {
            return new PCAsusType();
        }

        public IMonitorType GetMonitorType()
        {
            return new M19Type();
        }

    }

    class ToshibaFactory : IComputerBuild
    {
        public IPCType GetPCType()
        {
            return new PCToshibaType();
        }

        public IMonitorType GetMonitorType()
        {
            return new M15Type();
        }

    }
}
