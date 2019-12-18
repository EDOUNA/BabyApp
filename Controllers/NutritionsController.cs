using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BabyApp.Data;
using BabyApp.Models;

namespace BabyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionsController : ControllerBase
    {
        private readonly BabyAppContext _context;

        public NutritionsController(BabyAppContext context)
        {
            _context = context;
        }

        // GET: api/Nutritions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nutritions>>> GetNutritions()
        {
            return await _context.Nutritions.ToListAsync();
        }

        // GET: api/Nutritions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nutritions>> GetNutritions(int id)
        {
            var nutritions = await _context.Nutritions.FindAsync(id);

            if (nutritions == null)
            {
                return NotFound();
            }

            return nutritions;
        }

        // PUT: api/Nutritions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNutritions(int id, Nutritions nutritions)
        {
            if (id != nutritions.Id)
            {
                return BadRequest();
            }

            _context.Entry(nutritions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NutritionsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Nutritions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Nutritions>> PostNutritions(Nutritions nutritions)
        {
            _context.Nutritions.Add(nutritions);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNutritions", new { id = nutritions.Id }, nutritions);
        }

        // DELETE: api/Nutritions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Nutritions>> DeleteNutritions(int id)
        {
            var nutritions = await _context.Nutritions.FindAsync(id);
            if (nutritions == null)
            {
                return NotFound();
            }

            _context.Nutritions.Remove(nutritions);
            await _context.SaveChangesAsync();

            return nutritions;
        }

        private bool NutritionsExists(int id)
        {
            return _context.Nutritions.Any(e => e.Id == id);
        }
    }
}
