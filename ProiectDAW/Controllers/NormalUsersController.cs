using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProiectDAW;
using ProiectDAW.Data;

namespace ProiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NormalUsersController : ControllerBase
    {
        private readonly DataContext _context;

        public NormalUsersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/NormalUsers1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NormalUser>>> GetNormalUsers()
        {
            return await _context.NormalUsers.ToListAsync();
        }

        // GET: api/NormalUsers1/5
        [HttpGet("{id}/{password}")]
        public async Task<ActionResult<NormalUser>> GetNormalUser(int id, String password)
        {
            var normalUser = await _context.NormalUsers.FindAsync(id);

            if (normalUser == null || normalUser.Password != password)
            {
                return NotFound();
            }

            return normalUser;
        }

        // PUT: api/NormalUsers1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNormalUser(int id, NormalUser normalUser)
        {
            if (id != normalUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(normalUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NormalUserExists(id))
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

        // POST: api/NormalUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost()]
        public async Task<ActionResult<NormalUser>> PostNormalUser(NormalUser normalUser)
        {
            _context.NormalUsers.Add(normalUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNormalUser", new { id = normalUser.Id }, normalUser);

        }

        // DELETE: api/NormalUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNormalUser(int id)
        {
            var normalUser = await _context.NormalUsers.FindAsync(id);
            if (normalUser == null)
            {
                return NotFound();
            }

            _context.NormalUsers.Remove(normalUser);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool NormalUserExists(int id)
        {
            return _context.NormalUsers.Any(e => e.Id == id);
        }
    }
}
