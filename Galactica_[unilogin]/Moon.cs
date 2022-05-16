using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica__unilogin_
{
    internal abstract class Moon : Planet
    {
        //properties.
        public string? Orbiting { get; set; } //Planet.

        public double Distance(Planet.Position planetPossition, Moon.Position moonPosition)
        {
            planetPossition = new();
            moonPosition = new();

            double distance = Math.Sqrt(Math.Pow((moonPosition.X - planetPossition.X), 2) + Math.Pow((moonPosition.Y - planetPossition.Y), 2));

            return distance;
        }
    }
}
