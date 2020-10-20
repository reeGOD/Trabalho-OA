using Connect.Server;
using Microsoft.AspNetCore.Mvc;
using Connect.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class LancheIngredienteController : Controller
{
    private readonly ApplicationDbContext db;

    public LancheIngredienteController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var lancheingredientes = await db.LancheIngredientes.ToListAsync();
        return Ok(lancheingredientes);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var lancheingredientes = await db.LancheIngredientes.SingleOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        return Ok(lancheingredientes);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] LancheIngrediente lancheingrediente)
    {
        try
        {
            var newLancheIngrediente = new LancheIngrediente
            {

                
            };

            db.Add(newLancheIngrediente);
            await db.SaveChangesAsync();//INSERT INTO
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }

     [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> Put([FromBody] LancheIngrediente lancheingrediente)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(lancheingrediente).State = EntityState.Modified;
        try
        {
            await db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw (ex);
        }
        return NoContent();
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<ActionResult<LancheIngrediente>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var lancheingrediente = await db.LancheIngredientes.FindAsync(id);
        if (lancheingrediente == null)
        {
            return NotFound();
        }
        db.LancheIngredientes.Remove(lancheingrediente);
        await db.SaveChangesAsync();
        return lancheingrediente;
    }

    private bool LancheIngredienteExists(int id)
    {
        return db.LancheIngredientes.Any(e => e.Id == id);
    }

}