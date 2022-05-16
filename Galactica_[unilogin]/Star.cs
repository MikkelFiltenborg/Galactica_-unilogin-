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
            Terrestial, Giant, Dwarf, Gas_Giant
        }

        internal void PlanetList()
        {
            var planets = new List<Planet>();
            planets.Add(Mercury);
            planets.Add(Venus);
            planets.Add(Earth);
            planets.Add(Mars);
            planets.Add(Jupiter);
            planets.Add(Saturn);
            planets.Add(Uranus);
            planets.Add(Neptune);
        }
    }
}
