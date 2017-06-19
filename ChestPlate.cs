using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStore
{
    public class ChestPlate : Item
    {
        public float HealthModifier { get; set; }

        public ChestPlate(float health)
        {
            HealthModifier = health;
        }
    }
}
