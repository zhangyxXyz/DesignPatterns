using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_适配器模式_
{
    class AudioPlayer : IAudioPlayer
    {
        private AudioAdapter audioAdapter;
        public void player(string audioType, string fileName)
        {
            if(audioType=="mp3")
            {
                Console.WriteLine("Playing mp3 file. Name:" + fileName);
            }
            else if(audioType=="ape"||audioType=="wav")
            {
                audioAdapter = new AudioAdapter(audioType);
                audioAdapter.player(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid audio. " + audioType + " format not supported");
            }
        }
    }
}
