using System;
namespace Command
{
    public class CeilingFanHighCommand: Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.HighSpeed();
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
