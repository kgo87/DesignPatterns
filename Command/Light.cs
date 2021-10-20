using System;
namespace Command
{
    public class Light
    {
        public Light light;
        public string state;

        public Light(string room)
        {
        }

        public void on()
        {
            state = "on";
            Console.WriteLine("Light is on");
        }
        public void off()
        {
            state = "off";
            Console.WriteLine("Light is off");
        }

    }
}
