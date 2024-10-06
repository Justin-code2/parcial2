using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.API.Data;
using Project.Shared.Entities;

namespace Project.API.Controllers
{
    [ApiController]
    [Route("/api/Prizes")]
    public class PrizesController : ControllerBase
    {
        private readonly DataContext _context;

        public PrizesController(DataContext context)
        {
            _context = context;
        }

        //Get con lista


        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Prizes.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var prize = await _context.Prizes.FirstOrDefaultAsync(x => x.Id == id);

            if (prize == null)
            {


                return NotFound();
            }

            return Ok(prize);


        }


        [HttpPost]
        public async Task<ActionResult> Post(Prize prize)
        {
            _context.Add(prize);
            await _context.SaveChangesAsync();
            return Ok(prize);
        }


        // Put- modificar un participante
        [HttpPut]

        public async Task<ActionResult> Put(Prize prize)
        {

            _context.Update(prize);
            await _context.SaveChangesAsync();

            return Ok(prize);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Prizes
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