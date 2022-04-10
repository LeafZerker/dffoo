using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dffoo.Shared
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int DmgPercentage { get; set; }
        public int CPCost { get; set; }
        public string? SkillID { get; set; } = string.Empty; 
        public Champion? Champion { get; set; }
        public int? ChampId { get; set; }
    }
}
