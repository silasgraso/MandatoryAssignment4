using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment4
{
    public class AttackItem : WorldObject
    {
        public int HitPoints { get; set; }
        public int Range { get; set; }
        public string Name { get; set; }

        public AttackItem(int x, int y, bool removable, int hitPoints, int range, string name)
            : base(x, y, removable)
        {
            HitPoints = hitPoints;
            Range = range;
            Name = name;
        }
    }
}
