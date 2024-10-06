using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.API.Data;
using Project.Shared.Entities;

namespace Project.API.Controllers
{
    [ApiController]
    [Route("/api/Participants")]
    public class ParticipantsController : ControllerBase
    {
        private readonly DataContext _context;

        public ParticipantsController(DataContext context)
        {
            _context = context;
        }

        //Get con lista


        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Participants.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var participant = await _context.Participants.FirstOrDefaultAsync(x => x.Id == id);

            if (participant == null)
            {


                return NotFound();
            }

            return Ok(participant);


        }


        [HttpPost]
        public async Task<ActionResult> Post(Participant participant)
        {
            _context.Add(participant);
            await _context.SaveChangesAsync();
            return Ok(participant);
        }


        // Put- modificar un participante
        [HttpPut]

        public async Task<ActionResult> Put(Participant participant)
        {

            _context.Update(participant);
            await _context.SaveChangesAsync();

            return Ok(participant);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Participants
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