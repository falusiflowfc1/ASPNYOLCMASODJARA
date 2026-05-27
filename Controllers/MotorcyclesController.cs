using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNYOLCMASODJARA.Models;

[Route("api/[controller]")]
[ApiController]
public class MotorcyclesController : ControllerBase
{
    private readonly motorcyclesDBContext _context;
    public MotorcyclesController(motorcyclesDBContext context)
    {
        _context = context;
    }

    // GET: api/Motorcycle
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Motorcycle>>> GetMotorcycle()
    {
        return await _context.Motorcycles.ToListAsync();
    }

    // GET: api/Motorcycle/5
    [HttpGet("{motorcycleid}")]
    public async Task<ActionResult<Motorcycle>> GetMotorcycle(int motorcycleid)
    {
        var motorcycle = await _context.Motorcycles.FindAsync(motorcycleid);

        if (motorcycle == null)
        {
            return NotFound();
        }

        return motorcycle;
    }

    // PUT: api/Motorcycle/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{motorcycleid}")]
    public async Task<IActionResult> PutMotorcycle(int? motorcycleid, Motorcycle motorcycle)
    {
        if (motorcycleid != motorcycle.MotorcycleId)
        {
            return BadRequest();
        }

        _context.Entry(motorcycle).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!MotorcycleExists(motorcycleid))
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

    // POST: api/Motorcycle
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Motorcycle>> PostMotorcycle(Motorcycle motorcycle)
    {
        _context.Motorcycles.Add(motorcycle);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetMotorcycle", new { motorcycleid = motorcycle.MotorcycleId }, motorcycle);
    }

    // DELETE: api/Motorcycle/5
    [HttpDelete("{motorcycleid}")]
    public async Task<IActionResult> DeleteMotorcycle(int? motorcycleid)
    {
        var motorcycle = await _context.Motorcycles.FindAsync(motorcycleid);
        if (motorcycle == null)
        {
            return NotFound();
        }

        _context.Motorcycles.Remove(motorcycle);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool MotorcycleExists(int? motorcycleid)
    {
        return _context.Motorcycles.Any(e => e.MotorcycleId == motorcycleid);
    }
}
