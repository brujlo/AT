using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    class M15Type : IMonitorType
    {
        public string MName()
        {
            return "15'";
        }
    }

    class M17Type : IMonitorType
    {
        public string MName()
        {
            return "17'";
        }
    }

    class M19Type : IMonitorType
    {
        public string MName()
        {
            return "19'";
        }
    }
}
