using System;
namespace Command
{
    public class CeilingFan
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        public string location;
        public int speed;

        public CeilingFan(string location) 
        {
            this.location = location;
            speed = OFF;
        }

        public void HighSpeed()
        {
            speed = HIGH;
            Console.WriteLine("Set Fan to High");
        }

        public void MediumSpeed()
        {
            speed = MEDIUM;
            Console.WriteLine("Set Fan to Medium");
        }

        public void LowSpeed()
        {
            speed = LOW;
            Console.WriteLine("Set Fan to Low");
        }

        public void off()
        {
            speed = OFF;
            Console.WriteLine("Fan is off");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
