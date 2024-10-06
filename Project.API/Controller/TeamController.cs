using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.API.Data;
using Project.Shared.Entities;

namespace Project.API.Controllers
{
    [ApiController]
    [Route("/api/Teams")]
    public class TeamsController : ControllerBase
    {
        private readonly DataContext _context;

        public TeamsController(DataContext context)
        {
            _context = context;
        }

        //Get con lista


        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Teams.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);

            if (team == null)
            {


                return NotFound();
            }

            return Ok(team);


        }


        [HttpPost]
        public async Task<ActionResult> Post(Team team)
        {
            _context.Add(team);
            await _context.SaveChangesAsync();
            return Ok(team);
        }


        // Put- modificar un participante
        [HttpPut]

        public async Task<ActionResult> Put(Team team)
        {

            _context.Update(team);
            await _context.SaveChangesAsync();

            return Ok(team);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Teams
                .Where(a => a.Id == id)
                .ExecuteDeleteAsync();






            if (FilasAfectadas == 0)
            {

                return NotFound();

            }
            else
            {
                return NoContent();



            }
        }


    }
}