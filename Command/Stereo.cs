using System;
namespace Command
{
    public class Stereo
    {
        public Stereo stereo;
        public string state;
        public string source;
        public int volume;

        public Stereo(string room)
        {
        }

        public void on()
        {
            state = "on";
        }

        public void off()
        {
            state = "off";
        }

        public void setSource(string musicSource)
        {
            source = musicSource;
        }

        public void setCD()
        {
            setSource("CD");
        }

        public void setDVD()
        {
            setSource("DVD");
        }

        public void setRadio()
        {
            setSource("Radio");
        }

        public void setVolume(int volumeLevel)
        {
            volume = volumeLevel;
        }
    }
}
