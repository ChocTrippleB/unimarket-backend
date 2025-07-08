using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using unimarket_backend.Data;
using unimarket_backend.Models;

namespace unimarket_backend.Controllers
{
    [Route("api/items")]
    public class ItemsController : Controller
    {
        private readonly AppDbContext _context;
        public ItemsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            var items = _context.Items.ToList();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetById(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }

        // POST: api/items
        [HttpPost]
        public async Task<ActionResult<Item>> Create(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        // PUT: api/items/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Item updatedItem)
        {
            if (id != updatedItem.Id) return BadRequest();

            _context.Entry(updatedItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Items.Any(e => e.Id == id)) return NotFound();
                else throw;
            }

            return NoContent();
        }

        // DELETE: api/items/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null) return NotFound();

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
