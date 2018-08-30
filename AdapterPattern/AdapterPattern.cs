using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_适配器模式_
{
    class AdapterPattern
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.player("mp3", "beyond the horizon.mp3");
            audioPlayer.player("wav", "alone.wav");
            audioPlayer.player("ape", "my heart will go on.ape");
            audioPlayer.player("vlc", "far far away.vlc");

        }
    }
}
