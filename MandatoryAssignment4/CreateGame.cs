using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment4
{
    public class CreateGame
    {
        public void Run()
        {
            ConfigurationReader reader = new ConfigurationReader();
            World config = reader.ReadConfiguration("config.json");

            World world = new World(config.MaxX, config.MaxY);

            MapDrawer.DrawMap(world);
        }
    }
}
