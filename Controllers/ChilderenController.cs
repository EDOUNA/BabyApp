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
    public class ChilderenController : ControllerBase
    {
        private readonly BabyAppContext _context;

        public ChilderenController(BabyAppContext context)
        {
            _context = context;
        }

        // GET: api/Childeren
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Childeren>>> GetChilderen()
        {
            return await _context.Childeren.ToListAsync();
        }

        // GET: api/Childeren/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Childeren>> GetChilderen(long id)
        {
            var childeren = await _context.Childeren.FindAsync(id);

            if (childeren == null)
            {
                return NotFound();
            }

            return childeren;
        }

        // PUT: api/Childeren/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChilderen(long id, Childeren childeren)
        {
            if (id != childeren.Id)
            {
                return BadRequest();
            }

            _context.Entry(childeren).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChilderenExists(id))
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

        // POST: api/Childeren
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Childeren>> PostChilderen(Childeren childeren)
        {
            _context.Childeren.Add(childeren);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChilderen", new { id = childeren.Id }, childeren);
        }

        // DELETE: api/Childeren/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Childeren>> DeleteChilderen(long id)
        {
            var childeren = await _context.Childeren.FindAsync(id);
            if (childeren == null)
            {
                return NotFound();
            }

            _context.Childeren.Remove(childeren);
            await _context.SaveChangesAsync();

            return childeren;
        }

        private bool ChilderenExists(long id)
        {
            return _context.Childeren.Any(e => e.Id == id);
        }
    }
}
