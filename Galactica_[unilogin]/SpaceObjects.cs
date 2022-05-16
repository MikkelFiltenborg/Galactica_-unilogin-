using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica__unilogin_
{
    internal abstract class SpaceObjects
    {
        //properties.
        public string? Name { get; set; }
        public int Id { get; set; }
        //nested class.
        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }
            //override ToString().
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        //enum.
        public enum Startype
        {
            YellowDwarf, White, BlueNeutron, RedGiant
        }
    }
}
