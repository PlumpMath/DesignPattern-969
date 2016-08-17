using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2
{
    class ConcreateStrategyB:Strategy
    {
        public override void AlgorthmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }
}
