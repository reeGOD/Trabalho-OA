using Connect.Server;
using Microsoft.AspNetCore.Mvc;
using Connect.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class CategoryController : Controller
{
    private readonly ApplicationDbContext db;

    public CategoryController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var categories = await db.Categories.ToListAsync();
        return Ok(categories);
    }

    // [HttpGet]
    // [Route("GetById")]
    // public async Task<IActionResult> Get([FromQuery] string id)
    // {
    //     var product = await db.Products.SingleOrDefaultAsync(x => x.ProductId == Convert.ToInt32(id));
    //     return Ok(product);
    // }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Category category)
    {
        try
        {
            var newCategory = new Category
            {
                Name = category.Name,
            };

            db.Add(newCategory);
            await db.SaveChangesAsync();//INSERT INTO
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }

    // [HttpPut]
    // [Route("Update")]
    // public async Task<IActionResult> Put([FromBody] Product product)
    // {
    //     if (!ModelState.IsValid)
    //     {
    //         return BadRequest(ModelState);
    //     }

    //     db.Entry(product).State = EntityState.Modified;
    //     try
    //     {
    //         await db.SaveChangesAsync();
    //     }
    //     catch (DbUpdateConcurrencyException ex)
    //     {
    //         throw (ex);
    //     }
    //     return NoContent();
    // }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<ActionResult<User>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var category = await db.Categories.FindAsync(id);
        if (category == null)
        {
             return NotFound();
        }
        db.Categories.Remove(category);
        await db.SaveChangesAsync();
        return Ok(category);
    }


}