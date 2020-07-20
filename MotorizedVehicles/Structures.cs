﻿using Enumerations;
using MotorizedVehicles;

namespace Structures
{
    public struct Automobile 
    {
        private bool isDriving;
        public EngineType EngineType;
        public int NoOfTires;
        public string Brakes;
        public string Transmission;
        public bool Driving()
        {
            return this.isDriving;
        }
        public void SetDriving(bool driving)
        {
            this.isDriving = driving;
        }

    }
}
