﻿using System;
using Aircompany.Models;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {

        private readonly int passengersCapacity;
        private readonly ClassificationLevel classificationLevel;

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity, ClassificationLevel classificationLevel)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            this.passengersCapacity = passengersCapacity;
            this.classificationLevel = classificationLevel;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   passengersCapacity == plane.passengersCapacity &&
                   classificationLevel == plane.classificationLevel;
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + passengersCapacity.GetHashCode();
            hashCode = hashCode * -1521134295 + classificationLevel.GetHashCode();
            return hashCode;
        }

        public int GetPassengersCapacity()
        {
            return passengersCapacity;
        }

        public ClassificationLevel GetClassificationLevel()
        {
            return classificationLevel;
        }


        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + passengersCapacity +
                    '}');
        }

    }
}
