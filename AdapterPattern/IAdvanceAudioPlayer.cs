using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_适配器模式_
{
    //高级音频格式播放
    public interface IAdvanceAudioPlayer
    {
        void playWav(string fileName);
        void playApe(string fileName); 
    }
}
