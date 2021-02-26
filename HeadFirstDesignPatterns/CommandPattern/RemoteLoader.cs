using System;
using System.Collections.Generic;
using System.Text;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.CeilingFans;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.GarageDoors;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.Stereos;

namespace app.HeadFirstDesignPatterns.CommandPattern
{
    public class RemoteLoader
    {
        public static void Run()
        {
            var remoteControl = new RemoteControl();

            var livingRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor("");
            var stereo = new Stereo("Living Room");

            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);

            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);

            var ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            var garageDoorUp = new GarageDoorUpCommand(garageDoor);
            var garageDoorDown = new GarageDoorDownCommand(garageDoor);

            var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl);
            Console.WriteLine();

            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine();
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(1);
            Console.WriteLine();
            remoteControl.OffButtonWasPushed(1);
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(2);
            Console.WriteLine();
            remoteControl.OffButtonWasPushed(2);
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(3);
            Console.WriteLine();
            remoteControl.OffButtonWasPushed(3);
        }
    }
}