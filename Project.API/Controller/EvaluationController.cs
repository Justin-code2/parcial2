using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.API.Data;
using Project.Shared.Entities;

namespace Project.API.Controllers
{
    [ApiController]
    [Route("/api/Evaluations")]
    public class EvaluationsController : ControllerBase
    {
        private readonly DataContext _context;

        public EvaluationsController(DataContext context)
        {
            _context = context;
        }

        //Get con lista


        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Evaluations.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var evaluation = await _context.Evaluations.FirstOrDefaultAsync(x => x.Id == id);

            if (evaluation == null)
            {


                return NotFound();
            }

            return Ok(evaluation);


        }


        [HttpPost]
        public async Task<ActionResult> Post(Evaluation evaluation)
        {
            _context.Add(evaluation);
            await _context.SaveChangesAsync();
            return Ok(evaluation);
        }


        // Put- modificar un participante
        [HttpPut]

        public async Task<ActionResult> Put(Evaluation evaluation)
        {

            _context.Update(evaluation);
            await _context.SaveChangesAsync();

            return Ok(evaluation);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilasAfectadas = await _context.Evaluations
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