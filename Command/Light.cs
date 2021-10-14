using System;
namespace Command
{
    public class Light
    {
        public Light light;
        public string state;

        public void on()
        {
            state = "on";
        }
        public void off()
        {
            state = "off";
        }

    }
}
