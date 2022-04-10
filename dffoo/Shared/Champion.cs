using System.ComponentModel.DataAnnotations.Schema;

namespace dffoo.Shared
{
    public class Champion
    {
        public int Id { get; set; }
        public string ChampName { get; set; } = string.Empty;
        public string ChampType { get; set; } = string.Empty;
        public string ChampCrystal { get; set; } = string.Empty;
        public int ChampClevel { get; set; } = 0;

    //    public Sphere? Sphere { get; set; }
        public string ChampSphere1 { get; set; } = String.Empty;
        public string ChampSphere2 { get; set; } = String.Empty;
        public string ChampSphere3 { get; set; } = String.Empty;
        [NotMapped]
        public int[] SphereId { get; set; } = new int[3];

        // Equipment booleans
        public bool W15cp { get; set; } = false;
        public bool W35cp { get; set; } = false;
        public bool EX { get; set; } = false;
        public bool EXplus { get; set; } = false;
        public bool LD { get; set; } = false;
        public bool BT { get; set; } = false;
        public bool BTplus { get; set; } = false;
        public bool HG35 { get; set; } = false;
        public bool HG90 { get; set; } = false;
        public bool HG90plus { get; set; } = false;
        public bool HG7star { get; set; } = false;
        public bool HG7starPlus { get; set; } = false;
        public bool ManikinWeapon { get; set; } = false;
        public bool UltimaWeapon { get; set; } = false;

        //Champ Abilities
        //public Ability? Ability1 { get; set; }


        //Champ Stats
        public int HP { get; set; }
        public int IBRV{ get; set; }
        public int MBRV { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int? MaxCP { get; set; }

        //Game Info
        public Game? Game { get; set; }
        public int GameId { get; set; }
    }
}
