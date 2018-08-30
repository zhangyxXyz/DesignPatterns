using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_适配器模式_
{
    class ApePlayer : IAdvanceAudioPlayer
    {
        public void playApe(string fileName)
        {
            Console.WriteLine("Playing ape file. Name:" + fileName);
        }

        public void playWav(string fileName)
        {
            //什么也不做
            throw new NotImplementedException();
        }
    }
}
