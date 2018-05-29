using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    public class PCHPType : IPCType
    {
        public string PCName()
        {
            return "HP";
        }
    }

    public class PCToshibaType : IPCType
    {
        public string PCName()
        {
            return "Toshiba";
        }
    }

    public class PCAsusType : IPCType
    {
        public string PCName()
        {
            return "Asus";
        }
    }
}
