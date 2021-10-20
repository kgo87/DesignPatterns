using System;
namespace Command
{
    public class StereoOffCommand: Command
    {
        Stereo stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.setVolume(0);
            stereo.off();
        }

        public void Undo()
        {
            stereo.on();
            stereo.setVolume(11);
        }

    }
}
