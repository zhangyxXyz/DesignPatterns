using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo_策略模式_
{
    class AirPlaneStrategy : ITravelStrategy
    {
        public void TravelAlgorithm()
        {
            Console.WriteLine("AirPlane is routing means of transportation!");
        }
    }
}
