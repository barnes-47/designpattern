﻿using Dp.Creational.AbstractFactory.Auto.Base;
using static System.Console;

namespace Dp.Creational.AbstractFactory.Auto.Luxury
{
    public class VolvoLuxury : Car
    {
        public VolvoLuxury(string name)
            : base(name)
        {

        }

        public override void TurnOn()
        {
            base.TurnOn();
            WriteLine($"The seats adjust as per the person's height and weight.");
        }
    }
}
