using Connect.Server;
using Microsoft.AspNetCore.Mvc;
using Connect.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;


[ApiController]
[Route("[controller]")]
public class SandwichController : Controller
{
    private readonly ApplicationDbContext db;

    public SandwichController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var sandwiches = await db.Sandwiches.ToListAsync();
        return Ok(sandwiches);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var sandwiche = await db.Sandwiches.SingleOrDefaultAsync(x => x.SandwichId == Convert.ToInt32(id));
        return Ok(sandwiche);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] SandwichDTO sandwich)
    {
        try
        {
            //var categoria = db.Categories.FirstOrDefault(x => x.Id == Convert.ToInt32(product.CategoriaId));
            var newSandwich = new Sandwich
            {
                Name = sandwich.Name,
                Description = sandwich.Description,
                Price = sandwich.Price,
                CategoryId = Convert.ToInt32(sandwich.CategoryId)
            };

            db.Add(newSandwich);
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
    public async Task<IActionResult> Put([FromBody] Sandwich sandwich)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(sandwich).State = EntityState.Modified;
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
    public async Task<ActionResult<User>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var sandwich = await db.Sandwiches.FindAsync(id);
        if (sandwich == null)
        {
            return NotFound();
        }
        db.Sandwiches.Remove(sandwich);
        await db.SaveChangesAsync();
        return Ok(sandwich);
    }


}