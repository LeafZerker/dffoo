using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dffoo.Shared
{
    public class Equip
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        //public Game? Game { get; set; }
        //public Champion? Champion { get; set; }
        public string AffinityAbilityName { get; set; } = string.Empty;
        public string AffinityAbilityDescription { get; set; } = String.Empty;
        public int AffinityAbilityCPCost { get; set; }
        public int HPBoost { get; set; }
        public int IBrvBoost { get; set; }
        public int MBrvBoost { get; set; }
        public int AtkBoost { get; set; }
        public int DefBoost { get; set; }
        public int MaxCP { get; set; }
        //public Sphere? MaxSphere { get; set; }

        public string PassiveName { get; set; } = String.Empty;
        public string PassiveDescription { get; set; } = String.Empty;

    }
}
