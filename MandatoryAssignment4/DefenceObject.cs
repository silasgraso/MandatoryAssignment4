using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment4
{
    public class DefenceObject : WorldObject
    {
        public int ReduceHitPoints { get; set; }
        public string Name { get; set; }

        public DefenceObject(int x, int y, bool removable, int reduceHitPoints, string name)
            : base(x, y, removable)
        {
            ReduceHitPoints = reduceHitPoints;
            Name = name;
        }
    }
}
