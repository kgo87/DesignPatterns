using System;
namespace Singleton
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler _uniqueInstance;
        public bool Empty { get; private set; }
        public bool Boil { get; private set; }
        public bool Fill { get; private set; }

        private ChocolateBoiler()
        {
            Empty = true;
            Boil = false;
            Fill = false;
        }

        public static ChocolateBoiler Instance
        {
            get
            {
                if (_uniqueInstance == null)
                {
                    Console.WriteLine("Creating unique instance of Chocolate Boiler");
                    _uniqueInstance = new ChocolateBoiler();
                }
                Console.WriteLine("Returning instance of Chocolate Boiler");
                return _uniqueInstance;
            }
        }

        public void FillBoiler()
        {
            if (Empty)
            {
                Fill = true;
                Empty = false;
                Boil = false;
            }
        }

        public void Drain()
        {
            if (!Empty && Fill)
            {
                Fill = false;
                Empty = true;
            }
        }

        public void BoilMixture()
        {
            if (!Empty && !Fill && !Boil)
            {
                Boil = true;
            }
        }
    }
}
