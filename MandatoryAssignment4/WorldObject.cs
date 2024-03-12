using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment4
{
    public class WorldObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Removable { get; set; }

        public WorldObject(int x, int y, bool removable)
        {
            X = x;
            Y = y;
            Removable = removable;
        }
    }
}
