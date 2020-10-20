using Connect.Server;
using Microsoft.AspNetCore.Mvc;
using Connect.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class ItemController : Controller
{
    private readonly ApplicationDbContext db;

    public ItemController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var lanches = await db.Items.ToListAsync();
        return Ok(lanches);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var lanche = await db.Items.SingleOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        return Ok(lanche);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Item item)
    {
        try
        {
            var newItem = new Item
            {
                LancheId = item.LancheId,
                PedidoId = item.PedidoId,
            };
            
            db.Add(newItem);
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
    public async Task<IActionResult> Put([FromBody] Item item)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(item).State = EntityState.Modified;
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
    public async Task<ActionResult<Item>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var item = await db.Items.FindAsync(id);
        if (item == null)
        {
            return NotFound();
        }
        db.Items.Remove(item);
        await db.SaveChangesAsync();
        return item;
    }

    private bool ItemExists(int id)
    {
        return db.Items.Any(e => e.Id == id);
    }

}