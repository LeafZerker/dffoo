namespace dffoo.Shared
{
    public class Champion
    {
        public int Id { get; set; }
        public string ChampName { get; set; } = string.Empty;
        public string ChampType { get; set; } = string.Empty;
        public string ChampCrystal { get; set; } = string.Empty;
        public int ChampClevel { get; set; } = 0;

        public string ChampSphere1 { get; set; } = string.Empty;
        public string ChampSphere2 { get; set; } = string.Empty;
        public string ChampSphere3 { get; set; } = string.Empty;

        // Equipment booleans
        public bool W15cp { get; set; }
        public bool W35cp { get; set; }
        public bool EX { get; set; }
        public bool EXplus { get; set; }
        public bool LD { get; set; }
        public bool BT { get; set; }
        public bool BTplus { get; set; }
        public bool HG35 { get; set; }
        public bool HG90 { get; set; }
        public bool HG90plus { get; set; }
        public bool HG7star { get; set; }
        public bool HG7starPlus { get; set; }


        //Champ Stats
        public int HP { get; set; }
        public int IBRV{ get; set; }
        public int MBRV { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }

        //Game Info
        public Game? Game { get; set; }
        public int GameId { get; set; }
    }
}
