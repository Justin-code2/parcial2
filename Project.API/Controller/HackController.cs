using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.API.Data;
using Project.Shared.Entities;

namespace Project.API.Controllers
{
    [ApiController]
    [Route("/api/Hacks")]
    public class HacksController : ControllerBase
    {
        private readonly DataContext _context;

        public HacksController(DataContext context)
        {
            _context = context;
        }

        //Get con lista


        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Hacks.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var hack = await _context.Hacks.FirstOrDefaultAsync(x => x.Id == id);

            if (hack == null)
            {


                return NotFound();
            }

            return Ok(hack);


        }


        [HttpPost]
        public async Task<ActionResult> Post(Hack hack)
        {
            _context.Add(hack);
            await _context.SaveChangesAsync();
            return Ok(hack);
        }


        // Put- modificar un participante
        [HttpPut]

        public async Task<ActionResult> Put(Hack hack)
        {

            _context.Update(hack);
            await _context.SaveChangesAsync();

            return Ok(hack);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Hacks
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