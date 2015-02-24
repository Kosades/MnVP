using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen;
using Un4seen.Bass;

namespace MnVP
{
    class MusicPlaying
    {
        public MusicPlaying()
        {
 
        }

        ~MusicPlaying()
        {
 
        }

        public void play()
        {
            string fileName = "music.mp3";
            Bass.BASS_ChannelPlay(Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT), false);
        }
    }
}
