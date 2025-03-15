using System.ComponentModel.DataAnnotations;

namespace OrderService.Model
{

    public class Order
    {


        [Key]
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }


    }


}