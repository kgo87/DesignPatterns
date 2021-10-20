using System;
namespace Command
{
    public class LightOffCommand: Command
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.off();
        }

        public void Undo()
        {
            light.on();
        }
    }
}
