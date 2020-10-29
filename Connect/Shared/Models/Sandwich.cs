using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Connect.Shared
{
    public class Sandwich
    {
        public int SandwichId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public Decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
} 