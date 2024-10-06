using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.API.Data;
using Project.Shared.Entities;

namespace Project.API.Controllers
{
    [ApiController]
    [Route("/api/Mentors")]
    public class MentorsController : ControllerBase
    {
        private readonly DataContext _context;

        public MentorsController(DataContext context)
        {
            _context = context;
        }

        //Get con lista


        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Mentors.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var mentor = await _context.Mentors.FirstOrDefaultAsync(x => x.Id == id);

            if (mentor == null)
            {


                return NotFound();
            }

            return Ok(mentor);


        }


        [HttpPost]
        public async Task<ActionResult> Post(Mentor mentor)
        {
            _context.Add(mentor);
            await _context.SaveChangesAsync();
            return Ok(mentor);
        }


        // Put- modificar un participante
        [HttpPut]

        public async Task<ActionResult> Put(Mentor mentor)
        {

            _context.Update(mentor);
            await _context.SaveChangesAsync();

            return Ok(mentor);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Mentors
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