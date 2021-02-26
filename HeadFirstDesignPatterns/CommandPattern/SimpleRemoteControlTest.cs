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
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoorUpCommand garageOpen = new GarageDoorUpCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            Console.WriteLine();
            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();
        }
    }
}