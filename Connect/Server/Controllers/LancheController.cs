using Connect.Server;
using Microsoft.AspNetCore.Mvc;
using Connect.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class LancheController : Controller
{
    private readonly ApplicationDbContext db;

    public LancheController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var lanches = await db.Lanches.ToListAsync();
        return Ok(lanches);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var lanche = await db.Lanches.SingleOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        return Ok(lanche);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Lanche lanche)
    {
        try
        {
            var newLanche = new Lanche
            {
                Nome = lanche.Nome,
                Valor = lanche.Valor
            };

            db.Add(newLanche);
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
    public async Task<IActionResult> Put([FromBody] Lanche lanche)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(lanche).State = EntityState.Modified;
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
    public async Task<ActionResult<Lanche>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var lanche = await db.Lanches.FindAsync(id);
        if (lanche == null)
        {
            return NotFound();
        }
        db.Lanches.Remove(lanche);
        await db.SaveChangesAsync();
        return lanche;
    }

    private bool LancheExists(int id)
    {
        return db.Lanches.Any(e => e.Id == id);
    }

}