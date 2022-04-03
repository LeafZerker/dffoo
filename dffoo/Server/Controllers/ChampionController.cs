using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dffoo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ChampionController : ControllerBase
    {
        private readonly DataContext _context;

        public ChampionController(DataContext context)
        {
            _context = context;
        }

        [HttpPost, Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<Champion>>> CreateChampion(Champion champion)
        {
            champion.Game = null;
            _context.Champions.Add(champion);
            await _context.SaveChangesAsync();

            return Ok(await GetDbChamps());
        }

        [HttpGet, AllowAnonymous]
        public async Task<ActionResult<List<Champion>>> GetChampions()
        {
            var champs = await _context.Champions.Include(_ => _.Game).ToListAsync();
            return Ok(champs);
        }

        [HttpGet("games"), AllowAnonymous]
        public async Task<ActionResult<List<Game>>> GetGames()
        {
            var series = await _context.Games.ToListAsync();
            return Ok(series);
        }

        [HttpGet("{id}"), AllowAnonymous]
        public async Task<ActionResult<Champion>> GetSingleChampion(int id)
        {
            var champ = await _context.Champions
                .Include(c => c.Game)
                .FirstOrDefaultAsync(c => c.Id == id);
            if(champ == null)
            {
                return BadRequest("No matching champ");
            }
            return Ok(champ);
        }

        [HttpPut("{id}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<Champion>>> UpdateChampion(Champion champion, int id)
        {
            var dbChamp = await _context.Champions
                .Include(c => c.Game)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (dbChamp == null)
                return NotFound("Champion Not Found");

            dbChamp.ChampName = champion.ChampName;
            dbChamp.ChampType = champion.ChampType;
            dbChamp.ChampCrystal = champion.ChampCrystal;
            dbChamp.BT = champion.BT;
            dbChamp.BTplus = champion.BTplus;
            dbChamp.ChampClevel = champion.ChampClevel;
            dbChamp.ChampSphere1 = champion.ChampSphere1;
            dbChamp.ChampSphere2 = champion.ChampSphere2;
            dbChamp.ChampSphere3 = champion.ChampSphere3;
            dbChamp.EX = champion.EX;
            dbChamp.EXplus = champion.EXplus;
            dbChamp.HG35 = champion.HG35;
            dbChamp.HG90 = champion.HG90;
            dbChamp.HG90plus = champion.HG90plus;
            dbChamp.HG7star = champion.HG7star;
            dbChamp.HG7starPlus = champion.HG7starPlus;
            dbChamp.W15cp = champion.W15cp;
            dbChamp.W35cp = champion.W35cp;
            dbChamp.LD = champion.LD;
            dbChamp.ATK = champion.ATK;
            dbChamp.DEF = champion.DEF;
            dbChamp.IBRV = champion.IBRV;
            dbChamp.HP = champion.HP;
            dbChamp.MBRV = champion.MBRV;
            dbChamp.GameId = champion.GameId;

            await _context.SaveChangesAsync();

            return Ok(await GetDbChamps());

        }

        [HttpDelete("{id}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<Champion>>> DeleteChampion(int id)
        {
            var dbChamp = await _context.Champions
                .Include(c => c.Game)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (dbChamp == null)
                return NotFound("Champion Not Found");

            _context.Champions.Remove(dbChamp);
            await _context.SaveChangesAsync();

            return Ok(await GetDbChamps());
        }

        private async Task<List<Champion>> GetDbChamps()
        {
            return await _context.Champions.Include(c => c.Game).ToListAsync();
        }

    }
}
