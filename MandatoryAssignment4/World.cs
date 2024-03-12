using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment4
{
    public class World
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public List<Creature> Creatures { get; set; }

        public World(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
            Creatures = new List<Creature>();
        }

        public void Configure(World config)
        {
            MaxX = config.MaxX;
            MaxY = config.MaxY;
            // Optionally, you can also configure other properties of World based on the configuration
        }
    }
}
