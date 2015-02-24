using System;
using System.Threading;
using Un4seen.Bass;

namespace MnVP
{
    class MusicPlayer
    {
        private int device;
        private int freq;
        private BASSInit flags;

        public MusicPlayer(int deviceNumber, int soundFreq, BASSInit playFlags)
        {
            // Construcor
            device = deviceNumber;
            freq = soundFreq;
            flags = playFlags;
        }

        ~MusicPlayer()
        {
            // Destructor
            Bass.BASS_Free();
        }

        public void RunBass()
        {
            Registration();
            Bass.BASS_Init(device, freq, flags, IntPtr.Zero);
        }

        public void Play(string fileName, bool replay)
        {
            /*while ((Bass.BASS_ChannelPlay(Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT), replay)) != true)
            {
                //Thread.Sleep(200);
            } */

            Bass.BASS_ChannelPlay(Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT), replay);
        }

        public void StopBass()
        {
            Bass.BASS_Free();
        }

        private void Registration()
        {
            BassNet.Registration("kosades2014@gmail.com", "2X20243321152222");
        }
    }
}
