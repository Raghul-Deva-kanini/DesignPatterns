﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class BikeFamilyFactory:VehicleFamilfyFactory
    {
        public override VehicleFactory CreateBikeFactory()
        {
            return new BikeFactory();
        }

        public override VehicleFactory CreateCarFactory()
        {
            return new CarFactory();
        }
    }
}
