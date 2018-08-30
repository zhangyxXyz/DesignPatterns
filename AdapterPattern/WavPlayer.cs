using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_适配器模式_
{
    class WavPlayer : IAdvanceAudioPlayer
    {
        public void playApe(string fileName)
        {
            //什么也不做
            throw new NotImplementedException();
        }

        public void playWav(string fileName)
        {
            Console.WriteLine("Playing wav file. Name:" + fileName);
        }
    }
}