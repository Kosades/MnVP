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

        private string fileName;
        private bool willReplay;

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

        public void Play(string filePath, bool replay)
        {
            fileName = filePath;
            willReplay = replay;
            Thread playThread = new Thread(PlayThread);
            playThread.Start();

            //Bass.BASS_ChannelPlay(Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT), replay);
        }

        public void StopBass()
        {
            Bass.BASS_Free();
        }

        private void Registration()
        {
            BassNet.Registration("kosades2014@gmail.com", "2X20243321152222");
        }

        void PlayThread()
        {
            Bass.BASS_ChannelPlay(Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT), willReplay);
        }
    }
}
