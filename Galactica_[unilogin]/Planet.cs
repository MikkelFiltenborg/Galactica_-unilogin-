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
            moons.Add(Luna);
            moons.Add(Titan);
            moons.Add(Phobes);
            moons.Add(Europe);
            moons.Add(Deimos);
            moons.Add(Ganymedes);
            moons.Add(Io);
            moons.Add(Mimas);
        }
    }
}
