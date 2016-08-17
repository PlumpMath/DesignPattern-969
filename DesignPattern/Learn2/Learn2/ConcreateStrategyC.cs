using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2
{
    class ConcreateStrategyC:Strategy
    {
        public override void AlgorthmInterface()
        {
            Console.WriteLine("算法C实现");
        }
    }
}
