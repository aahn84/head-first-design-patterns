using System;
using System.Collections.Generic;
using System.Text;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.GarageDoors;
using app.HeadFirstDesignPatterns.CommandPattern.Commands.Lights;

namespace app.HeadFirstDesignPatterns.CommandPattern
{
    public static class SimpleRemoteControlTest
    {
        public static void Run()
        {
            var remote = new SimpleRemoteControl();
            var light = new Light();
            var garageDoor = new GarageDoor();
            var lightOn = new LightOnCommand(light);
            var garageOpen = new GarageDoorUpCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            Console.WriteLine();
            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();
        }
    }
}