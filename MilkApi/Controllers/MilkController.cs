using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MilkApi.Data;
using MilkApi.Models;

namespace MilkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MilkController : ControllerBase
    {
        private readonly MilkDbContext _context;

        public MilkController(MilkDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Milk>>> GetTodoItems()
        {
            return Ok(await _context.Milk.ToListAsync());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Milk>> GetMilk(Guid id)
        {
            var milk = await _context.Milk.FindAsync(id);

            return milk == null ? NotFound() : Ok(milk);

        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Milk>> PutMilk(Guid id, UpdateMilkRequest updateMilkRequest)
        {
            var milk = await _context.Milk.FindAsync(id);

            if (milk == null)
            {
                return NotFound();
            }

            milk.storage = updateMilkRequest.storage;

            var updatedMilk = _context.Milk.Update(milk);
            _context.SaveChanges();
            return Ok(milk);
        }
    }
}
