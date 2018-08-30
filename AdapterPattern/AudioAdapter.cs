using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_适配器模式_
{
    //高级音频播放的适配器
    class AudioAdapter : IAudioPlayer
    {
        private IAdvanceAudioPlayer advancedAudioPlayer;
        public AudioAdapter (string audioType)
        {
            if(audioType=="ape")
            {
                advancedAudioPlayer = new ApePlayer();
            }
            else if(audioType =="wav")
            {
                advancedAudioPlayer = new WavPlayer();
            }
        }

        public void player(string audioType, string fileName)
        {
            if(audioType=="ape")
            {
                advancedAudioPlayer.playApe(fileName);
            }
            else if(audioType=="wav")
            {
                advancedAudioPlayer.playWav(fileName);
            }
        }
    }
}
