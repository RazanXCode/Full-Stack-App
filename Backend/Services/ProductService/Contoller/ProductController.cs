using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductService.Data;
using ProductService.Model;

namespace ProductService.Contoller
{

    [Route("api/product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly MyAppDbContext _context;
        public ProductController(MyAppDbContext context)
        {
            _context = context;
        }

        // CRUD Opreations 


        // Opreation 1: Read Products  ( Reading list of products ) , ( reading a spcific product detailes)

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = await _context.products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct([FromRoute] int id)
        {
            var product = await _context.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }
        //---------------------------------------------------------------------------------------------


        // Opreation 2: Create , Note : Recive JSON data then desrlize the body to Product object 

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct([FromBody] Product product)
        {

            _context.products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllProducts), new { id = product.Id }, product);

        }

        //---------------------------------------------------------------------------------------------


        // Opreation 3: Update

        [HttpPut("{id}")]

        public async Task<ActionResult<Product>> UpdateProduct([FromRoute] int id, [FromBody] Product UpdatedProduct)
        {

            if (id != UpdatedProduct.Id)
            {
                return BadRequest("Product ID mismatch");

            }
            var existingProduct = await _context.products.FindAsync(id);


            if (existingProduct == null)
            {
                return NotFound();
            }

            //Update the spcific product 
            existingProduct.Name = UpdatedProduct.Name;
            existingProduct.Price = UpdatedProduct.Price;
            existingProduct.Description = UpdatedProduct.Description;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "An error occurred while updating the product.");
            }

            return NoContent();

        }


        //---------------------------------------------------------------------------------------------


        // Opreation 4: Delete 
        [HttpDelete("{id}")]

        public async Task<ActionResult<Product>> DeleteProduct([FromRoute] int id)
        {

            var deleteProduct = await _context.products.FindAsync(id);

            if (deleteProduct == null)
            {
                return NotFound();


             }

            _context.products.Remove(deleteProduct);
            await _context.SaveChangesAsync();

            return NoContent();


        }










    }

}