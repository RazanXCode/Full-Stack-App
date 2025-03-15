using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Model;

namespace OrderService.Contoller
{

    [Route("api/order")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly MyAppDbContext _context;
        public OrderController(MyAppDbContext context)
        {
            _context = context;
        }

        // CRUD Opreations 


        // Opreation 1: Read Orders  ( Reading list of orders ) , ( reading a spcific order)

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrders()
        {
            var orders = await _context.orders.ToListAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetProduct([FromRoute] int id)
        {
            var order = await _context.orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);

        }
        //---------------------------------------------------------------------------------------------


        // Opreation 2: Create

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder([FromBody] Order order)
        {

            _context.orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllOrders), new { id = order.Id }, order);

        }

        //---------------------------------------------------------------------------------------------


        // Opreation 3: Update

        [HttpPut("{id}")]

        public async Task<ActionResult<Order>> UpdateOrder([FromRoute] int id, [FromBody] Order UpdatedOrder)
        {

            if (id != UpdatedOrder.Id)
            {
                return BadRequest("Order ID mismatch");

            }
            var existingOrder = await _context.orders.FindAsync(id);


            if (existingOrder == null)
            {
                return NotFound();
            }

            //Update the spcific product 
            existingOrder.Status= UpdatedOrder.Status;
            existingOrder.TotalAmount = UpdatedOrder.TotalAmount;
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "An error occurred while updating the order.");
            }

            return NoContent();

        }


        //---------------------------------------------------------------------------------------------


        // Opreation 4: Delete 
        [HttpDelete("{id}")]

        public async Task<ActionResult<Order>> DeleteOrder([FromRoute] int id)
        {

            var deleteOrder = await _context.orders.FindAsync(id);

            if (deleteOrder == null)
            {
                return NotFound();


             }

            _context.orders.Remove(deleteOrder);
            await _context.SaveChangesAsync();

            return NoContent();


        }










    }

}