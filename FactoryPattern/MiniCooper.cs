using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MiniCooper : IAuto
    {
        public void On()
        {
            Console.WriteLine("Mini Cooper gets turned On!!");
        }

        public void Off()
        {
            Console.WriteLine("Mini Cooper is Off!!!!");
        }
    }
}
