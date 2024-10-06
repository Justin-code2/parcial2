using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.API.Data;
using Project.Shared.Entities;

namespace Project.API.Controllers
{
    [ApiController]
    [Route("/api/Plans")]
    public class PlansController : ControllerBase
    {
        private readonly DataContext _context;

        public PlansController(DataContext context)
        {
            _context = context;
        }

        //Get con lista


        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Plans.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var plan = await _context.Plans.FirstOrDefaultAsync(x => x.Id == id);

            if (plan == null)
            {


                return NotFound();
            }

            return Ok(plan);


        }


        [HttpPost]
        public async Task<ActionResult> Post(Plan plan)
        {
            _context.Add(plan);
            await _context.SaveChangesAsync();
            return Ok(plan);
        }


        // Put- modificar un participante
        [HttpPut]

        public async Task<ActionResult> Put(Plan plan)
        {

            _context.Update(plan);
            await _context.SaveChangesAsync();

            return Ok(plan);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Plans
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