using Connect.Server;
using Microsoft.AspNetCore.Mvc;
using Connect.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;


[ApiController]
[Route("[controller]")]
public class EnderecoController : Controller
{
    private readonly ApplicationDbContext db;

    public EnderecoController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var enderecos = await db.Enderecos.ToListAsync();
        return Ok(enderecos);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var endereco = await db.Enderecos.SingleOrDefaultAsync(x => x.Id == Convert.ToInt32(id));
        return Ok(endereco);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Endereco endereco)
    {
        try
        {
            var newEndereco = new Endereco
            {
                CEP = endereco.CEP,
                Rua = endereco.Rua,
                Bairro = endereco.Bairro,
                Numero = endereco.Numero,
                Cidade = endereco.Cidade,
                Estado = endereco.Estado,
            };

            db.Add(newEndereco);
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
    public async Task<IActionResult> Put([FromBody] Endereco endereco)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(endereco).State = EntityState.Modified;
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
    public async Task<ActionResult<Endereco>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var endereco = await db.Enderecos.FindAsync(id);
        if (endereco == null)
        {
            return NotFound();
        }
        db.Enderecos.Remove(endereco);
        await db.SaveChangesAsync();
        return endereco;
    }

    private bool EnderecoExists(int id)
    {
        return db.Enderecos.Any(e => e.Id == id);
    }

}