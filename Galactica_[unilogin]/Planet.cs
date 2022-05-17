using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica__unilogin_
{
    internal class Planet : SpaceObjects
    {
        //meters.
        public int Diameter { get; set; }
        //hours.
        public int RotationPeriod { get; set; }
        // days.
        public int RevolutionPeriod { get; set; } 

        //list over moons.
        public List<Moon> moons = new();

        //method for calculating distance to Star.
        public double Distance(Planet.Position planetPossition, Star.Position starPosition)
        {
            planetPossition = new();
            starPosition = new();

            double distance = Math.Sqrt(Math.Pow((starPosition.X - planetPossition.X), 2) + Math.Pow((starPosition.Y - planetPossition.Y), 2));

            return distance;
        }

        internal void MoonList()
        {
            var moons = new List<Moon>();
            {
                new Planet() { Name = "Luna", Diameter = , RevolutionPeriod = , RotationsPeriod = , Id = 0},

                new Planet() { Name = "Titan", Diameter = , RevolutionPeriod = , RotationsPeriod = , Id = 1},

                new Planet() { Name = "Phobes", Diameter = , RevolutionPeriod = , RotationsPeriod = , Id = 2},

                new Planet() { Name = "Europe", Diameter = , RevolutionPeriod = , RotationsPeriod = , Id = 3},

                new Planet() { Name = "Deimos", Diameter = , RevolutionPeriod = , RotationsPeriod = , Id = 4},

                new Planet() { Name = "Ganymedes", Diameter = , RevolutionPeriod = , RotationsPeriod = , Id = 5},

                new Planet() { Name = "Io", Diameter = , RevolutionPeriod = , RotationsPeriod = , Id = 6},

                new Planet() { Name = "Mimas", Diameter = , RevolutionPeriod = , RotationsPeriod = , Id = 7},

            }
        }
    }
}
