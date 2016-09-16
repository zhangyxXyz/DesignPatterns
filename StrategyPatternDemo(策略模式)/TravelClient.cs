using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo_策略模式_
{
    class TravelClient
    {
        static void Main(string[] args)
        {
            //飞机出行
            Context travelContext = new Context(new AirPlaneStrategy());
            travelContext.TravelMethod();
            //骑自行车出行
            travelContext = new Context(new BicycleStrategy());
            travelContext.TravelMethod();
            //坐火车出行
            travelContext = new Context(new TrainStrategy());
            travelContext.TravelMethod();
        }
    }
}
