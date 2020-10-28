using Connect.Server;
using Microsoft.AspNetCore.Mvc;
using Connect.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;


[ApiController]
[Route("[controller]")]
public class OrderController : Controller
{
    private readonly ApplicationDbContext db;

    public OrderController(ApplicationDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var orderdetails = await db.OrderDetails.ToListAsync();
        return Ok(orderdetails);
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
    public async Task<ActionResult> Post([FromBody] OrderDTO dp)
    {
        try
        {
            var order = new Order{
                DateOrder = DateTime.Now,
                User = null
            };

            var newDp = new OrderDetail
            {
                Order = order,
                Sandwich = db.Sandwiches.FirstOrDefault(c => c.SandwichId == Convert.ToInt32(dp.SandwichId)),
                Amount = dp.Amount
            };

            db.Add(newDp);
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

    // [HttpDelete]
    // [Route("Delete/{id}")]
    // public async Task<ActionResult<User>> Delete(int id)
    // {
    //     if (!ModelState.IsValid)
    //     {
    //         return BadRequest(ModelState);
    //     }
    //     var product = await db.Products.FindAsync(id);
    //     if (product == null)
    //     {
    //         return NotFound();
    //     }
    //     db.Products.Remove(product);
    //     await db.SaveChangesAsync();
    //     return Ok(product);
    // }


}