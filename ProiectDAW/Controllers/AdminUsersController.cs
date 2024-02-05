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
    public class AdminUsersController : ControllerBase
    {
        private readonly DataContext _context;

        public AdminUsersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/AdminUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminUser>>> GetAdminUsers()
        {
            return await _context.AdminUsers.ToListAsync();
        }

        // GET: api/AdminUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminUser>> GetAdminUser(int id)
        {
            var adminUser = await _context.AdminUsers.FindAsync(id);

            if (adminUser == null)
            {
                return NotFound();
            }

            return adminUser;
        }

        // PUT: api/AdminUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminUser(int id, AdminUser adminUser)
        {
            if (id != adminUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(adminUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminUserExists(id))
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

        // POST: api/AdminUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{adminId}")]
        public async Task<ActionResult<AdminUser>> PostAdminUser(AdminUser adminUser, int adminId)
        {
            if (AdminUserExists(adminId))
            {
                _context.AdminUsers.Add(adminUser);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetAdminUser", new { id = adminUser.Id }, adminUser);
            }
            return BadRequest();
        }

        // DELETE: api/AdminUsers/5
        [HttpDelete("{id}/{adminId}")]
        public async Task<IActionResult> DeleteAdminUser(int id, int adminId)
        {
            if (AdminUserExists(adminId))
            {
                var adminUser = await _context.AdminUsers.FindAsync(id);
                if (adminUser == null)
                {
                    return NotFound();
                }

                _context.AdminUsers.Remove(adminUser);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            return BadRequest();
        }

        private bool AdminUserExists(int id)
        {
            return _context.AdminUsers.Any(e => e.Id == id);
        }
    }
}
