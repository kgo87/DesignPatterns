using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var amp = new Amplifier("My Amplifier");
            var tuner = new Tuner("My AM/FM Tuner", amp);
            var dvd = new DvdPlayer("My DVD Player", amp);
            var cd = new CdPlayer("My CD Player", amp);
            var projector = new Projector("My Projector", dvd);
            var lights = new TheaterLights("Theater Ceiling Lights");
            var screen = new Screen("Theater Screen");
            var popper = new PopcornPopper("Popcorn Popper");

            var homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, screen, lights, popper);

            homeTheater.WatchMovie("The Godfather");
            homeTheater.EndMovie();
        }
    }
}
