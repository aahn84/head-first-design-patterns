using System;
using System.Collections.Generic;
using System.Text;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.CeilingFans;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.GarageDoors;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.Stereos;

namespace app.HeadFirstDesignPatterns.CommandPattern
{
    public class RemoteLoaderWithUndo
    {
        public static void Run()
        {
            var remoteControl = new RemoteControlWithUndo();

            var livingRoomLight = new Light("Living Room");
            var ceilingFan = new CeilingFan("Living Room");

            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);

            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine();
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine();
            Console.WriteLine(remoteControl);
            Console.WriteLine();
            remoteControl.UndoButtonWasPushed(0);
            Console.WriteLine();
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine();
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine();
            Console.WriteLine(remoteControl);
            Console.WriteLine();
            remoteControl.UndoButtonWasPushed(0);
            Console.WriteLine();

            remoteControl.OnButtonWasPushed(1);
            Console.WriteLine();
            remoteControl.OffButtonWasPushed(1);
            Console.WriteLine();
            Console.WriteLine(remoteControl);
            Console.WriteLine();
            remoteControl.UndoButtonWasPushed(1);
            Console.WriteLine();

            remoteControl.OnButtonWasPushed(2);
            Console.WriteLine();
            remoteControl.OffButtonWasPushed(2);
            Console.WriteLine();
            Console.WriteLine(remoteControl);
            Console.WriteLine();
            remoteControl.UndoButtonWasPushed(2);
            Console.WriteLine();
        }
    }
}