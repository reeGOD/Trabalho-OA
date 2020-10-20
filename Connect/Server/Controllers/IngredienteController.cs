using Connect.Server;
using Microsoft.AspNetCore.Mvc;
using Connect.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class IngredienteController : Controller
{
    private readonly ApplicationDbContext db;

    public IngredienteController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var ingredientes = await db.Items.ToListAsync();
        return Ok(ingredientes);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var ingrediente = await db.Items.SingleOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        return Ok(ingrediente);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Ingrediente ingrediente)
    {
        try
        {
            var newIngrediente = new Ingrediente
            {
                Nome = ingrediente.Nome,
            };
            
            db.Add(newIngrediente);
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
    public async Task<IActionResult> Put([FromBody] Ingrediente ingrediente)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(ingrediente).State = EntityState.Modified;
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
    public async Task<ActionResult<Ingrediente>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var ingrediente = await db.Ingredientes.FindAsync(id);
        if (ingrediente == null)
        {
            return NotFound();
        }
        db.Ingredientes.Remove(ingrediente);
        await db.SaveChangesAsync();
        return ingrediente;
    }

    private bool IngredienteExists(int id)
    {
        return db.Ingredientes.Any(e => e.Id == id);
    }

}