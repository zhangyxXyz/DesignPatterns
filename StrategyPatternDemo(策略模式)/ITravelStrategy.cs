using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo_策略模式_
{
    //出行方式的实现接口
    interface ITravelStrategy
    {
        void TravelAlgorithm();
    }
}
