using MandatoryAssignment4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment4
{
    public class Creature : IAttackable, ILootable, IDefendable
    {
        public List<AttackItem> AttackItems { get; set; }
        public List<DefenceObject> DefenceObjects { get; set; }
        public int HitPoints { get; set; }

        public Creature(int hitPoints)
        {
            HitPoints = hitPoints;
            AttackItems = new List<AttackItem>();
            DefenceObjects = new List<DefenceObject>();
        }

        public void Hit(Creature target)
        {
        }

        public void Loot(Creature looter)
        {
        }

        public void ReceiveHit(int damage)
        {
            HitPoints -= damage;
            if (HitPoints <= 0)
            {
                Console.WriteLine("Creature has died!");
            }
        }
    }
}
