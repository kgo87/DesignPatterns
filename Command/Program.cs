using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Remote Control");
            RemoteControl remoteControl = new RemoteControl();
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            Stereo livingRoomStereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(livingRoomStereo);
            StereoOffCommand stereoOff = new StereoOffCommand(livingRoomStereo);


            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl.toString());

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(1);
            remoteControl.OnButtonWasPressed(2);
            remoteControl.OffButtonWasPushed(1);


        }
    }
}
