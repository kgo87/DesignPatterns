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
            CeilingFan ceilingFan = new CeilingFan("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(livingRoomStereo);
            StereoOffCommand stereoOff = new StereoOffCommand(livingRoomStereo);

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
         

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, stereoOnWithCD, stereoOff);
            remoteControl.SetCommand(3, ceilingFanHigh, ceilingFanOff);


            Console.WriteLine(remoteControl.toString());

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(1);
            remoteControl.OnButtonWasPressed(2);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(3);


        }
    }
}
