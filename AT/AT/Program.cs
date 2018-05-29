using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    class Program
    {
        static void Main(string[] args)
        {
            PCTypeChecker store = new PCTypeChecker(MANUFACTURERS.KING);

            store.CheckProducts();

            Console.ReadLine();

            store = new PCTypeChecker(MANUFACTURERS.LINKS);

            store.CheckProducts();
            Console.ReadLine();

            store = new PCTypeChecker(MANUFACTURERS.MSAN);

            store.CheckProducts();
            Console.Read();
        }
    }
}
