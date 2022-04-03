namespace dffoo.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Name = "Final Fantasy 1" },
                new Game { Id = 2, Name = "Final Fantasy 2" },
                new Game { Id = 3, Name = "Final Fantasy 3" },
                new Game { Id = 4, Name = "Final Fantasy 4" },
                new Game { Id = 5, Name = "Final Fantasy 5" },
                new Game { Id = 6, Name = "Final Fantasy 6" },
                new Game { Id = 7, Name = "Final Fantasy 7" },
                new Game { Id = 8, Name = "Final Fantasy 8" },
                new Game { Id = 9, Name = "Final Fantasy 9" },
                new Game { Id = 10, Name = "Final Fantasy 10" },
                new Game { Id = 11, Name = "Final Fantasy 11" },
                new Game { Id = 12, Name = "Final Fantasy 12" },
                new Game { Id = 13, Name = "Final Fantasy 13" },
                new Game { Id = 14, Name = "Final Fantasy 14" },
                new Game { Id = 15, Name = "Final Fantasy 15" },
                new Game { Id = 16, Name = "Final Fantasy Crystal Chronicles" },
                new Game { Id = 17, Name = "Final Fantasy Type-0" },
                new Game { Id = 18, Name = "World Of Final Fantasy" },
                new Game { Id = 19, Name = "Final Fantasy Tactics" }
            );

            modelBuilder.Entity<Champion>().HasData(
                new Champion
                {
                    Id = 1,
                    ChampName = "Warrior Of Light",
                    ChampType = "Sword",
                    ChampCrystal = "White",
                    HG7starPlus = true,
                    HG7star = true,
                    BT = true,
                    BTplus = false,
                    EX = true,
                    LD = true,
                    W15cp = true,
                    W35cp = true,
                    HG35 = true,
                    HG90 = true,
                    HG90plus = true,
                    ChampSphere1 = "A",
                    ChampSphere2 = "B",
                    ChampSphere3 = "D",
                    ChampClevel = 80,
                    HP = 13955,
                    IBRV = 5081,
                    MBRV = 10262,
                    ATK = 3517,
                    DEF = 6024,
                    GameId = 1, 
                },
                new Champion
                {
                    Id = 2,
                    ChampName = "Vivi",
                    ChampType = "Staff",
                    ChampCrystal = "Black",
                    HG7starPlus = true,
                    HG7star = true,
                    BT = true,
                    BTplus = false,
                    EX = true,
                    LD = true,
                    W15cp = true,
                    W35cp = true,
                    HG35 = true,
                    HG90 = true,
                    HG90plus = true,
                    ChampSphere1 = "A",
                    ChampSphere2 = "B",
                    ChampSphere3 = "D",
                    ChampClevel = 80,
                    HP = 13955,
                    IBRV = 5081,
                    MBRV = 10262,
                    ATK = 3517,
                    DEF = 6024,
                    GameId = 9,
                },
                new Champion
                {
                    Id = 4,
                    ChampName = "Garnet",
                    ChampType = "Staff",
                    ChampCrystal = "Black",
                    HG7starPlus = true,
                    HG7star = true,
                    BT = true,
                    BTplus = false,
                    EX = true,
                    LD = true,
                    W15cp = true,
                    W35cp = true,
                    HG35 = true,
                    HG90 = true,
                    HG90plus = true,
                    ChampSphere1 = "A",
                    ChampSphere2 = "B",
                    ChampSphere3 = "D",
                    ChampClevel = 80,
                    HP = 13955,
                    IBRV = 5081,
                    MBRV = 10262,
                    ATK = 3517,
                    DEF = 6024,
                    GameId = 9,
                },
                new Champion
                {
                    Id = 3,
                    ChampName = "Rem",
                    ChampType = "Dagger",
                    ChampCrystal = "Green",
                    HG7starPlus = true,
                    HG7star = true,
                    BT = true,
                    BTplus = false,
                    EX = true,
                    LD = true,
                    W15cp = true,
                    W35cp = true,
                    HG35 = true,
                    HG90 = true,
                    HG90plus = true,
                    ChampSphere1 = "A",
                    ChampSphere2 = "B",
                    ChampSphere3 = "D",
                    ChampClevel = 80,
                    HP = 13955,
                    IBRV = 5081,
                    MBRV = 10262,
                    ATK = 3517,
                    DEF = 6024,
                    GameId = 17,
                }
            );
        }

        public DbSet<Champion> Champions { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
