using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn2
{
    /// <summary>
    /// 具体算法B
    /// </summary>
    class ConcreteStrategyA:Strategy
    {
        public override void AlgorthmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }
}
