using System;
namespace Command
{
    public class StereoOnWithCDCommand: Command
    {
        Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }
    }
}
