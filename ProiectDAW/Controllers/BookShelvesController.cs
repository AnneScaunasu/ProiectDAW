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
    public class BookShelvesController : ControllerBase
    {
        private readonly DataContext _context;

        public BookShelvesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/BookShelves
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookShelf>>> GetBookShelf()
        {
            return await _context.BookShelf.ToListAsync();
        }

        // GET: api/BookShelves/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookShelf>> GetBookShelf(int id)
        {
            var bookShelf = await _context.BookShelf.FindAsync(id);

            if (bookShelf == null)
            {
                return NotFound();
            }

            return bookShelf;
        }

        // PUT: api/BookShelves/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookShelf(int id, BookShelf bookShelf)
        {
            if (id != bookShelf.Id)
            {
                return BadRequest();
            }

            _context.Entry(bookShelf).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookShelfExists(id))
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

        // POST: api/BookShelves
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookShelf>> PostBookShelf(BookShelf bookShelf)
        {
            _context.BookShelf.Add(bookShelf);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookShelf", new { id = bookShelf.Id }, bookShelf);
        }

        // DELETE: api/BookShelves/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookShelf(int id)
        {
            var bookShelf = await _context.BookShelf.FindAsync(id);
            if (bookShelf == null)
            {
                return NotFound();
            }

            _context.BookShelf.Remove(bookShelf);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookShelfExists(int id)
        {
            return _context.BookShelf.Any(e => e.Id == id);
        }
    }
}
