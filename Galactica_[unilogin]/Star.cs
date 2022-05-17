using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica__unilogin_
{
    internal class Star : SpaceObjects
    {
        //properties.
        public Startype Type { get; set; }
        public double Temperature { get; set; }

        //list over planets.
        List<Planet> planets = new();

        //set cordinates for sun 0,0??

        //enum.
        public enum PlanetType
        {
            Terrestrial, Ice_Giant, Dwarf, Gas_Giant
        }

        internal void PlanetList()
        {
            var planets = new List<Planet>();
            {
                new Planet() { Name = "Mercury", Diameter = 4879, RevolutionPeriod = 88, RotationsPeriod = 1416, Id = 0, Type = PlanetType.Terrestrial,
                Position = new SpaceObjects.Position = ( X = 0, Y = 1 )},

                new Planet() { Name = "Venus", Diameter = 12104, RevolutionPeriod = 225, RotationsPeriod = 5832, Id = 1, Type = PlanetType.Terrestrial,
                Position = new SpaceObjects.Position = (X = 1, Y = 2)},

                new Planet() { Name = "Earth", Diameter = 12742, RevolutionPeriod = 365, RotationsPeriod = 24, Id = 2, Type = PlanetType.Terrestrial,
                Position = new SpaceObjects.Position = (X = 2, Y = 3)},

                new Planet() { Name = "Mars", Diameter = 6779, RevolutionPeriod = 687, RotationsPeriod = 25, Id = 3, Type = PlanetType.Terrestrial,
                Position = new SpaceObjects.Position = (X = 3, Y = 4 )},

                new Planet() { Name = "Jupiter", Diameter = 139820, RevolutionPeriod = 4377, RotationsPeriod = 9925, Id = 4, Type = PlanetType.Gas_Giant,
                Position = new SpaceObjects.Position = (X = 4, Y = 5 )},

                new Planet() { Name = "Saturn", Diameter = 116460, RevolutionPeriod = 10578, RotationsPeriod = 11, Id = 5, Type = PlanetType.Gas_Giant,
                Position = new SpaceObjects.Position = (X = 5, Y = 6)},

                new Planet() { Name = "Uranus", Diameter = 50724, RevolutionPeriod = 30639, RotationsPeriod = 17, Id = 6, Type = PlanetType.Ice_Giant,
                Position = new SpaceObjects.Position = (X = 6, Y = 7)},

                new Planet() { Name = "Neptune", Diameter = 49244, RevolutionPeriod = 60184, RotationsPeriod = 16, Id = 7, Type = PlanetType.Ice_Giant,
                Position = new SpaceObjects.Position = (X = 7, Y = 8)},
            }
        }
    }
}
