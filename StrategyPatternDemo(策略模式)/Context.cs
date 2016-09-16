using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo_策略模式_
{
    //环境类，具体实现何种方式的职责 由客户端承担
    //（传入travelStrategy ）动态的使用封装的算法
    class Context
    {
        private ITravelStrategy travelStrategy = null;
        public Context(ITravelStrategy travelStrategy)
        {
            this.travelStrategy = travelStrategy;
        }
        public void TravelMethod()
        {
            travelStrategy.TravelAlgorithm();
        }
    }
}
