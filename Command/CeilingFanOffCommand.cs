using System;
namespace Command
{
    public class CeilingFanOffCommand: Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.off();
        }

        public void Undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
            {
                ceilingFan.HighSpeed();
            }
            else if (prevSpeed == CeilingFan.MEDIUM)
            {
                ceilingFan.MediumSpeed();
            }
            else if (prevSpeed == CeilingFan.LOW)
            {
                ceilingFan.LowSpeed();
            }
            else
            {
                ceilingFan.off();
            }
        }
    }
}
