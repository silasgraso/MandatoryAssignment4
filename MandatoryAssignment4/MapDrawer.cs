using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment4
{
    public class MapDrawer
    {
        public static void DrawMap(World world)
        {
            for (int y = 0; y < world.MaxY; y++)
            {
                for (int x = 0; x < world.MaxX; x++)
                {
                    Console.Write("[ ]");
                }
                Console.WriteLine();
            }
        }
    }
}
