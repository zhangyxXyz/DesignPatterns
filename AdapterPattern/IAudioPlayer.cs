using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_适配器模式_
{
    public interface IAudioPlayer
    {
        void player(string audioType, string fileName);
    }
}
