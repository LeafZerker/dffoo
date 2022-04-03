namespace dffoo.Client.Services.ChampionsService
{
    public interface IChampService
    {
        List<Champion> Champs { get; set; }
        List<Game> Games { get; set; }
        Task GetGames();
        Task GetChampions();
        Task<Champion> GetSingleChamp(int id);
        Task CreateChampion(Champion champ);
        Task UpdateChampion(Champion champ);
        Task DeleteChampion(int id);
    }
}
