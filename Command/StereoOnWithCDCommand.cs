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

        public void Undo()
        {
            stereo.setVolume(0);
            stereo.off();
        }
    }
}
