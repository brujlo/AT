using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    enum MANUFACTURERS
    {
        KING,
        LINKS,
        MSAN
    }

    class PCTypeChecker
    {
        //IPCType pc;
        //IMonitorType monitor;
        IComputerBuild factory;
        MANUFACTURERS manu;

        public PCTypeChecker(MANUFACTURERS m)
        {
            manu = m;
        }

        public void CheckProducts()
        {
            switch (manu)
            {
                case MANUFACTURERS.KING:
                    factory = new HPFactory();
                    break;
                case MANUFACTURERS.LINKS:
                    factory = new AsusFactory();
                    break;
                case MANUFACTURERS.MSAN:
                    factory = new ToshibaFactory();
                    break;
            }

            Console.WriteLine("Retailer: " + manu.ToString() + ":\nMmanufacturer: " + factory.GetPCType().PCName() + "\nDisplay: " + factory.GetMonitorType().MName());
        }

    }
}
