using Connect.Server;
using Microsoft.AspNetCore.Mvc;
using Connect.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class PedidoController : Controller
{
    private readonly ApplicationDbContext db;

    public PedidoController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var pedidos = await db.Pedidos.ToListAsync();
        return Ok(pedidos);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var pedido = await db.Pedidos.SingleOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        return Ok(pedido);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Pedido pedido)
    {
        try
        {
            var newPedido = new Pedido
            {
                ValorTotal = pedido.ValorTotal
            };

            db.Add(newPedido);
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
    public async Task<IActionResult> Put([FromBody] Pedido pedido)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(pedido).State = EntityState.Modified;
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
    public async Task<ActionResult<Pedido>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var pedido = await db.Pedidos.FindAsync(id);
        if (pedido == null)
        {
            return NotFound();
        }
        db.Pedidos.Remove(pedido);
        await db.SaveChangesAsync();
        return pedido;
    }

    private bool PedidoExists(int id)
    {
        return db.Pedidos.Any(e => e.Id == id);
    }

}