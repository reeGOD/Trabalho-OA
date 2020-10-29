using Connect.Server;
using Microsoft.AspNetCore.Mvc;
using Connect.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class AddressController : Controller
{
    private readonly ApplicationDbContext db;

    public AddressController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var addresses = await db.Addresses.ToListAsync();
        return Ok(addresses);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var address = await db.Addresses.SingleOrDefaultAsync(x => x.AddressId == Convert.ToInt32(id));
        return Ok(address);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] AddressDTO address)
    {
        try
        {
            var newAddress = new Address
            {
                CEP = address.CEP,
                Rua = address.Rua,
                Bairro = address.Bairro,
                Numero = address.Numero,
                Cidade = address.Cidade,
                Estado = address.Estado,
                UserId = Convert.ToInt32(address.UserId)
            };

            db.Add(newAddress);
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
    public async Task<IActionResult> Put([FromBody] Address address)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(address).State = EntityState.Modified;
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
    public async Task<ActionResult<Address>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var address = await db.Addresses.FindAsync(id);
        if (address == null)
        {
            return NotFound();
        }
        db.Addresses.Remove(address);
        await db.SaveChangesAsync();
        return NoContent();
    }

    private bool AddressExists(int id)
    {
        return db.Addresses.Any(e => e.AddressId == id);
    }

}