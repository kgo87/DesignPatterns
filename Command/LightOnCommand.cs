using System;
namespace Command
{
    public class LightOnCommand: Command
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.on();
        }

        public void Undo()
        {
            light.off();
        }
    }
}
